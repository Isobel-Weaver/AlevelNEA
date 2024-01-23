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
    public partial class FormAddAListedItem : Form
    {
        static OleDbConnection conL;
        static OleDbCommand cmdL;
        static OleDbConnection conA;
        static OleDbCommand cmdA;
        public FormAddAListedItem()
        {
            InitializeComponent();
        }
        private void loadForm() 
        //populates the data grid view - called every time the database is edited to ensure
        //the data im the data grid view is up to date. 
        {
            OleDbDataReader readerL;
            BindingSource bindingSourceL;
            conL = new OleDbConnection();
            conL.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdL = new OleDbCommand();
            conL.Open();
            cmdL = conL.CreateCommand();
            cmdL.CommandText = @"SELECT description FROM tableItems WHERE PriceListed IS NULL";
            readerL = cmdL.ExecuteReader();
            if (readerL.HasRows)
            {
                bindingSourceL = new BindingSource();
                bindingSourceL.DataSource = readerL;
                dgvItemName.DataSource = bindingSourceL;
                dgvItemName.Columns[0].Width = 215;
            }
            conL.Close();
            txtPriceListed.Text = "";
        }

        private void formAddAListedItem_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnAddListedItem_Click(object sender, EventArgs e)
        {
            if ((dgvItemName.SelectedCells != null) && (txtPriceListed.Text != ""))
            //Only allows the item to be added if an item is selected in the data grid
            //view and a valid price has been entered.
            {
                bool success = Decimal.TryParse(txtPriceListed.Text, out decimal priceListed);
                if (success)
                {
                    // Check if item has been photographed first as an item cannot be listed
                    //if it has not been photographed.
                    conA = new OleDbConnection();
                    conA.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
                    cmdA = new OleDbCommand();
                    conA.Open();
                    cmdA = conA.CreateCommand();
                    cmdA.CommandText = @"SELECT photographed FROM tableItems WHERE description= @ds";
                    cmdA.Parameters.AddWithValue("@ds", Convert.ToString(dgvItemName.SelectedCells));
                    var readerA = cmdA.ExecuteNonQuery();
                    bool boolReader = Convert.ToBoolean(readerA);
                    if (boolReader == false)
                    {
                        // if photographed is false 
                        DialogResult dialogResult = MessageBox.Show("", "Photographed is" + " false. Mark item as photographed and continue?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //Change photographed and continue
                            Item ListedItem = new Item(0, 0, Convert.ToString(dgvItemName.SelectedCells[0].Value), "", "", "", "", 0, false, priceListed);
                            ListedItem.AddListedItem();
                            loadForm();
                        }
                    }
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
        }
    }
}
