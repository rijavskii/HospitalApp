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
            this.chBusy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpSignPatientDate = new System.Windows.Forms.DateTimePicker();
            this.lvDoctors = new System.Windows.Forms.ListView();
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDocType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFind = new System.Windows.Forms.Button();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignUp.Enabled = false;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSignUp.Location = new System.Drawing.Point(441, 345);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(97, 30);
            this.btnSignUp.TabIndex = 70;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // lvSchedule
            // 
            this.lvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chBusy,
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
            // chBusy
            // 
            this.chBusy.Text = "Allowed";
            this.chBusy.Width = 74;
            // 
            // chPatient
            // 
            this.chPatient.Text = "Patient";
            this.chPatient.Width = 103;
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
            // lvDoctors
            // 
            this.lvDoctors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFirstName,
            this.chLastName,
            this.chDocType,
            this.chRoom});
            this.lvDoctors.FullRowSelect = true;
            this.lvDoctors.GridLines = true;
            this.lvDoctors.HideSelection = false;
            this.lvDoctors.Location = new System.Drawing.Point(9, 124);
            this.lvDoctors.Name = "lvDoctors";
            this.lvDoctors.Size = new System.Drawing.Size(245, 243);
            this.lvDoctors.TabIndex = 67;
            this.lvDoctors.UseCompatibleStateImageBehavior = false;
            this.lvDoctors.View = System.Windows.Forms.View.Details;
            this.lvDoctors.SelectedIndexChanged += new System.EventHandler(this.lvDoctors_SelectedIndexChanged);
            // 
            // chFirstName
            // 
            this.chFirstName.Text = "First name";
            // 
            // chLastName
            // 
            this.chLastName.Text = "LastName";
            this.chLastName.Width = 61;
            // 
            // chDocType
            // 
            this.chDocType.Text = "Doctor ";
            this.chDocType.Width = 52;
            // 
            // chRoom
            // 
            this.chRoom.Text = "Room";
            this.chRoom.Width = 53;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 71;
            this.dateTimePicker1.Value = new System.DateTime(2016, 9, 11, 0, 0, 0, 0);
            // 
            // PatientApointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 377);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lvSchedule);
            this.Controls.Add(this.dtpSignPatientDate);
            this.Controls.Add(this.lvDoctors);
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
            this.Text = "PatientApointment";
            this.Load += new System.EventHandler(this.PatientApointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chBusy;
        private System.Windows.Forms.ColumnHeader chPatient;
        private System.Windows.Forms.DateTimePicker dtpSignPatientDate;
        private System.Windows.Forms.ListView lvDoctors;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chDocType;
        private System.Windows.Forms.ColumnHeader chRoom;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}