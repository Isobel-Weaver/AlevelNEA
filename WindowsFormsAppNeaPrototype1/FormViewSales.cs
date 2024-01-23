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
    public partial class FormViewSales : Form
    {
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;
        static BindingSource bindingSource;
        public FormViewSales(string monthYear)
        {
            InitializeComponent();
            // View sales in the last month or in the last year
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmd = new OleDbCommand();
            con.Open();
            cmd = con.CreateCommand();
            // Command dependant on whether the data grid view is to show sales in the 
            //last month or in the last year.
            if (monthYear == "MONTH")
            {
                // Find the sales in the last month
                cmd.CommandText = @"SELECT * FROM (tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID  WHERE Month(tableOrders.DateOrdered) = Month(Date()) AND Year(tableOrders.DateOrdered) = Year(Date())";
            }
            else if (monthYear == "YEAR")
            {
                // Find the sales in the last year
                cmd.CommandText = @"SELECT * FROM (tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID  WHERE Year(tableOrders.DateOrdered)= Year(Date())";
            }
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //Populate the data grid view with results of the query
                bindingSource = new BindingSource();
                bindingSource.DataSource = reader;
                dgvViewSales.DataSource = bindingSource;
            }
        }

        private void FormViewSales_Load(object sender, EventArgs e)
        {
            con.Close();
        }
    }
}
