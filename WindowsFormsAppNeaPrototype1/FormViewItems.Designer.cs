namespace WindowsFormsAppNeaPrototype1
{
    partial class FormViewItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvViewItems = new System.Windows.Forms.DataGridView();
            this.txtFindItem = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.btnAllToList = new System.Windows.Forms.Button();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.lblSearchByColour = new System.Windows.Forms.Label();
            this.btnAllSales = new System.Windows.Forms.Button();
            this.btnAllListed = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblOrder2 = new System.Windows.Forms.Label();
            this.ckbPaid = new System.Windows.Forms.CheckBox();
            this.ckbPosted = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewItems
            // 
            this.dgvViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewItems.Location = new System.Drawing.Point(461, 12);
            this.dgvViewItems.MultiSelect = false;
            this.dgvViewItems.Name = "dgvViewItems";
            this.dgvViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewItems.Size = new System.Drawing.Size(839, 402);
            this.dgvViewItems.TabIndex = 0;
            // 
            // txtFindItem
            // 
            this.txtFindItem.Location = new System.Drawing.Point(25, 114);
            this.txtFindItem.Name = "txtFindItem";
            this.txtFindItem.Size = new System.Drawing.Size(417, 20);
            this.txtFindItem.TabIndex = 1;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(22, 98);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(49, 13);
            this.lblFind.TabIndex = 2;
            this.lblFind.Text = "Find item";
            // 
            // btnAllToList
            // 
            this.btnAllToList.Location = new System.Drawing.Point(25, 12);
            this.btnAllToList.Name = "btnAllToList";
            this.btnAllToList.Size = new System.Drawing.Size(109, 33);
            this.btnAllToList.TabIndex = 3;
            this.btnAllToList.Text = "View all items to list";
            this.btnAllToList.UseVisualStyleBackColor = true;
            this.btnAllToList.Click += new System.EventHandler(this.btnAllToList_Click);
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(86, 185);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(121, 21);
            this.cmbField.TabIndex = 4;
            // 
            // lblSearchByColour
            // 
            this.lblSearchByColour.AutoSize = true;
            this.lblSearchByColour.Location = new System.Drawing.Point(22, 188);
            this.lblSearchByColour.Name = "lblSearchByColour";
            this.lblSearchByColour.Size = new System.Drawing.Size(58, 13);
            this.lblSearchByColour.TabIndex = 5;
            this.lblSearchByColour.Text = "Search by ";
            // 
            // btnAllSales
            // 
            this.btnAllSales.Location = new System.Drawing.Point(140, 12);
            this.btnAllSales.Name = "btnAllSales";
            this.btnAllSales.Size = new System.Drawing.Size(106, 33);
            this.btnAllSales.TabIndex = 12;
            this.btnAllSales.Text = "View All Sales";
            this.btnAllSales.UseVisualStyleBackColor = true;
            this.btnAllSales.Click += new System.EventHandler(this.btnAllSales_Click);
            // 
            // btnAllListed
            // 
            this.btnAllListed.Location = new System.Drawing.Point(252, 12);
            this.btnAllListed.Name = "btnAllListed";
            this.btnAllListed.Size = new System.Drawing.Size(112, 33);
            this.btnAllListed.TabIndex = 13;
            this.btnAllListed.Text = "View All Listed Items";
            this.btnAllListed.UseVisualStyleBackColor = true;
            this.btnAllListed.Click += new System.EventHandler(this.btnAllListed_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(367, 238);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.Location = new System.Drawing.Point(361, 140);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(80, 27);
            this.btnItemSearch.TabIndex = 15;
            this.btnItemSearch.Text = "Search";
            this.btnItemSearch.UseVisualStyleBackColor = true;
            this.btnItemSearch.Click += new System.EventHandler(this.btnItemSearch_Click);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Enabled = false;
            this.btnSearchOrder.Location = new System.Drawing.Point(361, 344);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(94, 20);
            this.btnSearchOrder.TabIndex = 16;
            this.btnSearchOrder.Text = "Find order items";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(12, 323);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(135, 13);
            this.lblOrder.TabIndex = 18;
            this.lblOrder.Text = "Find items ordered together";
            // 
            // lblOrder2
            // 
            this.lblOrder2.AutoSize = true;
            this.lblOrder2.Location = new System.Drawing.Point(12, 351);
            this.lblOrder2.Name = "lblOrder2";
            this.lblOrder2.Size = new System.Drawing.Size(343, 13);
            this.lblOrder2.TabIndex = 19;
            this.lblOrder2.Text = "Select an item from the sold items table to show other items in that order";
            // 
            // ckbPaid
            // 
            this.ckbPaid.AutoSize = true;
            this.ckbPaid.Location = new System.Drawing.Point(25, 393);
            this.ckbPaid.Name = "ckbPaid";
            this.ckbPaid.Size = new System.Drawing.Size(47, 17);
            this.ckbPaid.TabIndex = 20;
            this.ckbPaid.Text = "Paid";
            this.ckbPaid.UseVisualStyleBackColor = true;
            // 
            // ckbPosted
            // 
            this.ckbPosted.AutoSize = true;
            this.ckbPosted.Location = new System.Drawing.Point(78, 393);
            this.ckbPosted.Name = "ckbPosted";
            this.ckbPosted.Size = new System.Drawing.Size(59, 17);
            this.ckbPosted.TabIndex = 21;
            this.ckbPosted.Text = "Posted";
            this.ckbPosted.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(143, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 27);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(25, 212);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(417, 20);
            this.txtValue.TabIndex = 23;
            // 
            // FormViewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 425);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ckbPosted);
            this.Controls.Add(this.ckbPaid);
            this.Controls.Add(this.lblOrder2);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.btnItemSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAllListed);
            this.Controls.Add(this.btnAllSales);
            this.Controls.Add(this.lblSearchByColour);
            this.Controls.Add(this.cmbField);
            this.Controls.Add(this.btnAllToList);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.txtFindItem);
            this.Controls.Add(this.dgvViewItems);
            this.Name = "FormViewItems";
            this.Text = "FormViewItems";
            this.Load += new System.EventHandler(this.FormViewItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewItems;
        private System.Windows.Forms.TextBox txtFindItem;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnAllToList;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.Label lblSearchByColour;
        private System.Windows.Forms.Button btnAllSales;
        private System.Windows.Forms.Button btnAllListed;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnItemSearch;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblOrder2;
        private System.Windows.Forms.CheckBox ckbPaid;
        private System.Windows.Forms.CheckBox ckbPosted;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtValue;
    }
}