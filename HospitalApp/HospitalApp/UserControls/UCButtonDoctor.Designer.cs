namespace HospitalApp
{
    partial class UCButtonDoctor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btReports = new System.Windows.Forms.Button();
            this.btImportMedicine = new System.Windows.Forms.Button();
            this.btListMedicine = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btDoctors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btReports
            // 
            this.btReports.Location = new System.Drawing.Point(5, 65);
            this.btReports.Name = "btReports";
            this.btReports.Size = new System.Drawing.Size(162, 23);
            this.btReports.TabIndex = 7;
            this.btReports.Text = "Reports";
            this.btReports.UseVisualStyleBackColor = true;
            // 
            // btImportMedicine
            // 
            this.btImportMedicine.Location = new System.Drawing.Point(5, 36);
            this.btImportMedicine.Name = "btImportMedicine";
            this.btImportMedicine.Size = new System.Drawing.Size(162, 23);
            this.btImportMedicine.TabIndex = 6;
            this.btImportMedicine.Text = "Import Medicine";
            this.btImportMedicine.UseVisualStyleBackColor = true;
            // 
            // btListMedicine
            // 
            this.btListMedicine.Location = new System.Drawing.Point(5, 7);
            this.btListMedicine.Name = "btListMedicine";
            this.btListMedicine.Size = new System.Drawing.Size(162, 23);
            this.btListMedicine.TabIndex = 5;
            this.btListMedicine.Text = "List Medicine";
            this.btListMedicine.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(5, 120);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(162, 23);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDoctors
            // 
            this.btDoctors.Location = new System.Drawing.Point(5, 91);
            this.btDoctors.Name = "btDoctors";
            this.btDoctors.Size = new System.Drawing.Size(162, 23);
            this.btDoctors.TabIndex = 9;
            this.btDoctors.Text = "Doctors";
            this.btDoctors.UseVisualStyleBackColor = true;
            // 
            // UCButtonDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDoctors);
            this.Controls.Add(this.btReports);
            this.Controls.Add(this.btImportMedicine);
            this.Controls.Add(this.btListMedicine);
            this.Name = "UCButtonDoctor";
            this.Size = new System.Drawing.Size(173, 234);
            this.Load += new System.EventHandler(this.UCButtonDoctor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReports;
        private System.Windows.Forms.Button btImportMedicine;
        private System.Windows.Forms.Button btListMedicine;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDoctors;
    }
}
