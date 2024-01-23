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
    public partial class FormAddNewItem : Form
    {
        public FormAddNewItem()
        {
            InitializeComponent();
            // add items to the combo boxes for each field.

            //Type combobox
            cmbType.Items.Add("Necklace");
            cmbType.Items.Add("Bracelet");
            cmbType.Items.Add("Earrings");
            cmbType.Items.Add("Brooch");
            cmbType.Items.Add("Ring");
            cmbType.Items.Add("Dress Clip");
            cmbType.Items.Add("Compact");

            //Colour combobox
            cmbColour.Items.Add("Blue");
            cmbColour.Items.Add("Pink");
            cmbColour.Items.Add("Yellow");
            cmbColour.Items.Add("Purple");
            cmbColour.Items.Add("Green");
            cmbColour.Items.Add("Orange");
            cmbColour.Items.Add("Red");
            cmbColour.Items.Add("White");
            cmbColour.Items.Add("Black");
            cmbColour.Items.Add("Multicoloured");

            //Period Combobox
            cmbPeriod.Items.Add("Victorian"); 
            cmbPeriod.Items.Add("Art Deco"); 
            cmbPeriod.Items.Add("1940");
            cmbPeriod.Items.Add("1950");
            cmbPeriod.Items.Add("1960");
            cmbPeriod.Items.Add("1980");
        }

        private void btnAddItem_Click(object sender, EventArgs e)
            // Add a new item to the database.
        {
            if (txtItemName.Text != "" && cmbType.Text != "")
                //Only allows an item to be added if a description and a valid price has 
                //been entered. 
            {
                bool success = Decimal.TryParse(txtPricePaid.Text, out decimal pricePaid);
                if (success)
                {
                    // Create an object holding details of the item to add to the database
                    Item newItem = new Item(0, 0, txtItemName.Text, cmbType.Text, cmbColour.Text, cmbPeriod.Text, txtMaker.Text, pricePaid, Convert.ToBoolean(ckbPhotographed.CheckState), 0);
                    newItem.AddNewItem();
                    txtItemName.Text = "";
                    txtMaker.Text = "";
                    txtPricePaid.Text = "";
                    cmbColour.Text = "";
                    cmbPeriod.Text = "";
                    cmbType.Text = "";
                    ckbPhotographed.Checked = false;
                }
                else
                {
                    MessageBox.Show("Please enter the price in decimal format.");
                }
            }
            else
            {
                MessageBox.Show("Item must have description and type");
            }
            

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormAddNewItem_Load(object sender, EventArgs e)
        {

        }
    }
}
