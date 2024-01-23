namespace WindowsFormsAppNeaPrototype1
{
    partial class FormYearComparison
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
            this.dgvLastYear = new System.Windows.Forms.DataGridView();
            this.dgvThisYear = new System.Windows.Forms.DataGridView();
            this.lblLastYear = new System.Windows.Forms.Label();
            this.lblThisYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThisYear)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLastYear
            // 
            this.dgvLastYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLastYear.Location = new System.Drawing.Point(408, 25);
            this.dgvLastYear.MultiSelect = false;
            this.dgvLastYear.Name = "dgvLastYear";
            this.dgvLastYear.Size = new System.Drawing.Size(380, 397);
            this.dgvLastYear.TabIndex = 0;
            // 
            // dgvThisYear
            // 
            this.dgvThisYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThisYear.Location = new System.Drawing.Point(12, 25);
            this.dgvThisYear.MultiSelect = false;
            this.dgvThisYear.Name = "dgvThisYear";
            this.dgvThisYear.Size = new System.Drawing.Size(390, 397);
            this.dgvThisYear.TabIndex = 1;
            // 
            // lblLastYear
            // 
            this.lblLastYear.AutoSize = true;
            this.lblLastYear.Location = new System.Drawing.Point(405, 9);
            this.lblLastYear.Name = "lblLastYear";
            this.lblLastYear.Size = new System.Drawing.Size(81, 13);
            this.lblLastYear.TabIndex = 2;
            this.lblLastYear.Text = "Sales Last Year";
            // 
            // lblThisYear
            // 
            this.lblThisYear.AutoSize = true;
            this.lblThisYear.Location = new System.Drawing.Point(12, 9);
            this.lblThisYear.Name = "lblThisYear";
            this.lblThisYear.Size = new System.Drawing.Size(81, 13);
            this.lblThisYear.TabIndex = 3;
            this.lblThisYear.Text = "Sales This Year";
            // 
            // FormYearComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThisYear);
            this.Controls.Add(this.lblLastYear);
            this.Controls.Add(this.dgvThisYear);
            this.Controls.Add(this.dgvLastYear);
            this.Name = "FormYearComparison";
            this.Text = "FormYearComparison";
            this.Load += new System.EventHandler(this.FormYearComparison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThisYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLastYear;
        private System.Windows.Forms.DataGridView dgvThisYear;
        private System.Windows.Forms.Label lblLastYear;
        private System.Windows.Forms.Label lblThisYear;
    }
}