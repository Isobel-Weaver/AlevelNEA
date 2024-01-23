using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNeaPrototype1
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            FormAddNewItem formAddNewItem = new FormAddNewItem();
            formAddNewItem.ShowDialog();
        }

        private void btnAddListedItem_Click(object sender, EventArgs e)
        {
            FormAddAListedItem formAddAListedItem = new FormAddAListedItem();
            formAddAListedItem.ShowDialog();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            FormAddSale formAddSale = new FormAddSale();
            formAddSale.ShowDialog();
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            FormViewItems formViewItems = new FormViewItems();
            formViewItems.ShowDialog();
        }

        private void btnAnalyseSales_Click(object sender, EventArgs e)
        {
            FormAnalyseSales formAnalyseSales = new FormAnalyseSales();
            formAnalyseSales.ShowDialog();
        }

        private void btnListNext_Click(object sender, EventArgs e)
        {
            FormListNext formListNext = new FormListNext();
            formListNext.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEditItems_Click(object sender, EventArgs e)
        {
            FormEditItems formEditItems = new FormEditItems();
            formEditItems.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormDelete formDelete = new FormDelete();
            formDelete.ShowDialog();
        }
    }
}

