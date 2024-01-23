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
    public partial class FormViewItems : Form
    {
        static OleDbConnection conAT;
        static OleDbCommand cmdAT;
        static OleDbDataReader readerAT;
        static BindingSource bindingSourceAT;
        static OleDbConnection conAS;
        static OleDbCommand cmdAS;
        static OleDbDataReader readerAS;
        static BindingSource bindingSourceAS;
        static OleDbConnection conAL;
        static OleDbCommand cmdAL;
        static OleDbDataReader readerAL;
        static BindingSource bindingSourceAL;
        static OleDbConnection conIS;
        static OleDbCommand cmdIS;
        static OleDbDataReader readerIS;
        static BindingSource bindingSourceIS;
        static OleDbConnection conSO;
        static OleDbCommand cmdSO;
        static OleDbDataReader readerSO;
        static OleDbConnection conSOI;
        static OleDbCommand cmdSOI;
        static OleDbDataReader readerSOI;
        static BindingSource bindingSourceSOI;
        static OleDbConnection conS;
        static OleDbCommand cmdS;
        static OleDbDataReader readerS;
        static BindingSource bindingSourceS;
        static int id = 0;
        public FormViewItems()
        {
            InitializeComponent();
            //Add search by field options to the combo box
            cmbField.Items.Add("Colour");
            cmbField.Items.Add("Item Type");
            cmbField.Items.Add("Period");
            cmbField.Items.Add("Maker");
        }

        private void FormViewItems_Load(object sender, EventArgs e)
        {

        }

        private void btnAllToList_Click(object sender, EventArgs e)
        {
            //Show all of the items that have not yet been listed
            conAT = new OleDbConnection();
            conAT.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdAT = new OleDbCommand();
            conAT.Open();
            cmdAT = conAT.CreateCommand();
            cmdAT.CommandText = @"SELECT ID, Description, ItemType, Colour, Period, Maker, Photographed, PricePaid FROM tableItems WHERE DateListed IS NULL";
            readerAT = cmdAT.ExecuteReader();
            if (readerAT.HasRows)
            {
                bindingSourceAT = new BindingSource();
                bindingSourceAT.DataSource = readerAT;
                dgvViewItems.DataSource = bindingSourceAT;
            }
            else
            {
                //Clear the data grid view of any fields from a previous query
                dgvViewItems.Rows.Clear();
                dgvViewItems.Refresh();
            }
            conAT.Close();
            btnSearchOrder.Enabled = false;
            //Indicates that the data grid view is not showing items that have sold
            btnSave.Enabled = false;
            //Disables the save button each time the contents of the data grid view is 
            //changed, so that it can only be used when the data grid view is showing the 
            //contents of an order.
        }

        private void btnAllSales_Click(object sender, EventArgs e)
        {
            //Show all items that have sold
            conAS = new OleDbConnection();
            conAS.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdAS = new OleDbCommand();
            conAS.Open();
            cmdAS = conAS.CreateCommand();
            cmdAS.CommandText = @"SELECT * FROM tableItems WHERE PriceSold IS NOT NULL";
            readerAS = cmdAS.ExecuteReader();
            if (readerAS.HasRows)
            {
                bindingSourceAS = new BindingSource();
                bindingSourceAS.DataSource = readerAS;
                dgvViewItems.DataSource = bindingSourceAS;
            }
            else
            {
                dgvViewItems.Rows.Clear();
                dgvViewItems.Refresh();
            }
            conAS.Close();
            btnSearchOrder.Enabled = true;
            //Indicates that the data grid view is showing items that have sold
            btnSave.Enabled = false;
        }

        private void btnAllListed_Click(object sender, EventArgs e)
        {
            //Show items that have been listed, but have not yet sold
            conAL = new OleDbConnection();
            conAL.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdAL = new OleDbCommand();
            conAL.Open();
            cmdAL = conAL.CreateCommand();
            cmdAL.CommandText = @"SELECT ID, Description, ItemType, Colour, Period, Maker, Photographed, PricePaid, PriceListed, DateListed FROM tableItems WHERE DateListed IS NOT NULL AND PriceSold IS NULL";
            readerAL = cmdAL.ExecuteReader();
            if (readerAL.HasRows)
            {
                bindingSourceAL = new BindingSource();
                bindingSourceAL.DataSource = readerAL;
                dgvViewItems.DataSource = bindingSourceAL;
            }
            else
            {
                dgvViewItems.Rows.Clear();
                dgvViewItems.Refresh();
            }
            conAL.Close();
            btnSearchOrder.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        //Search for an item based on a field     
        {
            conS = new OleDbConnection();
            conS.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdS = new OleDbCommand();
            conS.Open();
            cmdS = conS.CreateCommand();
            string field = cmbField.Text;
            switch (field)
            {
                case ("Colour"):
                    //Search for items of the colour entered into the text box
                    cmdS.CommandText = @"SELECT ID, Description, ItemType, Colour, Period, Maker, Photographed, PricePaid, PriceListed, DateListed FROM tableItems WHERE Colour = @vl";
                    cmdS.Parameters.AddWithValue("@vl", txtValue.Text);
                    readerS = cmdS.ExecuteReader();
                    if (readerS.HasRows)
                    {
                        bindingSourceS = new BindingSource();
                        bindingSourceS.DataSource = readerS;
                        dgvViewItems.DataSource = bindingSourceS;
                    }
                    else
                    {
                        dgvViewItems.Rows.Clear();
                        dgvViewItems.Refresh();
                    }
                    conS.Close();
                    break;
                case ("Item Type"):
                    //Seach for items of the type entered into the text box
                    cmdS.CommandText = @"SELECT ID, Description, ItemType, Colour, Period, Maker, Photographed, PricePaid, PriceListed, DateListed FROM tableItems WHERE ItemType = @vl";
                    cmdS.Parameters.AddWithValue("@vl", txtValue.Text);
                    readerS = cmdS.ExecuteReader();
                    if (readerS.HasRows)
                    {
                        bindingSourceS = new BindingSource();
                        bindingSourceS.DataSource = readerS;
                        dgvViewItems.DataSource = bindingSourceS;
                    }
                    else
                    {
                        dgvViewItems.Rows.Clear();
                        dgvViewItems.Refresh();
                    }
                    conS.Close();
                    break;
                case ("Period"):
                    //Search for items from the period entered into the text box
                    cmdS.CommandText = @"SELECT ID, Description, ItemType, Colour, Period, Maker, Photographed, PricePaid, PriceListed, DateListed FROM tableItems WHERE Period = @vl";
                    cmdS.Parameters.AddWithValue("@vl", txtValue.Text);
                    readerS = cmdS.ExecuteReader();
                    if (readerS.HasRows)
                    {
                        bindingSourceS = new BindingSource();
                        bindingSourceS.DataSource = readerS;
                        dgvViewItems.DataSource = bindingSourceS;
                    }
                    else
                    {
                        dgvViewItems.Rows.Clear();
                        dgvViewItems.Refresh();
                    }
                    conS.Close();
                    break;
                case ("Maker"):
                    //Search for items by the maker entered into the text box
                    cmdS.CommandText = @"SELECT ID, Description, ItemType, Colour, Period, Maker, Photographed, PricePaid, PriceListed, DateListed FROM tableItems WHERE Maker = @vl";
                    cmdS.Parameters.AddWithValue("@vl", txtValue.Text);
                    readerS = cmdS.ExecuteReader();
                    if (readerS.HasRows)
                    {
                        bindingSourceS = new BindingSource();
                        bindingSourceS.DataSource = readerS;
                        dgvViewItems.DataSource = bindingSourceS;
                    }
                    else
                    {
                        dgvViewItems.Rows.Clear();
                        dgvViewItems.Refresh();
                    }
                    conS.Close();
                    break;
                default:
                    MessageBox.Show("Please Select a field");
                    //If there is no field present in the combo box, or the user has entered
                    //an invalid field
                    break;
            }

        }

        private void btnItemSearch_Click(object sender, EventArgs e)
        {
            //Search for a specific item by entering part of the description
            conIS = new OleDbConnection();
            conIS.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdIS = new OleDbCommand();
            conIS.Open();
            cmdIS = conIS.CreateCommand();
            cmdIS.CommandText = @"SELECT * FROM tableItems WHERE(((tableItems.Description)Like @ds));";
            cmdIS.Parameters.AddWithValue("@ds", "%" + txtFindItem.Text + "%");
            readerIS = cmdIS.ExecuteReader();
            if (readerIS.HasRows)
            {
                bindingSourceIS = new BindingSource();
                bindingSourceIS.DataSource = readerIS;
                dgvViewItems.DataSource = bindingSourceIS;
            }
            else
            {
                dgvViewItems.Rows.Clear();
                dgvViewItems.Refresh();
            }
            conIS.Close();
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            //Finds all the items in the same order as the selected sold item
            //Ensures that the item has been sold before trying to find the relevant order.
            {
                //Find and store the order ID.
                conSO = new OleDbConnection();
                conSO.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
                cmdSO = new OleDbCommand();
                conSO.Open();
                cmdSO = conSO.CreateCommand();
                cmdSO.CommandText = @"SELECT OrderID FROM tableOrderItems INNER JOIN tableItems ON tableItems.ID = tableOrderItems.ItemID WHERE tableItems.Description = @de";
                cmdSO.Parameters.AddWithValue("@de", dgvViewItems.SelectedCells[1].Value.ToString());
                readerSO = cmdSO.ExecuteReader();
                if (readerSO.HasRows)
                {
                    readerSO.Read();
                    id = Convert.ToInt32(readerSO[0]);
                }
                conSO.Close();

                //Find all items with that order ID.
                conSOI = new OleDbConnection();
                conSOI.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
                cmdSOI = new OleDbCommand();
                conSOI.Open();
                cmdSOI = conSOI.CreateCommand();
                cmdSOI.CommandText = @"SELECT tableItems.Description FROM tableItems INNER JOIN tableOrderItems ON tableOrderItems.ItemID = tableItems.ID WHERE tableOrderItems.OrderID = @oi";
                cmdSOI.Parameters.AddWithValue("@oi", id);
                readerSOI = cmdSOI.ExecuteReader();
                if (readerSOI.HasRows)
                {
                    //Populate the data grid view with all of the items in the order.
                    bindingSourceSOI = new BindingSource();
                    bindingSourceSOI.DataSource = readerSOI;
                    dgvViewItems.DataSource = bindingSourceSOI;
                    btnSave.Enabled = true;
                }
                else
                {
                    //Clear the data grid view of the results of any previous query.
                    dgvViewItems.Rows.Clear();
                    dgvViewItems.Refresh();
                }
                conSOI.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        //Update the database with the new values for paid and posted
        {
            //Instantiate a new SoldItems to store the new values and the item ID
            EditPaidPosted saveSoldItems = new EditPaidPosted(id, ckbPaid.Checked, ckbPosted.Checked);
            //Call the method to update the database
            saveSoldItems.UpdatePaidPosted();
            btnSearchOrder.Enabled = false;  //Soldtrue is still true when view order items 
            //is selected after it.
        }
    }
    class EditPaidPosted
    {
        private int id;
        private bool paid;
        private bool posted;
        public EditPaidPosted(int Id, bool Paid, bool Posted)
        {
            id = Id;
            paid = Paid;
            posted = Posted;

        }
        public void UpdatePaidPosted()
        {
            OleDbConnection conUP;
            OleDbCommand cmdUP;
            OleDbDataReader readerUP;
            conUP = new OleDbConnection();
            conUP.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdUP = new OleDbCommand();
            conUP.Open();
            cmdUP = conUP.CreateCommand();
            cmdUP.CommandText = @"UPDATE tableOrders SET tableOrders.Paid = @pd, tableOrders.Posted = @ps WHERE(((tableOrders.[ID]) = @id))";
            cmdUP.Parameters.AddWithValue("@pd", paid);
            cmdUP.Parameters.AddWithValue("@ps", posted);
            cmdUP.Parameters.AddWithValue("@id", id);
            readerUP = cmdUP.ExecuteReader();
            conUP.Close();
            MessageBox.Show("Order " + Convert.ToString(id) + " has been updated");
        }
    }
}
