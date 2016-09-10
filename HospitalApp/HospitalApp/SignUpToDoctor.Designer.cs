namespace HospitalApp
{
    partial class SignUpToDoctor
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
            this.btnFind = new System.Windows.Forms.Button();
            this.lbPositionType = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbDocType = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.lvDoctors = new System.Windows.Forms.ListView();
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDocType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpSignPatientDate = new System.Windows.Forms.DateTimePicker();
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBusy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(139, 108);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(111, 23);
            this.btnFind.TabIndex = 53;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lbPositionType
            // 
            this.lbPositionType.AutoSize = true;
            this.lbPositionType.Location = new System.Drawing.Point(14, 85);
            this.lbPositionType.Name = "lbPositionType";
            this.lbPositionType.Size = new System.Drawing.Size(39, 13);
            this.lbPositionType.TabIndex = 41;
            this.lbPositionType.Text = "Doctor";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(14, 63);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 40;
            this.lbLastName.Text = "Last Name";
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Location = new System.Drawing.Point(14, 42);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lbMiddleName.TabIndex = 39;
            this.lbMiddleName.Text = "Middle Name";
            // 
            // tbDocType
            // 
            this.tbDocType.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbDocType.Location = new System.Drawing.Point(108, 82);
            this.tbDocType.Name = "tbDocType";
            this.tbDocType.Size = new System.Drawing.Size(142, 20);
            this.tbDocType.TabIndex = 37;
            this.tbDocType.TextChanged += new System.EventHandler(this.tbDocType_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(108, 18);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(142, 20);
            this.tbFirstName.TabIndex = 34;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(108, 60);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(142, 20);
            this.tbLastName.TabIndex = 36;
            this.tbLastName.Tag = "";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(14, 21);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 38;
            this.lbFirstName.Text = "First Name";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(108, 39);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(142, 20);
            this.tbMiddleName.TabIndex = 35;
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
            this.lvDoctors.Location = new System.Drawing.Point(17, 137);
            this.lvDoctors.Name = "lvDoctors";
            this.lvDoctors.Size = new System.Drawing.Size(233, 243);
            this.lvDoctors.TabIndex = 54;
            this.lvDoctors.UseCompatibleStateImageBehavior = false;
            this.lvDoctors.View = System.Windows.Forms.View.Details;
            // 
            // chFirstName
            // 
            this.chFirstName.Text = "First name";
            // 
            // chLastName
            // 
            this.chLastName.Text = "LastName";
            this.chLastName.Width = 65;
            // 
            // chDocType
            // 
            this.chDocType.Text = "Doctor ";
            this.chDocType.Width = 51;
            // 
            // chRoom
            // 
            this.chRoom.Text = "Room";
            // 
            // dtpSignPatientDate
            // 
            this.dtpSignPatientDate.Location = new System.Drawing.Point(306, 18);
            this.dtpSignPatientDate.Name = "dtpSignPatientDate";
            this.dtpSignPatientDate.Size = new System.Drawing.Size(124, 20);
            this.dtpSignPatientDate.TabIndex = 55;
            this.dtpSignPatientDate.Value = new System.DateTime(2016, 9, 11, 0, 0, 0, 0);
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
            this.lvSchedule.Location = new System.Drawing.Point(305, 49);
            this.lvSchedule.MultiSelect = false;
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(255, 325);
            this.lvSchedule.TabIndex = 56;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 73;
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
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(580, 344);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(97, 30);
            this.btnSignUp.TabIndex = 57;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(457, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 21);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SignUpToDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 392);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lvSchedule);
            this.Controls.Add(this.dtpSignPatientDate);
            this.Controls.Add(this.lvDoctors);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lbPositionType);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.tbDocType);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbMiddleName);
            this.Name = "SignUpToDoctor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign to Doctor";
            this.Load += new System.EventHandler(this.SignInToDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCEditPatientInfo ucEditPatientInfo1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbPositionType;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbDocType;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.ListView lvDoctors;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.DateTimePicker dtpSignPatientDate;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chBusy;
        private System.Windows.Forms.ColumnHeader chPatient;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.ColumnHeader chDocType;
        private System.Windows.Forms.ColumnHeader chRoom;
        private System.Windows.Forms.Button btnSearch;
    }
}