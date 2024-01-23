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
    public partial class FormListNext : Form
    {
        public FormListNext()
        {
            InitializeComponent();
        }
        private void LoadListNext()
        {
             // find most common colour
             OleDbConnection conC;
             OleDbCommand cmdC;
             OleDbDataReader readerC;
             conC = new OleDbConnection();
             conC.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
             cmdC = new OleDbCommand();
             conC.Open();
             cmdC = conC.CreateCommand();
             string colour = "";
             cmdC.CommandText = @"SELECT TOP 1 tableItems.Colour FROM (tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE (((tableItems.PriceSold) Is Not Null) AND ((tableOrders.DateOrdered) Between DateAdd('m', -1, Date()) And (Date()))) GROUP BY tableItems.Colour ORDER BY Count(tableItems.Colour) DESC";
             readerC = cmdC.ExecuteReader();
             if (readerC.HasRows)
             {
                 while (readerC.Read())
                 {
                     colour = readerC[0].ToString();
                 }
             }
             conC.Close();
             // Find most common type
             OleDbConnection conT;
             OleDbCommand cmdT;
             OleDbDataReader readerT;
             conT = new OleDbConnection();
             conT.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
             cmdT = new OleDbCommand();
             conT.Open();
             cmdT = conT.CreateCommand();
             string itemType = "";
             cmdT.CommandText = @"SELECT TOP 1 tableItems.ItemType FROM (tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE (((tableItems.PriceSold) Is Not Null) AND ((tableOrders.DateOrdered) Between DateAdd('m',-1, Date()) And (Date()))) GROUP BY tableItems.ItemType ORDER BY Count(tableItems.ItemType) DESC";
             readerT = cmdT.ExecuteReader();
             if (readerT.HasRows)
             {
                 while (readerT.Read())
                 {
                     itemType = readerT[0].ToString();
                 }
             }
             conT.Close();
             // Find most common period
             OleDbConnection conP;
             OleDbCommand cmdP;
             OleDbDataReader readerP;
             conP = new OleDbConnection();
             conP.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
             cmdP = new OleDbCommand();
             conP.Open();
             cmdP = conP.CreateCommand();
             string period = "";
             cmdP.CommandText = @"SELECT TOP 1 tableItems.Period FROM (tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE (((tableItems.PriceSold) Is Not Null) AND ((tableOrders.DateOrdered) Between DateAdd('m', -1, Date()) And (Date()))) GROUP BY tableItems.Period ORDER BY Count(tableItems.Period) DESC";
             readerP = cmdP.ExecuteReader();
             if (readerP.HasRows)
             {
                 while (readerP.Read())
                 {
                     period = readerP[0].ToString();
                 }
             }
             conP.Close();
             //Find most common maker
             OleDbConnection conM;
             OleDbCommand cmdM;
             OleDbDataReader readerM;
             conM = new OleDbConnection();
             conM.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
             cmdM = new OleDbCommand();
             conM.Open();
             cmdM = conM.CreateCommand();
             string maker = "";
             cmdM.CommandText = @"SELECT TOP 1 tableItems.Maker FROM (tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE (((tableItems.PriceSold) Is Not Null) AND ((tableOrders.DateOrdered) Between DateAdd('m', -1, Date()) And (Date()))) GROUP BY tableItems.Maker ORDER BY Count(tableItems.Maker) DESC";
             readerM = cmdM.ExecuteReader();
             if (readerM.HasRows)
             {
                while (readerM.Read())
                {
                    maker = readerM[0].ToString();
                } 
             }
             conM.Close();
             // Find items in the database that are not currently listed and have these 
             //properties. Order by number of matching properties.
             OleDbConnection conF;
             OleDbCommand cmdF;
             OleDbDataReader readerF;
             BindingSource bindingSourceF;
             conF = new OleDbConnection();
             conF.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
             cmdF = new OleDbCommand();
             conF.Open();
             cmdF = conF.CreateCommand();
             cmdF.CommandText = @"SELECT ID, Description, ItemType, Colour, Period, Maker, Photographed, PricePaid FROM TableItems WHERE (PriceSold IS NULL) AND (PriceListed IS NULL) AND ((((TableItems.[Colour])=[@cl])) OR (((TableItems.[ItemType])=[@ty])) OR (((TableItems.[Period])=[@pr])) OR (((TableItems.[Maker])=[@mk]))) ORDER BY(IIF (TableItems.Colour= @cl, 1, 0) + IIF(TableItems.ItemType = @ty, 1, 0) + IIF(TableItems.Period = @pr, 1, 0) + IIF(TableItems.Maker = @mk, 1, 0)) DESC;";
             cmdF.Parameters.AddWithValue("@cl", colour);
             cmdF.Parameters.AddWithValue("@ty", itemType);
             cmdF.Parameters.AddWithValue("@pr", period);
             cmdF.Parameters.AddWithValue("@mk", maker);
             readerF = cmdF.ExecuteReader();
             if (readerF.HasRows)
             {
                 //Populate data grid view with the relevant items from the database
                 bindingSourceF = new BindingSource();
                 bindingSourceF.DataSource = readerF;
                 dgvListNext.DataSource = bindingSourceF;
             }
             conF.Close();

             //Selling well
             //If there is a value for most common colour and most common period
             if (colour != "" && period != "")
             {
                 lblItems.Text = (colour + " " + period + " pieces are selling well at " +
                    "the moment.");
             }
             //If there is only a most common colour
             else if (colour != "")
             {
                 lblItems.Text = (colour + " pieces are selling well at the moment.");
             }
             //If there is only a most common period
             else if (period != "")
             {
                 lblItems.Text = (period + " pieces are selling well at the moment.");
             }
             //If there is no most common colour or period
             else
             {
                 lblItems.Text = ("Pieces of a variety of colours and periods are selling " +
                    "at the moment.");
             }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //List This Item
            if ((dgvListNext.SelectedCells != null) && (txtPrice.Text != ""))
                //Ensures that an item has been selected
                //Ensures that a price has been entered into the text box
            {
                bool success = Decimal.TryParse(txtPrice.Text, out decimal priceListed);
                if (success)
                {
                    string description = Convert.ToString(dgvListNext.SelectedCells[1].Value);
                    Item ListedItem = new Item(0, 0, description, "", "", "", "", 0, false,
                        priceListed);
                    ListedItem.AddListedItem();
                    txtPrice.Text = "";
                    LoadListNext();
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

        private void FormListNext_Load(object sender, EventArgs e)
        {
            LoadListNext();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            //Create form with data grid view
            FormViewToList formViewToList = new FormViewToList();
            //Display form showing all items to list
            formViewToList.ShowDialog();
        }
    }
}
