namespace HospitalApp.WinFirms
{
    partial class PatientApointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientApointment));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpSignPatientDate = new System.Windows.Forms.DateTimePicker();
            this.lvPatients = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFind = new System.Windows.Forms.Button();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSignUp.Location = new System.Drawing.Point(441, 345);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(97, 30);
            this.btnSignUp.TabIndex = 70;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lvSchedule
            // 
            this.lvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chPatient});
            this.lvSchedule.FullRowSelect = true;
            this.lvSchedule.GridLines = true;
            this.lvSchedule.HideSelection = false;
            this.lvSchedule.Location = new System.Drawing.Point(296, 38);
            this.lvSchedule.MultiSelect = false;
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(242, 296);
            this.lvSchedule.TabIndex = 69;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 44;
            // 
            // chPatient
            // 
            this.chPatient.Text = "Patient";
            this.chPatient.Width = 155;
            // 
            // dtpSignPatientDate
            // 
            this.dtpSignPatientDate.Location = new System.Drawing.Point(296, 12);
            this.dtpSignPatientDate.Name = "dtpSignPatientDate";
            this.dtpSignPatientDate.Size = new System.Drawing.Size(242, 20);
            this.dtpSignPatientDate.TabIndex = 68;
            this.dtpSignPatientDate.Value = new System.DateTime(2016, 9, 11, 0, 0, 0, 0);
            this.dtpSignPatientDate.ValueChanged += new System.EventHandler(this.dtpSignPatientDate_ValueChanged);
            // 
            // lvPatients
            // 
            this.lvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chFirstName,
            this.chLastName,
            this.chMiddleName});
            this.lvPatients.FullRowSelect = true;
            this.lvPatients.GridLines = true;
            this.lvPatients.HideSelection = false;
            this.lvPatients.Location = new System.Drawing.Point(9, 124);
            this.lvPatients.Name = "lvPatients";
            this.lvPatients.Size = new System.Drawing.Size(245, 243);
            this.lvPatients.TabIndex = 67;
            this.lvPatients.UseCompatibleStateImageBehavior = false;
            this.lvPatients.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 27;
            // 
            // chFirstName
            // 
            this.chFirstName.Text = "First name";
            // 
            // chLastName
            // 
            this.chLastName.DisplayIndex = 3;
            this.chLastName.Text = "LastName";
            this.chLastName.Width = 66;
            // 
            // chMiddleName
            // 
            this.chMiddleName.DisplayIndex = 2;
            this.chMiddleName.Text = "Middle Name";
            this.chMiddleName.Width = 76;
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFind.Location = new System.Drawing.Point(143, 95);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(111, 23);
            this.btnFind.TabIndex = 66;
            this.btnFind.Text = "Find patient";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBirthday.Location = new System.Drawing.Point(6, 72);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 65;
            this.lblBirthday.Text = "Birthday";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbLastName.Location = new System.Drawing.Point(6, 50);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 64;
            this.lbLastName.Text = "Last Name";
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMiddleName.Location = new System.Drawing.Point(6, 29);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lbMiddleName.TabIndex = 63;
            this.lbMiddleName.Text = "Middle Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(112, 26);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(142, 20);
            this.tbFirstName.TabIndex = 58;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(112, 47);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(142, 20);
            this.tbLastName.TabIndex = 60;
            this.tbLastName.Tag = "";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbFirstName.Location = new System.Drawing.Point(6, 8);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 62;
            this.lbFirstName.Text = "First Name";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(112, 5);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(142, 20);
            this.tbMiddleName.TabIndex = 59;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(112, 66);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(142, 20);
            this.dtpBirthday.TabIndex = 71;
            this.dtpBirthday.Value = new System.DateTime(2016, 9, 11, 0, 0, 0, 0);
            // 
            // PatientApointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 377);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lvSchedule);
            this.Controls.Add(this.dtpSignPatientDate);
            this.Controls.Add(this.lvPatients);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbMiddleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientApointment";
            this.ShowInTaskbar = false;
            this.Text = "PatientApointment";
            this.Load += new System.EventHandler(this.PatientApointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chPatient;
        private System.Windows.Forms.DateTimePicker dtpSignPatientDate;
        private System.Windows.Forms.ListView lvPatients;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chMiddleName;
    }
}