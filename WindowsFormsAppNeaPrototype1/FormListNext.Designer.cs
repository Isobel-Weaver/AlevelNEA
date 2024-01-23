namespace WindowsFormsAppNeaPrototype1
{
    partial class FormListNext
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
            this.dgvListNext = new System.Windows.Forms.DataGridView();
            this.lblSuggestions = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.lblItems = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblListPrice = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNext)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListNext
            // 
            this.dgvListNext.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListNext.Location = new System.Drawing.Point(12, 30);
            this.dgvListNext.MultiSelect = false;
            this.dgvListNext.Name = "dgvListNext";
            this.dgvListNext.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListNext.Size = new System.Drawing.Size(849, 370);
            this.dgvListNext.TabIndex = 0;
            // 
            // lblSuggestions
            // 
            this.lblSuggestions.AutoSize = true;
            this.lblSuggestions.Location = new System.Drawing.Point(9, 14);
            this.lblSuggestions.Name = "lblSuggestions";
            this.lblSuggestions.Size = new System.Drawing.Size(165, 13);
            this.lblSuggestions.TabIndex = 1;
            this.lblSuggestions.Text = "Suggestions from your items to list";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(177, 405);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "List this item";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(461, 415);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(182, 13);
            this.lblItems.TabIndex = 4;
            this.lblItems.Text = "(Items) are selling well at the moment.";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(314, 408);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // lblListPrice
            // 
            this.lblListPrice.AutoSize = true;
            this.lblListPrice.Location = new System.Drawing.Point(258, 411);
            this.lblListPrice.Name = "lblListPrice";
            this.lblListPrice.Size = new System.Drawing.Size(50, 13);
            this.lblListPrice.TabIndex = 7;
            this.lblListPrice.Text = "List Price";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(12, 405);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(159, 23);
            this.btnViewAll.TabIndex = 8;
            this.btnViewAll.Text = "View all items to list";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // FormListNext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 437);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.lblListPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lblSuggestions);
            this.Controls.Add(this.dgvListNext);
            this.Name = "FormListNext";
            this.Text = "FormListNext";
            this.Load += new System.EventHandler(this.FormListNext_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListNext;
        private System.Windows.Forms.Label lblSuggestions;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblListPrice;
        private System.Windows.Forms.Button btnViewAll;
    }
}