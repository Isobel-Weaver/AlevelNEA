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
    public partial class FormEditItems : Form
    {
        static OleDbConnection conL;
        static OleDbCommand cmdL;
        static OleDbDataReader readerL;
        static BindingSource bindingSourceL;
        static int id;
        public FormEditItems()
        {
            InitializeComponent();
        }

        private void FormEditItems_Load(object sender, EventArgs e)
        {

            LoadEditItems();

        }
        private void LoadEditItems()
        {
            //Method to update the data grid view. Called each time the database is updated.
            conL = new OleDbConnection();
            conL.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdL = new OleDbCommand();
            conL.Open();
            cmdL = conL.CreateCommand();
            cmdL.CommandText = @"SELECT * FROM tableItems";
            readerL = cmdL.ExecuteReader();
            if (readerL.HasRows)
            {
                bindingSourceL = new BindingSource();
                bindingSourceL.DataSource = readerL;
                dgvEditItems.DataSource = bindingSourceL;
            }
            conL.Close();
            txtColour.Text = "";
            txtDescription.Text = "";
            txtMaker.Text = "";
            txtPeriod.Text = "";
            ckbPhotographed.Checked = false;
            btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Enter the current values of the fields into the relevant text boxes so that
            //the fields can be edited. 
            //Store the ID for the item being edited.
            id = Convert.ToInt32(dgvEditItems.SelectedCells[0].Value);
            txtDescription.Text = dgvEditItems.SelectedCells[1].Value.ToString();     
            txtColour.Text = dgvEditItems.SelectedCells[3].Value.ToString();
            txtPeriod.Text = dgvEditItems.SelectedCells[4].Value.ToString();
            txtMaker.Text = dgvEditItems.SelectedCells[5].Value.ToString();
            ckbPhotographed.Checked = Convert.ToBoolean(dgvEditItems.SelectedCells[6].Value);
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Update the database with the new fields
            //Ensure the description text box is not left blank.
            if (txtDescription.Text != "")
            {
                //Ensure the description has not been changed to the description of an item
                //allready in the database.
                OleDbDataReader readerS;
                OleDbConnection conS;
                OleDbCommand cmdS;
                conS = new OleDbConnection();
                conS.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
                cmdS = new OleDbCommand();
                cmdS.Connection = conS;
                cmdS = conS.CreateCommand();
                cmdS.CommandText = @"SELECT * FROM tableItems WHERE (((tableItems.[Description]) = @ds)) AND (((tableItems.[ID]) <> @id));";
                cmdS.Parameters.AddWithValue("@ds", txtDescription.Text);
                cmdS.Parameters.AddWithValue("@id", id);
                conS.Open();
                readerS = cmdS.ExecuteReader();
                if (readerS.HasRows)
                {
                    MessageBox.Show("There is already an item of that description in the database. Please enter another description");
                }
                else
                {
                    Item editItem = new Item(id, 0, txtDescription.Text, "", txtColour.Text,txtPeriod.Text, txtMaker.Text, 0, ckbPhotographed.Checked, 0);
                    //Instantiate a new objects to hold the new details of the item.
                    editItem.EditItem(id);
                    //Call the method to edit the item.
                    LoadEditItems();
                }
                conS.Close();
            }
            else
            {
                MessageBox.Show("Item must have a description");
            }
        }
    }
}
