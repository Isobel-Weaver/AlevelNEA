namespace WindowsFormsAppNeaPrototype1
{
    partial class FormViewSales
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
            this.dgvViewSales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewSales
            // 
            this.dgvViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewSales.Location = new System.Drawing.Point(28, 12);
            this.dgvViewSales.MultiSelect = false;
            this.dgvViewSales.Name = "dgvViewSales";
            this.dgvViewSales.Size = new System.Drawing.Size(741, 414);
            this.dgvViewSales.TabIndex = 0;
            // 
            // FormViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvViewSales);
            this.Name = "FormViewSales";
            this.Text = "FormViewSales";
            this.Load += new System.EventHandler(this.FormViewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewSales;
    }
}