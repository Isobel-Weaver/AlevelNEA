namespace WindowsFormsAppNeaPrototype1
{
    partial class FormAnalyseSales
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
            this.lblMonthSales = new System.Windows.Forms.Label();
            this.btnMonthSales = new System.Windows.Forms.Button();
            this.btnYearComparison = new System.Windows.Forms.Button();
            this.lblMonthLastYear = new System.Windows.Forms.Label();
            this.lblYearQuantity = new System.Windows.Forms.Label();
            this.btnTDLY = new System.Windows.Forms.Button();
            this.lblYearSales = new System.Windows.Forms.Label();
            this.btnYearSales = new System.Windows.Forms.Button();
            this.lblBestTimeSales = new System.Windows.Forms.Label();
            this.lblMonthProfit = new System.Windows.Forms.Label();
            this.lblYearProfit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMonthSales
            // 
            this.lblMonthSales.AutoSize = true;
            this.lblMonthSales.Location = new System.Drawing.Point(12, 9);
            this.lblMonthSales.Name = "lblMonthSales";
            this.lblMonthSales.Size = new System.Drawing.Size(176, 13);
            this.lblMonthSales.TabIndex = 0;
            this.lblMonthSales.Text = "You have sold ___ so far this month";
            // 
            // btnMonthSales
            // 
            this.btnMonthSales.Location = new System.Drawing.Point(12, 25);
            this.btnMonthSales.Name = "btnMonthSales";
            this.btnMonthSales.Size = new System.Drawing.Size(236, 40);
            this.btnMonthSales.TabIndex = 1;
            this.btnMonthSales.Text = "view sales this month";
            this.btnMonthSales.UseVisualStyleBackColor = true;
            this.btnMonthSales.Click += new System.EventHandler(this.btnMonthSales_Click);
            // 
            // btnYearComparison
            // 
            this.btnYearComparison.Location = new System.Drawing.Point(12, 157);
            this.btnYearComparison.Name = "btnYearComparison";
            this.btnYearComparison.Size = new System.Drawing.Size(236, 42);
            this.btnYearComparison.TabIndex = 2;
            this.btnYearComparison.Text = "view sales this month this year and last year";
            this.btnYearComparison.UseVisualStyleBackColor = true;
            this.btnYearComparison.Click += new System.EventHandler(this.btnYearComparison_Click);
            // 
            // lblMonthLastYear
            // 
            this.lblMonthLastYear.AutoSize = true;
            this.lblMonthLastYear.Location = new System.Drawing.Point(12, 141);
            this.lblMonthLastYear.Name = "lblMonthLastYear";
            this.lblMonthLastYear.Size = new System.Drawing.Size(250, 13);
            this.lblMonthLastYear.TabIndex = 3;
            this.lblMonthLastYear.Text = "Sales are (up/down) by ()% from this month last year";
            // 
            // lblYearQuantity
            // 
            this.lblYearQuantity.AutoSize = true;
            this.lblYearQuantity.Location = new System.Drawing.Point(265, 100);
            this.lblYearQuantity.Name = "lblYearQuantity";
            this.lblYearQuantity.Size = new System.Drawing.Size(155, 13);
            this.lblYearQuantity.TabIndex = 4;
            this.lblYearQuantity.Text = "You have sold () in the last year";
            // 
            // btnTDLY
            // 
            this.btnTDLY.Location = new System.Drawing.Point(268, 128);
            this.btnTDLY.Name = "btnTDLY";
            this.btnTDLY.Size = new System.Drawing.Size(152, 39);
            this.btnTDLY.TabIndex = 5;
            this.btnTDLY.Text = "view sales since this day 1 year ago.";
            this.btnTDLY.UseVisualStyleBackColor = true;
            this.btnTDLY.Click += new System.EventHandler(this.btnTDLY_Click);
            // 
            // lblYearSales
            // 
            this.lblYearSales.AutoSize = true;
            this.lblYearSales.Location = new System.Drawing.Point(9, 80);
            this.lblYearSales.Name = "lblYearSales";
            this.lblYearSales.Size = new System.Drawing.Size(158, 13);
            this.lblYearSales.TabIndex = 6;
            this.lblYearSales.Text = "You have sold () so far this year.";
            // 
            // btnYearSales
            // 
            this.btnYearSales.Location = new System.Drawing.Point(12, 100);
            this.btnYearSales.Name = "btnYearSales";
            this.btnYearSales.Size = new System.Drawing.Size(236, 23);
            this.btnYearSales.TabIndex = 7;
            this.btnYearSales.Text = "View sales so far this year";
            this.btnYearSales.UseVisualStyleBackColor = true;
            this.btnYearSales.Click += new System.EventHandler(this.btnYearSales_Click);
            // 
            // lblBestTimeSales
            // 
            this.lblBestTimeSales.AutoSize = true;
            this.lblBestTimeSales.Location = new System.Drawing.Point(265, 9);
            this.lblBestTimeSales.Name = "lblBestTimeSales";
            this.lblBestTimeSales.Size = new System.Drawing.Size(190, 13);
            this.lblBestTimeSales.TabIndex = 8;
            this.lblBestTimeSales.Text = "Your best time for sales is (day) (month)";
            // 
            // lblMonthProfit
            // 
            this.lblMonthProfit.AutoSize = true;
            this.lblMonthProfit.Location = new System.Drawing.Point(265, 39);
            this.lblMonthProfit.Name = "lblMonthProfit";
            this.lblMonthProfit.Size = new System.Drawing.Size(197, 13);
            this.lblMonthProfit.TabIndex = 9;
            this.lblMonthProfit.Text = "You have made () profit in the last month";
            // 
            // lblYearProfit
            // 
            this.lblYearProfit.AutoSize = true;
            this.lblYearProfit.Location = new System.Drawing.Point(265, 71);
            this.lblYearProfit.Name = "lblYearProfit";
            this.lblYearProfit.Size = new System.Drawing.Size(188, 13);
            this.lblYearProfit.TabIndex = 10;
            this.lblYearProfit.Text = "You have made () profit in the last year";
            // 
            // FormAnalyseSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 205);
            this.Controls.Add(this.lblYearProfit);
            this.Controls.Add(this.lblMonthProfit);
            this.Controls.Add(this.lblBestTimeSales);
            this.Controls.Add(this.btnYearSales);
            this.Controls.Add(this.lblYearSales);
            this.Controls.Add(this.btnTDLY);
            this.Controls.Add(this.lblYearQuantity);
            this.Controls.Add(this.lblMonthLastYear);
            this.Controls.Add(this.btnYearComparison);
            this.Controls.Add(this.btnMonthSales);
            this.Controls.Add(this.lblMonthSales);
            this.Name = "FormAnalyseSales";
            this.Text = "FormAnalyseSales";
            this.Load += new System.EventHandler(this.FormAnalyseSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonthSales;
        private System.Windows.Forms.Button btnMonthSales;
        private System.Windows.Forms.Button btnYearComparison;
        private System.Windows.Forms.Label lblMonthLastYear;
        private System.Windows.Forms.Label lblYearQuantity;
        private System.Windows.Forms.Button btnTDLY;
        private System.Windows.Forms.Label lblYearSales;
        private System.Windows.Forms.Button btnYearSales;
        private System.Windows.Forms.Label lblBestTimeSales;
        private System.Windows.Forms.Label lblMonthProfit;
        private System.Windows.Forms.Label lblYearProfit;
    }
}