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
    public partial class FormViewToList : Form
    {
        public FormViewToList()
        {
            InitializeComponent();
        }

        private void FormViewToList_Load(object sender, EventArgs e)
        {
            //Show items that have not yet been listed
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader reader;
            BindingSource bindingSource;
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmd = new OleDbCommand();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = @"SELECT ID, Description, ItemType, Colour, Period, Maker, Photographed, PricePaid FROM tableItems WHERE DateListed IS NULL";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //Display query results in the data grid view
                bindingSource = new BindingSource();
                bindingSource.DataSource = reader;
                dgvViewToList.DataSource = bindingSource;
            }
            con.Close();
        }
    }
}
