using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.IO;

namespace WindowsFormsAppNeaPrototype1
{
    public partial class FormAddSale : Form
    {
        public List<int> listOfOrderItems = new List<int>();
        SoldItems thisOrder;
        string stringOfItems;
        static string filePath;
        static string address = "";
        static string customerName;
        public FormAddSale()
        {
            InitializeComponent();
        }
        public class PrintAddress
        {
            //Print the address and post slip
            private Font font;
            private StreamReader streamReader;
            public PrintAddress()
            {
                Printing();
            }
            private void PrintPage(object sender, PrintPageEventArgs ev)
            {
                float linesPerPage = 0;
                float yPos = 0;
                int count = 0;
                float leftMargin = ev.MarginBounds.Left;
                float topMargin = ev.MarginBounds.Top;
                String line = null;
                linesPerPage = ev.MarginBounds.Height / 
                    font.GetHeight(ev.Graphics);
                while (count < linesPerPage && ((line = streamReader.ReadLine()) != null))
                {
                    yPos = topMargin + (count * font.GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(line, font, Brushes.Black, leftMargin, yPos, new StringFormat());
                    count++;
                }
                if (line != null)
                {
                    ev.HasMorePages = true;
                }
                else
                {
                    ev.HasMorePages = false;
                }
            }
            public void Printing()
            {
                try
                {
                    streamReader = new StreamReader(filePath);
                    try
                    {
                        font = new Font("Arial", 20);
                        PrintDocument printDocument = new PrintDocument();
                        printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
                        printDocument.Print();
                    }
                    finally
                    {
                        streamReader.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void loadForm()
            // Populates the data grid view. Called every time the database is edited to 
            //ensure the data in the data grid view is up to date.
        {
            OleDbConnection conL;
            OleDbCommand cmdL;
            OleDbDataReader readerL;
            BindingSource bindingSourceL;
            conL = new OleDbConnection();
            conL.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdL = new OleDbCommand();
            conL.Open();
            cmdL = conL.CreateCommand();
            cmdL.CommandText = @"SELECT description FROM tableItems WHERE PriceSold IS NULL AND PriceListed IS NOT NULL";
            readerL = cmdL.ExecuteReader();
            if (readerL.HasRows)
            {

                bindingSourceL = new BindingSource();
                bindingSourceL.DataSource = readerL;
                dgvItem.DataSource = bindingSourceL;
                dgvItem.Columns[0].Width = 215;

            }
            conL.Close();
            txtPriceSold.Text = "";
        }

        private void formAddSale_Load(object sender, EventArgs e)
        {

            loadForm();
            //Create a new order
            Customer customer = new Customer("", "", 0);
            thisOrder = new SoldItems(DateTime.Now.ToString("dd/MM/yyyy"), ckbPaid.Checked, ckbPosted.Checked, customer, 0);

            //Create a form closing event to prevent the user from closing the form without 
            //adding the order to the database.
            this.FormClosing += new FormClosingEventHandler(formAddSale_FormClosing);
        }
        private void formAddSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnAddOrder.Enabled == true) 
            //If the user is able to add another order (meaning that there is an order that 
                //has not been added to the orders table yet)
            {
                e.Cancel = true;
                MessageBox.Show("Please add the sold item to an order.");
            }
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            if ((dgvItem.SelectedCells != null) && (txtPriceSold.Text != "")) 
            // only allows the user to add the sale if an iten in the data grid view has 
                //been selected and a valid price had been entered.
            {
                bool success = Decimal.TryParse(txtPriceSold.Text, out decimal priceSold);
                if (success)
                {
                    //Add the price sold to the relevant record in the TableItems table.
                    string description = Convert.ToString(dgvItem.SelectedCells[0].Value);
                    int id = 0;
                    OleDbConnection conAS;
                    OleDbCommand cmdAS;
                    conAS = new OleDbConnection();
                    conAS.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
                    cmdAS = new OleDbCommand();
                    cmdAS.Connection = conAS;
                    conAS.Open();
                    cmdAS = conAS.CreateCommand();
                    cmdAS.CommandText = @"UPDATE tableItems SET tableItems.PriceSold = @ps WHERE(((tableItems.[Description]) = @ds))";
                    cmdAS.Parameters.AddWithValue("@ps", priceSold);
                    cmdAS.Parameters.AddWithValue("@ds", description);
                    var readerAS = cmdAS.ExecuteNonQuery();
                    conAS.Close();

                    //Find the item ID to create a record in the TableOrderItems table.
                    OleDbConnection conASO;
                    OleDbCommand cmdASO;
                    OleDbDataReader readerASO;
                    conASO = new OleDbConnection();
                    conASO.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
                    cmdASO = new OleDbCommand();
                    cmdASO.Connection = conASO;
                    conASO.Open();
                    cmdASO = conASO.CreateCommand();
                    cmdASO.CommandText = @"SELECT ID FROM tableItems WHERE Description = @ds";
                    cmdASO.Parameters.AddWithValue("@ds", description);
                    readerASO = cmdASO.ExecuteReader();
                    while (readerASO.Read())
                    {
                        id = Convert.ToInt32(readerASO[0]);
                    }

                    //Create an object to add the item to the list of items in the order
                    Item item = new Item(id, priceSold, description, "", "","","",0, false,0); 
                    // doesn't matter what values for type, colour, period, maker, 
                    //pricePaid, photographed, priceListed are as not using them for this 
                    //part of the program
                    thisOrder.AddItemSold(item);
                    stringOfItems = item.AddToString(item, stringOfItems);
                    conASO.Close();
                    MessageBox.Show(description+" has been added to the order.");
                    btnAddOrder.Enabled = true;
                    //Now that a sold item has been added, an order can now be added.
                    loadForm();
                }
                else
                {
                    MessageBox.Show("Please enter the price in decimal format.");
                }
                
            }
            else
            {
                MessageBox.Show("Please select an item and enter a price.");
            }
            dgvItem.Update();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text != "")
            // Ensures a customer name has been added so that the order can be attributed to
            //a customer.
            {
                customerName = txtCustomer.Text;
                thisOrder.customer.SetName(customerName);
                thisOrder.Posted = ckbPosted.Checked;
                thisOrder.Paid = ckbPaid.Checked;
                thisOrder.AddOrder();
                btnAddOrder.Enabled = false;
                btnPrintAddressLabel.Enabled = true;
                //Once an order has been added, another order cannot be added until a new 
                //item has been selected from the data grid view.
                thisOrder.ClearItemsSold();
                //Clears the list for the next order
                MessageBox.Show(txtCustomer.Text + "'s order has been added.");
                txtCustomer.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter customer name");
            }
        }
        private void btnPrintAddressLabel_Click(object sender, EventArgs e)
        {
                OleDbConnection conAL;
                OleDbCommand cmdAL;
                OleDbDataReader readerAL;
                conAL = new OleDbConnection();
                conAL.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
                cmdAL = new OleDbCommand();
                cmdAL.Connection = conAL;
                conAL.Open();
                cmdAL = conAL.CreateCommand();
                cmdAL.CommandText = @"SELECT CustomerAddress FROM tableCustomers WHERE CustomerName = @cn";
                cmdAL.Parameters.AddWithValue("@cn", customerName);
                readerAL = cmdAL.ExecuteReader();
                while (readerAL.Read())
                {
                    address = Convert.ToString(readerAL[0]);
                }
                conAL.Close();
            // Delivery slip
            // for each item: description and cost
            string[] splitAddress = address.Split(',');
            using (StreamWriter writer = new StreamWriter("address.txt"))
            {
                foreach (var item in splitAddress)
                {
                    writer.WriteLine(item);
                }
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("Thank you for your purchase.");
                writer.WriteLine("Please find your order enclosed.");
                writer.WriteLine("");
                writer.WriteLine("Order summary:");
                writer.WriteLine(stringOfItems);
                filePath = "address.txt";
            }
            MessageBox.Show("Printing address label");
            new PrintAddress();
            btnPrintAddressLabel.Enabled = false;
            stringOfItems = "";
            customerName = "";
        }
    }
    class SoldItems
    {
        private string DateSold;
        private bool paid;
        private bool posted;
        private int Id;
        public Customer customer;
        public List<Item> SoldItemList = new List<Item>();
        public SoldItems(string dateSold, bool itemPaid, bool itemPosted, Customer cust, int id)
        {
            DateSold = dateSold;
            paid = itemPaid;
            posted = itemPosted;
            Id = id;
            customer = cust;
            SoldItemList = new List<Item>();
        }
        public bool Paid
        {
            get => paid;
            set
            {
                paid = value;
            }
        }
        public bool Posted
        {
            get => posted;
            set
            {
                posted = value;
            }
        }
        public void AddOrder()
        {
            //Find customer
            int id = 0;
            OleDbCommand cmdOC;
            OleDbConnection conOC;
            OleDbDataReader readerOC;
            conOC = new OleDbConnection();
            conOC.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdOC = new OleDbCommand();
            cmdOC.Connection = conOC;
            conOC.Open();
            cmdOC = conOC.CreateCommand();
            cmdOC.CommandText = @"SELECT ID FROM tableCustomers WHERE CustomerName = @cn";
            cmdOC.Parameters.AddWithValue("@cn", customer.GetName());
            readerOC = cmdOC.ExecuteReader();
            if (readerOC.HasRows)
            {
                readerOC.Read();
                id = Convert.ToInt32(readerOC[0]);
                //store the customer ID
                conOC.Close();
            }
            else
            {
                //New customer
                //Get customer address to store in the TableCustomers table
                FormNewCustomer formAddCustomer = new FormNewCustomer(customer);
                formAddCustomer.ShowDialog();
                OleDbCommand cmdONC;
                OleDbConnection conONC;
                OleDbDataReader readerONC;
                conONC = new OleDbConnection();
                conONC.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
                cmdONC = new OleDbCommand();
                cmdONC.Connection = conONC;
                conONC.Open();
                cmdONC = conONC.CreateCommand();
                cmdONC.CommandText = @"SELECT ID FROM tableCustomers WHERE CustomerName = @cn";
                cmdONC.Parameters.AddWithValue("@cn", customer.GetName());
                readerONC = cmdONC.ExecuteReader();
                if (readerONC.HasRows)
                {
                    readerONC.Read();
                    id = Convert.ToInt32(readerONC[0]);
                }
            }

            //Add order details to the orders table.
            OleDbConnection conOO;
            OleDbCommand cmdOO;
            OleDbDataReader readerOO;
            conOO = new OleDbConnection();
            conOO.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdOO = new OleDbCommand();
            cmdOO.Connection = conOO;
            cmdOO = conOO.CreateCommand();
            cmdOO.CommandText = @"INSERT INTO tableOrders (Paid, Posted, DateOrdered, CustomerID) VALUES (@pd, @ps, @do, @ci)";
            cmdOO.Parameters.AddWithValue("@pd", Paid);
            cmdOO.Parameters.AddWithValue("@ps", Posted);
            cmdOO.Parameters.AddWithValue("@do", DateSold);
            cmdOO.Parameters.AddWithValue("@ci", id);
            conOO.Open();
            int Status = cmdOO.ExecuteNonQuery();
            conOO.Close();

            //Get the order ID of the most recent order (which is the order just added)
            cmdOO.CommandText = @"SELECT MAX(ID) FROM tableOrders";
            conOO.Open();
            readerOO = cmdOO.ExecuteReader();
            readerOO.Read();
            Id = Convert.ToInt32(readerOO[0]);
            conOO.Close();

            //Add item IDs and the order ID to the order items table
            OleDbConnection conOI;
            OleDbCommand cmdOI;
            conOI = new OleDbConnection();
            conOI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdOI = new OleDbCommand();
            cmdOI.Connection = conOI;
            foreach (var item in SoldItemList)
            {
                cmdOI.Parameters.Clear();
                cmdOI.CommandText = @"INSERT INTO tableOrderItems (ItemID, OrderID) VALUES (@id, @oi)";
                cmdOI.Parameters.AddWithValue("@id", item.itemId);
                cmdOI.Parameters.AddWithValue("@oi", Id);
                conOI.Open();
                int statusOI = cmdOI.ExecuteNonQuery();
                conOI.Close();
            }
        }
        public void AddItemSold(Item item)
        {
            //Add the item to the current list of items
            SoldItemList.Add(item);
        }
        public void ClearItemsSold()
        {
            SoldItemList.Clear();
        }
    }   
    class Item
    {
        public int itemId;
        private string description;
        private string type;
        private string colour;
        private string period;
        private string maker;
        private decimal pricePaid;
        private decimal priceSold;
        private bool photographed;
        private decimal priceListed;
        public Item(int ItemId, decimal PriceSold, string Description, string Type, string Colour, string Period, string Maker, decimal PricePaid, bool Photographed, decimal PriceListed)
        {
            itemId = ItemId;
            description = Description;
            type = Type;
            colour = Colour;
            period = Period;
            maker = Maker;
            pricePaid = PricePaid;
            priceSold = PriceSold;
            photographed = Photographed;
            priceListed = PriceListed;

        }
        public string AddToString(Item item, string itemString)
        {
            string ItemString = String.Concat(itemString,"\n",item.description,"  £", item.priceSold);
            itemString = ItemString;
            return itemString;
        }
        public void AddNewItem()
        {
            // Method for adding a new item to the database
            OleDbDataReader readerNI;
            OleDbConnection conNI;
            OleDbCommand cmdNI;
            conNI = new OleDbConnection();
            conNI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdNI = new OleDbCommand();
            cmdNI.Connection = conNI;
            cmdNI = conNI.CreateCommand();
            cmdNI.CommandText = @"SELECT * FROM tableItems WHERE (((tableItems.[Description]) = @ds));";
            cmdNI.Parameters.AddWithValue("@ds", description);
            conNI.Open();
            readerNI = cmdNI.ExecuteReader();
            if (readerNI.HasRows)
            {
                MessageBox.Show("There is already an item of that description in the database. Please enter another description");
                //Doesn't allow two items of the same description to the database.
            }
            else
            {
                //Add the item to the database
                OleDbConnection conNIA;
                OleDbCommand cmdNIA;
                OleDbDataReader readerNIA;
                conNIA = new OleDbConnection();
                conNIA.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
                cmdNIA = new OleDbCommand();
                cmdNIA.Connection = conNIA;
                cmdNIA = conNIA.CreateCommand();
                cmdNIA.CommandText = @"INSERT INTO tableItems (Description, ItemType, Colour, Period, Maker, Photographed, PricePaid) VALUES (@ds, @ty, @cl, @pd, @mk, @pg, @pp)";
                cmdNIA.Parameters.AddWithValue("@ds", description);
                cmdNIA.Parameters.AddWithValue("@ty", type);
                cmdNIA.Parameters.AddWithValue("@cl", colour);
                cmdNIA.Parameters.AddWithValue("@pd", period);
                cmdNIA.Parameters.AddWithValue("@mk", maker);
                cmdNIA.Parameters.AddWithValue("@pg", photographed);
                cmdNIA.Parameters.AddWithValue("@pp", pricePaid);
                conNIA.Open();
                readerNIA = cmdNIA.ExecuteReader();
                conNIA.Close();
                MessageBox.Show(description + " has been added to the database");
            }
            conNI.Close();
        }
        public void AddListedItem()
        {
            //Adds a listed item to the database by updating the priceListed and dateListed
            //fields
            OleDbConnection conLI;
            OleDbCommand cmdLI;
            conLI = new OleDbConnection();
            conLI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdLI = new OleDbCommand();
            cmdLI.Connection = conLI;
            conLI.Open();
            cmdLI = conLI.CreateCommand();
            cmdLI.CommandText = @"UPDATE tableItems SET tableItems.DateListed = (Date()), tableItems.PriceListed = @pl, photographed = True WHERE (((tableItems.[Description]) = @ds));";
            cmdLI.Parameters.AddWithValue("@pl", priceListed);
            cmdLI.Parameters.AddWithValue("@ds", description);
            var readerLI = cmdLI.ExecuteNonQuery();
            conLI.Close();
            MessageBox.Show(Convert.ToString(description) + " has been updated");
        }
        public void EditItem(int id)
        {
            //Updates the fields in the database
            OleDbConnection conEI;
            OleDbCommand cmdEI;
            conEI = new OleDbConnection();
            conEI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdEI = new OleDbCommand();
            cmdEI.Connection = conEI;
            conEI.Open();
            cmdEI = conEI.CreateCommand();
            cmdEI.CommandText = @"UPDATE tableItems SET tableItems.Description = @ds, tableItems.Colour = @cl, tableItems.Period = @pd, tableItems.Maker = @mk, tableItems.Photographed = @pg WHERE (((tableItems.[ID]) = @id));";
            cmdEI.Parameters.AddWithValue("@ds", description);
            cmdEI.Parameters.AddWithValue("@cl", colour);
            cmdEI.Parameters.AddWithValue("@pd", period);
            cmdEI.Parameters.AddWithValue("@mk", maker);
            cmdEI.Parameters.AddWithValue("@pg", photographed);
            cmdEI.Parameters.AddWithValue("@id", id);
            var readerEI = cmdEI.ExecuteNonQuery();
            conEI.Close();
            MessageBox.Show(Convert.ToString(description) + " has been updated");
        }
    }
}
