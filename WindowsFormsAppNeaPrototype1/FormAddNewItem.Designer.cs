namespace WindowsFormsAppNeaPrototype1
{
    partial class FormAddNewItem
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtPricePaid = new System.Windows.Forms.TextBox();
            this.lblPricePaid = new System.Windows.Forms.Label();
            this.cmbColour = new System.Windows.Forms.ComboBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.txtMaker = new System.Windows.Forms.TextBox();
            this.lblMaker = new System.Windows.Forms.Label();
            this.ckbPhotographed = new System.Windows.Forms.CheckBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(12, 23);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(235, 20);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(9, 7);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(86, 13);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Enter Item Name";
            // 
            // txtPricePaid
            // 
            this.txtPricePaid.Location = new System.Drawing.Point(12, 71);
            this.txtPricePaid.Name = "txtPricePaid";
            this.txtPricePaid.Size = new System.Drawing.Size(235, 20);
            this.txtPricePaid.TabIndex = 2;
            // 
            // lblPricePaid
            // 
            this.lblPricePaid.AutoSize = true;
            this.lblPricePaid.Location = new System.Drawing.Point(9, 55);
            this.lblPricePaid.Name = "lblPricePaid";
            this.lblPricePaid.Size = new System.Drawing.Size(99, 13);
            this.lblPricePaid.TabIndex = 3;
            this.lblPricePaid.Text = "Enter the price paid";
            // 
            // cmbColour
            // 
            this.cmbColour.FormattingEnabled = true;
            this.cmbColour.Location = new System.Drawing.Point(11, 174);
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.Size = new System.Drawing.Size(235, 21);
            this.cmbColour.TabIndex = 4;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(8, 158);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(123, 13);
            this.lblColour.TabIndex = 5;
            this.lblColour.Text = "Select the correct colour";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Location = new System.Drawing.Point(11, 227);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(235, 21);
            this.cmbPeriod.TabIndex = 6;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(8, 211);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(87, 13);
            this.lblPeriod.TabIndex = 7;
            this.lblPeriod.Text = "Select the period";
            // 
            // txtMaker
            // 
            this.txtMaker.Location = new System.Drawing.Point(11, 281);
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(235, 20);
            this.txtMaker.TabIndex = 8;
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Location = new System.Drawing.Point(12, 265);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(131, 13);
            this.lblMaker.TabIndex = 9;
            this.lblMaker.Text = "Enter the maker (if known)";
            // 
            // ckbPhotographed
            // 
            this.ckbPhotographed.AutoSize = true;
            this.ckbPhotographed.Location = new System.Drawing.Point(15, 328);
            this.ckbPhotographed.Name = "ckbPhotographed";
            this.ckbPhotographed.Size = new System.Drawing.Size(93, 17);
            this.ckbPhotographed.TabIndex = 10;
            this.ckbPhotographed.Text = "Photographed";
            this.ckbPhotographed.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(11, 351);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(114, 32);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(11, 122);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(235, 21);
            this.cmbType.TabIndex = 12;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(8, 106);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 13);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Select the item type";
            // 
            // FormAddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 395);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.ckbPhotographed);
            this.Controls.Add(this.lblMaker);
            this.Controls.Add(this.txtMaker);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.cmbColour);
            this.Controls.Add(this.lblPricePaid);
            this.Controls.Add(this.txtPricePaid);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemName);
            this.Name = "FormAddNewItem";
            this.Text = "FormAddNewItem";
            this.Load += new System.EventHandler(this.FormAddNewItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtPricePaid;
        private System.Windows.Forms.Label lblPricePaid;
        private System.Windows.Forms.ComboBox cmbColour;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox txtMaker;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.CheckBox ckbPhotographed;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
    }
}