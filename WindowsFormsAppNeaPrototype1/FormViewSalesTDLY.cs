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
    public partial class FormViewSalesTDLY : Form
    {
        static OleDbCommand cmd;
        static OleDbConnection con;
        static BindingSource bindingSource;
        static OleDbDataReader reader;

        public FormViewSalesTDLY()
        {
            InitializeComponent();
        }

        private void FormViewSalesTDLY_Load(object sender, EventArgs e)
        {
            //Display all of the sales in the last year (since this day last year)
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmd = new OleDbCommand();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = @"SELECT * FROM(tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE(((tableItems.PriceSold)Is Not Null) AND((tableOrders.DateOrdered) BETWEEN DateAdd('yyyy', -1, Date()) AND (Date())))";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //Populate the data grid view with the query results.
                bindingSource = new BindingSource();
                bindingSource.DataSource = reader;
                dgvTDLY.DataSource = bindingSource;
            }
            con.Close();
        }
    }
}
