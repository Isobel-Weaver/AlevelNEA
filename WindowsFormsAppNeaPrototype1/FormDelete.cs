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

namespace WindowsFormsAppNeaPrototype1
{
    public partial class FormDelete : Form
    {
        static OleDbConnection conLC;
        static OleDbCommand cmdLC;
        static OleDbDataReader readerLC;
        static BindingSource bindingSourceLC;
        static OleDbConnection conLI;
        static OleDbCommand cmdLI;
        static OleDbDataReader readerLI;
        static BindingSource bindingSourceLI;
        static string dataView = "";
        public FormDelete()
        {
            InitializeComponent();
        }
        private void FormDelete_Load(object sender, EventArgs e)
        {
            
        }
        private void loadCustomers() //Update the customers in the data grid view. Called 
            //each time the customers table is updated.
        {
            conLC = new OleDbConnection();
            conLC.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source " +
                "= NeaAccess.mdb";
            cmdLC = new OleDbCommand();
            conLC.Open();
            cmdLC = conLC.CreateCommand();
            cmdLC.CommandText = @"SELECT * FROM tableCustomers";
            readerLC = cmdLC.ExecuteReader();
            if (readerLC.HasRows)
            {
                bindingSourceLC = new BindingSource();
                bindingSourceLC.DataSource = readerLC;
                dgvDelete.DataSource = bindingSourceLC;
            }
            conLC.Close();
            dataView = "Customers"; /*Used to determine which table the data grid view is
            currently showing, in order to prevent the user trying to edit the customers 
            table when items are displayed in the data grid view. This prevents the user 
            from meaning to edit a customer but editing an item with the same ID by mistake. */
        }
        private void loadItems() //Update the items in the data grid view. Called each time 
            //the items table is updated.
        {
            
            conLI = new OleDbConnection();
            conLI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdLI = new OleDbCommand();
            conLI.Open();
            cmdLI = conLI.CreateCommand();
            cmdLI.CommandText = @"SELECT * FROM tableItems";
            readerLI = cmdLI.ExecuteReader();
            if (readerLI.HasRows)
            {
                bindingSourceLI = new BindingSource();
                bindingSourceLI.DataSource = readerLI;
                dgvDelete.DataSource = bindingSourceLI;
                conLI.Close();
            }
            dataView = "Items";//Used to determine which table the data grid view is 
            //currently showing
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            //Populate the data grid view with records from the tableCustomers table
            loadCustomers();
        }

