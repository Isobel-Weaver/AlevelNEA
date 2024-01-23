namespace WindowsFormsAppNeaPrototype1
{
    partial class FormViewSalesTDLY
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
            this.dgvTDLY = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDLY)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTDLY
            // 
            this.dgvTDLY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTDLY.Location = new System.Drawing.Point(12, 12);
            this.dgvTDLY.MultiSelect = false;
            this.dgvTDLY.Name = "dgvTDLY";
            this.dgvTDLY.Size = new System.Drawing.Size(768, 405);
            this.dgvTDLY.TabIndex = 0;
            // 
            // FormViewSalesTDLY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.dgvTDLY);
            this.Name = "FormViewSalesTDLY";
            this.Text = "FormViewSalesTDLY";
            this.Load += new System.EventHandler(this.FormViewSalesTDLY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDLY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTDLY;
    }
}