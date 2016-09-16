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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpToDoctor));
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
            this.SuspendLayout();
            // 
            // btnFind
            // 
            resources.ApplyResources(this.btnFind, "btnFind");
            this.btnFind.Name = "btnFind";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lbPositionType
            // 
            resources.ApplyResources(this.lbPositionType, "lbPositionType");
            this.lbPositionType.Name = "lbPositionType";
            // 
            // lbLastName
            // 
            resources.ApplyResources(this.lbLastName, "lbLastName");
            this.lbLastName.Name = "lbLastName";
            // 
            // lbMiddleName
            // 
            resources.ApplyResources(this.lbMiddleName, "lbMiddleName");
            this.lbMiddleName.Name = "lbMiddleName";
            // 
            // tbDocType
            // 
            this.tbDocType.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            resources.ApplyResources(this.tbDocType, "tbDocType");
            this.tbDocType.Name = "tbDocType";
            this.tbDocType.TextChanged += new System.EventHandler(this.tbDocType_TextChanged);
            // 
            // tbFirstName
            // 
            resources.ApplyResources(this.tbFirstName, "tbFirstName");
            this.tbFirstName.Name = "tbFirstName";
            // 
            // tbLastName
            // 
            resources.ApplyResources(this.tbLastName, "tbLastName");
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Tag = "";
            // 
            // lbFirstName
            // 
            resources.ApplyResources(this.lbFirstName, "lbFirstName");
            this.lbFirstName.Name = "lbFirstName";
            // 
            // tbMiddleName
            // 
            resources.ApplyResources(this.tbMiddleName, "tbMiddleName");
            this.tbMiddleName.Name = "tbMiddleName";
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
            resources.ApplyResources(this.lvDoctors, "lvDoctors");
            this.lvDoctors.Name = "lvDoctors";
            this.lvDoctors.UseCompatibleStateImageBehavior = false;
            this.lvDoctors.View = System.Windows.Forms.View.Details;
            this.lvDoctors.SelectedIndexChanged += new System.EventHandler(this.lvDoctors_SelectedIndexChanged);
            // 
            // chFirstName
            // 
            resources.ApplyResources(this.chFirstName, "chFirstName");
            // 
            // chLastName
            // 
            resources.ApplyResources(this.chLastName, "chLastName");
            // 
            // chDocType
            // 
            resources.ApplyResources(this.chDocType, "chDocType");
            // 
            // chRoom
            // 
            resources.ApplyResources(this.chRoom, "chRoom");
            // 
            // dtpSignPatientDate
            // 
            resources.ApplyResources(this.dtpSignPatientDate, "dtpSignPatientDate");
            this.dtpSignPatientDate.Name = "dtpSignPatientDate";
            this.dtpSignPatientDate.Value = new System.DateTime(2016, 9, 11, 0, 0, 0, 0);
            this.dtpSignPatientDate.ValueChanged += new System.EventHandler(this.dtpSignPatientDate_ValueChanged);
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
            resources.ApplyResources(this.lvSchedule, "lvSchedule");
            this.lvSchedule.MultiSelect = false;
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            this.lvSchedule.SelectedIndexChanged += new System.EventHandler(this.lvSchedule_SelectedIndexChanged);
            // 
            // chTime
            // 
            resources.ApplyResources(this.chTime, "chTime");
            // 
            // chBusy
            // 
            resources.ApplyResources(this.chBusy, "chBusy");
            // 
            // chPatient
            // 
            resources.ApplyResources(this.chPatient, "chPatient");
            // 
            // btnSignUp
            // 
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnSignUp, "btnSignUp");
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // SignUpToDoctor
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpToDoctor";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.SignInToDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private UCEditPatientInfo ucEditPatientInfo;
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
    }
}