        private void btnShowItems_Click(object sender, EventArgs e)
        {
            //Populate the data grid view with records from the tableItems table
            loadItems(); 
        }
        private void btnRemoveListed_Click(object sender, EventArgs e)
        {
            //Set the date listed and price listed fields to null for the selected item.
            if (dgvDelete.SelectedCells != null && dataView == "Items")
            { 
                if (dgvDelete.SelectedCells[9].Value.ToString() == "")
                {

                    int id = Convert.ToInt32(dgvDelete.SelectedCells[0].Value);
                    string description = Convert.ToString(dgvDelete.SelectedCells[1].Value);
                    RemoveItem rmvListed = new RemoveItem(id);
                    rmvListed.RemoveListed();
                    MessageBox.Show(description+" is no longer listed.");
                    loadItems(); 
                    //Updates the contents of the data grid view
                }
                else
                {
                    MessageBox.Show("Cannot delete item if it has been sold");
                    // This is so that a sale is not accidentally deleted. The sold field
                    //must be removed before the item can be deleted.
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the items table.");
                // Ensures that an item is selected and it is from the items table and not 
                //the customers table.
            }     
        }
        private void btnRemoveSold_Click(object sender, EventArgs e)
        {
            if (dgvDelete.SelectedCells != null && dataView == "Items")
            {
                //Remove sold item fields
                string description = Convert.ToString(dgvDelete.SelectedCells[1].Value);
                int id = Convert.ToInt32(dgvDelete.SelectedCells[0].Value);
                RemoveItem RmvSold = new RemoveItem(id); 
                RmvSold.RemoveSold();
                MessageBox.Show(description + " is no longer sold.");
                loadItems();
            }
            else
            {
                MessageBox.Show("Please select an item from the items table.");
                // Ensures that an item is selected and it is from the items table and not
                //the customers table.
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            //Delete an item from the database
            if (dgvDelete.SelectedCells != null && dataView == "Items")
                //Ensures that there is an item selected and that it is an item from the 
                //tableItems table.
            {
                if (dgvDelete.SelectedCells[9].Value.ToString() == "") 
                    //Ensures that the price sold field is null
                {
                    int id = Convert.ToInt32(dgvDelete.SelectedCells[0].Value);
                    string description = Convert.ToString(dgvDelete.SelectedCells[1].Value);
                    //instantiate an object holding the item id.
                    RemoveItem deleteItem = new RemoveItem(id);
                    //Call the method to delete the item.
                    deleteItem.DeleteItem();
                    MessageBox.Show(description + " has been deleted");
                    loadItems();
                }
                else
                {
                    MessageBox.Show("Cannot delete item if it has been sold");
                } 
            }
            else
            {
                MessageBox.Show("Please select an item from the items table.");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
            //Delete a customer from the tableCustomers table
        {
            if (dgvDelete.SelectedCells != null && dataView == "Customers")
            {
                int id = Convert.ToInt32(dgvDelete.SelectedCells[0].Value);
                string name = Convert.ToString(dgvDelete.SelectedCells[1].Value);
                //Instantiate a new object to hold the details of the customer 
                Customer deleteCustomer = new Customer("", "", id);
                //Call the method to delete the customer.
                deleteCustomer.DeleteCustomer();
                MessageBox.Show(name + " has been deleted");
                loadCustomers();
            }
            else
            {
                MessageBox.Show("Please select a customer from the customers table.");
            }
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvDelete.SelectedCells != null && dataView == "Items")
            {
                int id = Convert.ToInt32(dgvDelete.SelectedCells[0].Value);
                //instantiate an object holding the item id.
                RemoveItem dltOrder = new RemoveItem(id);
                //Call the method to delete the order.conRL
                dltOrder.DeleteOrder();
                MessageBox.Show("Order " + id + " has been deleted");
                loadItems();
                
            }
            else
            {
                MessageBox.Show("Please select an item from the items table.");
            }
        }
    } 
}
class RemoveItem
{
    public int itemId;
    public RemoveItem(int ItemId)
    {
        itemId = ItemId;
    }
    public void RemoveListed()
    {
        //Set the date listed and price listed fields to null
        OleDbConnection conRL;
        OleDbCommand cmdRL;
        conRL = new OleDbConnection();
        conRL.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdRL = new OleDbCommand();
        conRL.Open();
        cmdRL = conRL.CreateCommand();
        cmdRL.CommandText = @"UPDATE tableItems SET tableItems.DateListed = NULL, tableItems.PriceListed = NULL WHERE tableItems.ID = @id";
        cmdRL.Parameters.AddWithValue("@id", itemId);
        cmdRL.ExecuteNonQuery();
        conRL.Close();
    }
    public void RemoveSold()
    {
        //Set the price sold field to null. Remove the item from the order items table, and
        //delete the order from the orders table if there are no other items in the order.
        OleDbConnection conRSU;
        OleDbCommand cmdRSU;
        OleDbConnection conRSS;
        OleDbCommand cmdRSS;
        OleDbDataReader readerRSS;
        OleDbConnection conRSI;
        OleDbCommand cmdRSI;
        OleDbConnection conRSOI;
        OleDbCommand cmdRSOI;
        OleDbDataReader readerRSOI;
        OleDbConnection conRSO;
        OleDbCommand cmdRSO;
        conRSU = new OleDbConnection();
        conRSU.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdRSU = new OleDbCommand();
        conRSU.Open();
        cmdRSU = conRSU.CreateCommand();
        cmdRSU.CommandText = @"UPDATE tableItems SET tableItems.PriceSold = NULL WHERE tableItems.ID = @id";
        cmdRSU.Parameters.AddWithValue("@id", itemId);
        cmdRSU.ExecuteNonQuery();
        conRSU.Close();
        //Get OrderID
        int orderid = 0;
        conRSS = new OleDbConnection();
        conRSS.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdRSS = new OleDbCommand();
        conRSS.Open();
        cmdRSS = conRSS.CreateCommand();
        cmdRSS.CommandText = @"SELECT OrderID FROM tableOrderItems WHERE tableOrderItems.ItemID = @id";
        cmdRSS.Parameters.AddWithValue("@id", itemId);
        readerRSS = cmdRSS.ExecuteReader();
        if (readerRSS.HasRows)
        {
            readerRSS.Read();
            orderid = Convert.ToInt32(readerRSS[0]);
        }
        conRSS.Close();
        //Delete item from orderitems table
        conRSI = new OleDbConnection();
        conRSI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdRSI = new OleDbCommand();
        conRSI.Open();
        cmdRSI = conRSI.CreateCommand();
        cmdRSI.CommandText = @"DELETE FROM tableOrderItems WHERE tableOrderItems.ItemID = @id";
        cmdRSI.Parameters.AddWithValue("@id", itemId);
        cmdRSI.ExecuteNonQuery();
        conRSI.Close();
        //Find if there are other items in the order
        conRSOI = new OleDbConnection();
        conRSOI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdRSOI = new OleDbCommand();
        conRSOI.Open();
        cmdRSOI = conRSOI.CreateCommand();
        cmdRSOI.CommandText = @"SELECT * FROM tableOrderItems WHERE tableOrderItems.OrderID = @id";
        cmdRSOI.Parameters.AddWithValue("@id", orderid);
        readerRSOI = cmdRSOI.ExecuteReader();
        if (readerRSOI.HasRows)
        {
            //Don't delete order
        }
        else
        {
            conRSO = new OleDbConnection();
            conRSO.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdRSO = new OleDbCommand();
            conRSO.Open();
            cmdRSO = conRSO.CreateCommand();
            cmdRSO.CommandText = @"DELETE FROM tableOrders WHERE tableOrders.ID = @id";
            cmdRSO.Parameters.AddWithValue("@id", orderid);
            cmdRSO.ExecuteNonQuery();
            conRSO.Close();
        }
    }
    public void DeleteItem()
    {
        //Delete the record from the database
        OleDbConnection conDI;
        OleDbCommand cmdDI;
        conDI = new OleDbConnection();
        conDI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdDI = new OleDbCommand();
        conDI.Open();
        cmdDI = conDI.CreateCommand();
        cmdDI.CommandText = @"DELETE FROM tableItems WHERE tableItems.ID = @id";
        cmdDI.Parameters.AddWithValue("@id", itemId);
        cmdDI.ExecuteNonQuery();
        conDI.Close();
    }
    public void DeleteOrder()
    {
        //Delete the order from the orders table. 
        //Delete all items in the order from the order items table. 
        //Remove price sold fields from all items in the order.
        OleDbConnection conDOI;
        OleDbCommand cmdDOI;
        OleDbDataReader readerDOI;
        OleDbConnection conDOO;
        OleDbCommand cmdDOO;
        OleDbDataReader readerDOO;
        OleDbConnection conDODI;
        OleDbCommand cmdDODI;
        OleDbConnection conDOS;
        OleDbCommand cmdDOS;
        OleDbConnection conDODO;
        OleDbCommand cmdDODO;
        //Get OrderID
        int orderid = 0;
        conDOI = new OleDbConnection();
        conDOI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdDOI = new OleDbCommand();
        conDOI.Open();
        cmdDOI = conDOI.CreateCommand();
        cmdDOI.CommandText = @"SELECT OrderID FROM tableOrderItems WHERE tableOrderItems.ItemID = @id";
        cmdDOI.Parameters.AddWithValue("@id", itemId);
        readerDOI = cmdDOI.ExecuteReader();
        if (readerDOI.HasRows)
        {
            readerDOI.Read();
            orderid = Convert.ToInt32(readerDOI[0]);
        }
        conDOI.Close();
        //Find other items in the order
        List<int> listOrderItems = new List<int>();
        conDOO = new OleDbConnection();
        conDOO.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdDOO = new OleDbCommand();
        conDOO.Open();
        cmdDOO = conDOO.CreateCommand();
        cmdDOO.CommandText = @"SELECT ItemID FROM tableOrderItems WHERE tableOrderItems.OrderID = @id";
        cmdDOO.Parameters.AddWithValue("@id", orderid);
        readerDOO = cmdDOO.ExecuteReader();
        if (readerDOO.HasRows)
        {
            while (readerDOO.Read())
            {
                listOrderItems.Add(Convert.ToInt32(readerDOO[0]));
            }
        }
        conDOO.Close();
        //Delete items from orderitems table
        conDODI = new OleDbConnection();
        conDODI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdDODI = new OleDbCommand();
        conDODI.Open();
        cmdDODI = conDODI.CreateCommand();
        cmdDODI.CommandText = @"DELETE FROM tableOrderItems WHERE tableOrderItems.OrderID = @id";
        cmdDODI.Parameters.AddWithValue("@id", orderid);
        cmdDODI.ExecuteNonQuery();
        conDODI.Close();
        //Remove sold item fields
        conDOS = new OleDbConnection();
        conDOS.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdDOS = new OleDbCommand();
        conDOS.Open();
        foreach (int item in listOrderItems)
        {
            cmdDOS = conDOS.CreateCommand();
            cmdDOS.CommandText = @"UPDATE tableItems SET tableItems.PriceSold = NULL WHERE tableItems.ID = @id";
            cmdDOS.Parameters.AddWithValue("@id", item);
            cmdDOS.ExecuteNonQuery();
        }
        conDOS.Close();
        //Delete order
        conDODO = new OleDbConnection();
        conDODO.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
        cmdDODO = new OleDbCommand();
        conDODO.Open();
        cmdDODO = conDODO.CreateCommand();
        cmdDODO.CommandText = @"DELETE FROM tableOrders WHERE tableOrders.ID = @id";
        cmdDODO.Parameters.AddWithValue("@id", orderid);
        cmdDODO.ExecuteNonQuery();
        conDODO.Close();
    }
}
        
