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
    public partial class FormYearComparison : Form  
    {
        static OleDbConnection conTY;
        static OleDbCommand cmdTY;
        static OleDbDataReader readerTY;
        static BindingSource bindingSourceTY;
        static OleDbConnection conLY;
        static OleDbCommand cmdLY;
        static OleDbDataReader readerLY;
        static BindingSource bindingSourceLY;
        public FormYearComparison()
        {
            InitializeComponent();
        }

        private void FormYearComparison_Load(object sender, EventArgs e)
        {
            //Display the total sales this month in one data grid view and in the same 
            //month one year ago in the other data grid view.
            //Sales in this month this year
            conTY = new OleDbConnection();
            conTY.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdTY = new OleDbCommand();
            conTY.Open();
            cmdTY = conTY.CreateCommand();
            cmdTY.CommandText = @"SELECT * FROM (tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE Month(tableOrders.DateOrdered) = Month(Date()) AND Year(tableOrders.DateOrdered) = Year(Date())";
            readerTY = cmdTY.ExecuteReader();
            if (readerTY.HasRows)
            {
                bindingSourceTY = new BindingSource();
                bindingSourceTY.DataSource = readerTY;
                dgvThisYear.DataSource = bindingSourceTY;
            }
            conTY.Close();
            
            //Sales in this month one year ago
            conLY = new OleDbConnection();
            conLY.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdLY = new OleDbCommand();
            conLY.Open();
            cmdLY = conLY.CreateCommand();
            cmdLY.CommandText = @"SELECT * FROM(tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE Month(tableOrders.DateOrdered) = Month(Date()) AND Year(tableOrders.DateOrdered) = Year(Date())-1";
            readerLY = cmdLY.ExecuteReader();
            if (readerLY.HasRows)
            {
                bindingSourceLY = new BindingSource();
                bindingSourceLY.DataSource = readerLY;
                dgvLastYear.DataSource = bindingSourceLY;
            }
            conLY.Close();
        }
    }
}
