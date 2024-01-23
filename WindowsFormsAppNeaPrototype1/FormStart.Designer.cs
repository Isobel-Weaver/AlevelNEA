namespace WindowsFormsAppNeaPrototype1
{
    partial class FormStart
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
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnAddListedItem = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnViewItems = new System.Windows.Forms.Button();
            this.btnAnalyseSales = new System.Windows.Forms.Button();
            this.btnListNext = new System.Windows.Forms.Button();
            this.btnEditItems = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(10, 20);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(115, 45);
            this.btnAddNewItem.TabIndex = 0;
            this.btnAddNewItem.Text = "Add a new item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnAddListedItem
            // 
            this.btnAddListedItem.Location = new System.Drawing.Point(10, 71);
            this.btnAddListedItem.Name = "btnAddListedItem";
            this.btnAddListedItem.Size = new System.Drawing.Size(115, 46);
            this.btnAddListedItem.TabIndex = 1;
            this.btnAddListedItem.Text = "Add a listed item";
            this.btnAddListedItem.UseVisualStyleBackColor = true;
            this.btnAddListedItem.Click += new System.EventHandler(this.btnAddListedItem_Click);
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(129, 20);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(115, 45);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Add a sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnViewItems
            // 
            this.btnViewItems.Location = new System.Drawing.Point(129, 71);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(115, 46);
            this.btnViewItems.TabIndex = 3;
            this.btnViewItems.Text = "View items";
            this.btnViewItems.UseVisualStyleBackColor = true;
            this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
            // 
            // btnAnalyseSales
            // 
            this.btnAnalyseSales.Location = new System.Drawing.Point(247, 20);
            this.btnAnalyseSales.Name = "btnAnalyseSales";
            this.btnAnalyseSales.Size = new System.Drawing.Size(115, 45);
            this.btnAnalyseSales.TabIndex = 4;
            this.btnAnalyseSales.Text = "Analyse sales";
            this.btnAnalyseSales.UseVisualStyleBackColor = true;
            this.btnAnalyseSales.Click += new System.EventHandler(this.btnAnalyseSales_Click);
            // 
            // btnListNext
            // 
            this.btnListNext.Location = new System.Drawing.Point(247, 71);
            this.btnListNext.Name = "btnListNext";
            this.btnListNext.Size = new System.Drawing.Size(115, 46);
            this.btnListNext.TabIndex = 5;
            this.btnListNext.Text = "What should I list next?";
            this.btnListNext.UseVisualStyleBackColor = true;
            this.btnListNext.Click += new System.EventHandler(this.btnListNext_Click);
            // 
            // btnEditItems
            // 
            this.btnEditItems.Location = new System.Drawing.Point(187, 123);
            this.btnEditItems.Name = "btnEditItems";
            this.btnEditItems.Size = new System.Drawing.Size(115, 43);
            this.btnEditItems.TabIndex = 6;
            this.btnEditItems.Text = "Edit Items";
            this.btnEditItems.UseVisualStyleBackColor = true;
            this.btnEditItems.Click += new System.EventHandler(this.btnEditItems_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(66, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 44);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete an item or customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 180);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditItems);
            this.Controls.Add(this.btnListNext);
            this.Controls.Add(this.btnAnalyseSales);
            this.Controls.Add(this.btnViewItems);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnAddListedItem);
            this.Controls.Add(this.btnAddNewItem);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnAddListedItem;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.Button btnAnalyseSales;
        private System.Windows.Forms.Button btnListNext;
        private System.Windows.Forms.Button btnEditItems;
        private System.Windows.Forms.Button btnDelete;
    }
}

