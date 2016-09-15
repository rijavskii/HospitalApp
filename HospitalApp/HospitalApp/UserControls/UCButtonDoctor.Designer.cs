namespace HospitalApp
{
    partial class UcButtonDoctor
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
            this.btListMedicine = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btReports
            // 
            this.btReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btReports.Location = new System.Drawing.Point(3, 125);
            this.btReports.Name = "btReports";
            this.btReports.Size = new System.Drawing.Size(180, 55);
            this.btReports.TabIndex = 7;
            this.btReports.Text = "Reports";
            this.btReports.UseVisualStyleBackColor = true;
            // 
            // btListMedicine
            // 
            this.btListMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btListMedicine.Location = new System.Drawing.Point(3, 3);
            this.btListMedicine.Name = "btListMedicine";
            this.btListMedicine.Size = new System.Drawing.Size(180, 55);
            this.btListMedicine.TabIndex = 5;
            this.btListMedicine.Text = "List Medicine";
            this.btListMedicine.UseVisualStyleBackColor = true;
            this.btListMedicine.Click += new System.EventHandler(this.btListMedicine_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSchedule.Location = new System.Drawing.Point(3, 64);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(180, 55);
            this.btnSchedule.TabIndex = 10;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btListMedicine, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btReports, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSchedule, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 247);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // UcButtonDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcButtonDoctor";
            this.Size = new System.Drawing.Size(198, 250);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReports;
        private System.Windows.Forms.Button btListMedicine;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
