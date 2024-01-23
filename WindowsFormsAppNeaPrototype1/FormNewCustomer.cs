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
    public partial class FormNewCustomer : Form
    {
        //Add a new customer to the database

        //Declare variable to store the customer's name
        static Customer newCustomer;
        public FormNewCustomer(Customer customer)
        {
            InitializeComponent();
            //Assign the customer's name input in the previous form to the variable
            newCustomer = customer;
        }

        private void FormNewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustAddress.Text != "")
                //Ensures that there is an address entered
            {
                 newCustomer.SetAddress(txtCustAddress.Text);
                //Instantiates a new customer
                newCustomer.AddCustomer();
                //Calls the method to add the customer to the database
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter the address.");
            }
        }
    }
    public class Customer
    {
        private string name;
        private string address;
        private int id;
        public Customer(string Name, string Address, int Id)
        {
            name = Name;
            address = Address;
            id = Id;
        }
        public void AddCustomer()
        {
            //Add a new customer to the database
            OleDbConnection conA;
            OleDbCommand cmdA;
            conA = new OleDbConnection();
            conA.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdA = new OleDbCommand();
            cmdA.Connection = conA;
            conA.Open();
            cmdA = conA.CreateCommand();
            cmdA.CommandText = @"INSERT INTO tableCustomers (CustomerName, CustomerAddress) VALUES (@cn, @ad)";
            cmdA.Parameters.AddWithValue("@cn", name);
            cmdA.Parameters.AddWithValue("@ds", address);
            var readerA = cmdA.ExecuteNonQuery();
            conA.Close();
            MessageBox.Show(name+" has been added.");
        }
        public void DeleteCustomer()
        {
            //Delete a customer from the database
            OleDbConnection conD;
            OleDbCommand cmdD;
            conD = new OleDbConnection();
            conD.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdD = new OleDbCommand();
            conD.Open();
            cmdD = conD.CreateCommand();
            cmdD.CommandText = @"DELETE FROM tableCustomers WHERE tableCustomers.ID = @id";
            cmdD.Parameters.AddWithValue("@id",id);
            cmdD.ExecuteNonQuery();
            conD.Close();
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string newName)
        {
            name = newName;
        }
        public void SetAddress(string newAddress)
        {
            address = newAddress;
        }
    }
}
