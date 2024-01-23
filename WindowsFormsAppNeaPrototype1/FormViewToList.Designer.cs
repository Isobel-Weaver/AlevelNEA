namespace WindowsFormsAppNeaPrototype1
{
    partial class FormViewToList
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
            this.dgvViewToList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewToList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewToList
            // 
            this.dgvViewToList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewToList.Location = new System.Drawing.Point(12, 21);
            this.dgvViewToList.Name = "dgvViewToList";
            this.dgvViewToList.Size = new System.Drawing.Size(847, 402);
            this.dgvViewToList.TabIndex = 0;
            // 
            // FormViewToList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.dgvViewToList);
            this.Name = "FormViewToList";
            this.Text = "FormViewToList";
            this.Load += new System.EventHandler(this.FormViewToList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewToList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewToList;
    }
}