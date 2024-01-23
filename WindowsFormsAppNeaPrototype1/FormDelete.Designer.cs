namespace WindowsFormsAppNeaPrototype1
{
    partial class FormDelete
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
            this.dgvDelete = new System.Windows.Forms.DataGridView();
            this.btnRemoveListed = new System.Windows.Forms.Button();
            this.btnRemoveSold = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.BtnDeleteOrder = new System.Windows.Forms.Button();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.btnShowItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDelete
            // 
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Location = new System.Drawing.Point(12, 75);
            this.dgvDelete.MultiSelect = false;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelete.Size = new System.Drawing.Size(776, 363);
            this.dgvDelete.TabIndex = 0;
            // 
            // btnRemoveListed
            // 
            this.btnRemoveListed.Location = new System.Drawing.Point(12, 452);
            this.btnRemoveListed.Name = "btnRemoveListed";
            this.btnRemoveListed.Size = new System.Drawing.Size(126, 32);
            this.btnRemoveListed.TabIndex = 1;
            this.btnRemoveListed.Text = "Remove Listed Item";
            this.btnRemoveListed.UseVisualStyleBackColor = true;
            this.btnRemoveListed.Click += new System.EventHandler(this.btnRemoveListed_Click);
            // 
            // btnRemoveSold
            // 
            this.btnRemoveSold.Location = new System.Drawing.Point(173, 452);
            this.btnRemoveSold.Name = "btnRemoveSold";
            this.btnRemoveSold.Size = new System.Drawing.Size(126, 32);
            this.btnRemoveSold.TabIndex = 2;
            this.btnRemoveSold.Text = "Remove Sold Item";
            this.btnRemoveSold.UseVisualStyleBackColor = true;
            this.btnRemoveSold.Click += new System.EventHandler(this.btnRemoveSold_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(339, 452);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(126, 32);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(502, 452);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(126, 32);
            this.btnDeleteCustomer.TabIndex = 4;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // BtnDeleteOrder
            // 
            this.BtnDeleteOrder.Location = new System.Drawing.Point(662, 452);
            this.BtnDeleteOrder.Name = "BtnDeleteOrder";
            this.BtnDeleteOrder.Size = new System.Drawing.Size(126, 32);
            this.BtnDeleteOrder.TabIndex = 5;
            this.BtnDeleteOrder.Text = "Delete Order";
            this.BtnDeleteOrder.UseVisualStyleBackColor = true;
            this.BtnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.Location = new System.Drawing.Point(12, 23);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(100, 27);
            this.btnShowCustomers.TabIndex = 6;
            this.btnShowCustomers.Text = "Show Customers";
            this.btnShowCustomers.UseVisualStyleBackColor = true;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // btnShowItems
            // 
            this.btnShowItems.Location = new System.Drawing.Point(149, 24);
            this.btnShowItems.Name = "btnShowItems";
            this.btnShowItems.Size = new System.Drawing.Size(96, 26);
            this.btnShowItems.TabIndex = 7;
            this.btnShowItems.Text = "Show Items";
            this.btnShowItems.UseVisualStyleBackColor = true;
            this.btnShowItems.Click += new System.EventHandler(this.btnShowItems_Click);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnShowItems);
            this.Controls.Add(this.btnShowCustomers);
            this.Controls.Add(this.BtnDeleteOrder);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnRemoveSold);
            this.Controls.Add(this.btnRemoveListed);
            this.Controls.Add(this.dgvDelete);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.Load += new System.EventHandler(this.FormDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDelete;
        private System.Windows.Forms.Button btnRemoveListed;
        private System.Windows.Forms.Button btnRemoveSold;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button BtnDeleteOrder;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Button btnShowItems;
    }
}