namespace WindowsFormsAppNeaPrototype1
{
    partial class FormAddSale
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
            this.lblItemNme = new System.Windows.Forms.Label();
            this.txtPriceSold = new System.Windows.Forms.TextBox();
            this.lblPriceSold = new System.Windows.Forms.Label();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.btnPrintAddressLabel = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.ckbPaid = new System.Windows.Forms.CheckBox();
            this.ckbPosted = new System.Windows.Forms.CheckBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemNme
            // 
            this.lblItemNme.AutoSize = true;
            this.lblItemNme.Location = new System.Drawing.Point(12, 9);
            this.lblItemNme.Name = "lblItemNme";
            this.lblItemNme.Size = new System.Drawing.Size(88, 13);
            this.lblItemNme.TabIndex = 1;
            this.lblItemNme.Text = "Select item name";
            // 
            // txtPriceSold
            // 
            this.txtPriceSold.Location = new System.Drawing.Point(12, 238);
            this.txtPriceSold.Name = "txtPriceSold";
            this.txtPriceSold.Size = new System.Drawing.Size(140, 20);
            this.txtPriceSold.TabIndex = 2;
            // 
            // lblPriceSold
            // 
            this.lblPriceSold.AutoSize = true;
            this.lblPriceSold.Location = new System.Drawing.Point(9, 222);
            this.lblPriceSold.Name = "lblPriceSold";
            this.lblPriceSold.Size = new System.Drawing.Size(79, 13);
            this.lblPriceSold.TabIndex = 3;
            this.lblPriceSold.Text = "enter price sold";
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(12, 264);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(75, 23);
            this.btnAddSale.TabIndex = 4;
            this.btnAddSale.Text = "Add Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(12, 306);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(259, 20);
            this.txtCustomer.TabIndex = 5;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(9, 290);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(156, 13);
            this.lblEnterName.TabIndex = 6;
            this.lblEnterName.Text = "Enter the customer\'s name here";
            // 
            // btnPrintAddressLabel
            // 
            this.btnPrintAddressLabel.Enabled = false;
            this.btnPrintAddressLabel.Location = new System.Drawing.Point(15, 332);
            this.btnPrintAddressLabel.Name = "btnPrintAddressLabel";
            this.btnPrintAddressLabel.Size = new System.Drawing.Size(106, 46);
            this.btnPrintAddressLabel.TabIndex = 7;
            this.btnPrintAddressLabel.Text = "Print address and post slip";
            this.btnPrintAddressLabel.UseVisualStyleBackColor = true;
            this.btnPrintAddressLabel.Click += new System.EventHandler(this.btnPrintAddressLabel_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Enabled = false;
            this.btnAddOrder.Location = new System.Drawing.Point(196, 349);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 9;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // ckbPaid
            // 
            this.ckbPaid.AutoSize = true;
            this.ckbPaid.Location = new System.Drawing.Point(134, 332);
            this.ckbPaid.Name = "ckbPaid";
            this.ckbPaid.Size = new System.Drawing.Size(47, 17);
            this.ckbPaid.TabIndex = 10;
            this.ckbPaid.Text = "Paid";
            this.ckbPaid.UseVisualStyleBackColor = true;
            // 
            // ckbPosted
            // 
            this.ckbPosted.AutoSize = true;
            this.ckbPosted.Location = new System.Drawing.Point(134, 355);
            this.ckbPosted.Name = "ckbPosted";
            this.ckbPosted.Size = new System.Drawing.Size(59, 17);
            this.ckbPosted.TabIndex = 11;
            this.ckbPosted.Text = "Posted";
            this.ckbPosted.UseVisualStyleBackColor = true;
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(12, 25);
            this.dgvItem.MultiSelect = false;
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(258, 192);
            this.dgvItem.TabIndex = 12;
            // 
            // FormAddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 397);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.ckbPosted);
            this.Controls.Add(this.ckbPaid);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnPrintAddressLabel);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.lblPriceSold);
            this.Controls.Add(this.txtPriceSold);
            this.Controls.Add(this.lblItemNme);
            this.Name = "FormAddSale";
            this.Text = "FormAddSale";
            this.Load += new System.EventHandler(this.formAddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblItemNme;
        private System.Windows.Forms.TextBox txtPriceSold;
        private System.Windows.Forms.Label lblPriceSold;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Button btnPrintAddressLabel;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.CheckBox ckbPaid;
        private System.Windows.Forms.CheckBox ckbPosted;
        private System.Windows.Forms.DataGridView dgvItem;
    }
}