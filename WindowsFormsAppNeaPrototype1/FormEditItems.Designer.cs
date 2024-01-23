namespace WindowsFormsAppNeaPrototype1
{
    partial class FormEditItems
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
            this.dgvEditItems = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtMaker = new System.Windows.Forms.TextBox();
            this.ckbPhotographed = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblMaker = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditItems
            // 
            this.dgvEditItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditItems.Location = new System.Drawing.Point(12, 5);
            this.dgvEditItems.MultiSelect = false;
            this.dgvEditItems.Name = "dgvEditItems";
            this.dgvEditItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditItems.Size = new System.Drawing.Size(480, 441);
            this.dgvEditItems.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(498, 21);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(290, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(498, 61);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(290, 20);
            this.txtColour.TabIndex = 3;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(498, 100);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(290, 20);
            this.txtPeriod.TabIndex = 4;
            // 
            // txtMaker
            // 
            this.txtMaker.Location = new System.Drawing.Point(498, 138);
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(290, 20);
            this.txtMaker.TabIndex = 5;
            // 
            // ckbPhotographed
            // 
            this.ckbPhotographed.AutoSize = true;
            this.ckbPhotographed.Location = new System.Drawing.Point(498, 164);
            this.ckbPhotographed.Name = "ckbPhotographed";
            this.ckbPhotographed.Size = new System.Drawing.Size(93, 17);
            this.ckbPhotographed.TabIndex = 6;
            this.ckbPhotographed.Text = "Photographed";
            this.ckbPhotographed.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(495, 5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(495, 44);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(37, 13);
            this.lblColour.TabIndex = 9;
            this.lblColour.Text = "Colour";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(495, 84);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(37, 13);
            this.lblPeriod.TabIndex = 10;
            this.lblPeriod.Text = "Period";
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Location = new System.Drawing.Point(495, 122);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(37, 13);
            this.lblMaker.TabIndex = 11;
            this.lblMaker.Text = "Maker";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(498, 397);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 29);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(724, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormEditItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblMaker);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.ckbPhotographed);
            this.Controls.Add(this.txtMaker);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dgvEditItems);
            this.Name = "FormEditItems";
            this.Text = "FormEditItems";
            this.Load += new System.EventHandler(this.FormEditItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditItems;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtMaker;
        private System.Windows.Forms.CheckBox ckbPhotographed;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
    }
}