namespace WindowsFormsAppNeaPrototype1
{
    partial class FormAddAListedItem
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
            this.txtPriceListed = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddListedItem = new System.Windows.Forms.Button();
            this.dgvItemName = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemName)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPriceListed
            // 
            this.txtPriceListed.Location = new System.Drawing.Point(12, 241);
            this.txtPriceListed.Name = "txtPriceListed";
            this.txtPriceListed.Size = new System.Drawing.Size(135, 20);
            this.txtPriceListed.TabIndex = 1;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(9, 17);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(88, 13);
            this.lblItemName.TabIndex = 5;
            this.lblItemName.Text = "Select item name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(7, 225);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(85, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Enter price listed";
            // 
            // btnAddListedItem
            // 
            this.btnAddListedItem.Location = new System.Drawing.Point(10, 267);
            this.btnAddListedItem.Name = "btnAddListedItem";
            this.btnAddListedItem.Size = new System.Drawing.Size(67, 24);
            this.btnAddListedItem.TabIndex = 8;
            this.btnAddListedItem.Text = "Add Item";
            this.btnAddListedItem.UseVisualStyleBackColor = true;
            this.btnAddListedItem.Click += new System.EventHandler(this.btnAddListedItem_Click);
            // 
            // dgvItemName
            // 
            this.dgvItemName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemName.Location = new System.Drawing.Point(10, 33);
            this.dgvItemName.MultiSelect = false;
            this.dgvItemName.Name = "dgvItemName";
            this.dgvItemName.Size = new System.Drawing.Size(259, 189);
            this.dgvItemName.TabIndex = 9;
            // 
            // FormAddAListedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 300);
            this.Controls.Add(this.dgvItemName);
            this.Controls.Add(this.btnAddListedItem);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtPriceListed);
            this.Name = "FormAddAListedItem";
            this.Text = "FormAddAListedItem";
            this.Load += new System.EventHandler(this.formAddAListedItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPriceListed;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddListedItem;
        private System.Windows.Forms.DataGridView dgvItemName;
    }
}