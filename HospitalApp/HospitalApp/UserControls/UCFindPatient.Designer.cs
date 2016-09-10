namespace HospitalApp
{
    partial class UcFindPatient
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.lvPatients = new System.Windows.Forms.ListView();
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPassportNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.scFindPatient = new System.Windows.Forms.SplitContainer();
            this.gpPassport = new System.Windows.Forms.GroupBox();
            this.mtbPassportSeries = new System.Windows.Forms.MaskedTextBox();
            this.lbSeries = new System.Windows.Forms.Label();
            this.mtbPassportNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbPassportNumber = new System.Windows.Forms.Label();
            this.mtbInnNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lbInn = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.btnSignUpPatient = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scFindPatient)).BeginInit();
            this.scFindPatient.Panel1.SuspendLayout();
            this.scFindPatient.Panel2.SuspendLayout();
            this.scFindPatient.SuspendLayout();
            this.gpPassport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPatients
            // 
            this.lvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFirstName,
            this.chMiddleName,
            this.chLastName,
            this.chBirthday,
            this.chAddress,
            this.chPassportNumber,
            this.chInnNumber});
            this.lvPatients.FullRowSelect = true;
            this.lvPatients.GridLines = true;
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            listViewGroup2.Tag = "1";
            this.lvPatients.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.lvPatients.HideSelection = false;
            this.lvPatients.Location = new System.Drawing.Point(3, 6);
            this.lvPatients.MultiSelect = false;
            this.lvPatients.Name = "lvPatients";
            this.lvPatients.Size = new System.Drawing.Size(543, 432);
            this.lvPatients.TabIndex = 0;
            this.lvPatients.UseCompatibleStateImageBehavior = false;
            this.lvPatients.View = System.Windows.Forms.View.Details;
            this.lvPatients.SelectedIndexChanged += new System.EventHandler(this.lvPatients_SelectedIndexChanged);
            this.lvPatients.DoubleClick += new System.EventHandler(this.lvFind_DoubleClick);
            // 
            // chFirstName
            // 
            this.chFirstName.Text = "First Name";
            this.chFirstName.Width = 65;
            // 
            // chMiddleName
            // 
            this.chMiddleName.Text = "Middle Name";
            this.chMiddleName.Width = 78;
            // 
            // chLastName
            // 
            this.chLastName.Text = "Last Name";
            this.chLastName.Width = 65;
            // 
            // chBirthday
            // 
            this.chBirthday.Text = "Birthday";
            this.chBirthday.Width = 52;
            // 
            // chAddress
            // 
            this.chAddress.Text = "Address";
            this.chAddress.Width = 111;
            // 
            // chPassportNumber
            // 
            this.chPassportNumber.Text = "Passport Number";
            this.chPassportNumber.Width = 98;
            // 
            // chInnNumber
            // 
            this.chInnNumber.Text = "INN Number";
            this.chInnNumber.Width = 72;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(108, 6);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(110, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(108, 27);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(110, 20);
            this.tbMiddleName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(108, 48);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(110, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(14, 9);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 5;
            this.lbFirstName.Text = "First Name";
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Location = new System.Drawing.Point(14, 30);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lbMiddleName.TabIndex = 6;
            this.lbMiddleName.Text = "Middle Name";
            // 
            // scFindPatient
            // 
            this.scFindPatient.Location = new System.Drawing.Point(3, 3);
            this.scFindPatient.Name = "scFindPatient";
            // 
            // scFindPatient.Panel1
            // 
            this.scFindPatient.Panel1.Controls.Add(this.gpPassport);
            this.scFindPatient.Panel1.Controls.Add(this.mtbInnNumber);
            this.scFindPatient.Panel1.Controls.Add(this.btnFind);
            this.scFindPatient.Panel1.Controls.Add(this.lbInn);
            this.scFindPatient.Panel1.Controls.Add(this.splitter1);
            this.scFindPatient.Panel1.Controls.Add(this.dtpBirthday);
            this.scFindPatient.Panel1.Controls.Add(this.lbBirthday);
            this.scFindPatient.Panel1.Controls.Add(this.lbLastName);
            this.scFindPatient.Panel1.Controls.Add(this.lbMiddleName);
            this.scFindPatient.Panel1.Controls.Add(this.tbFirstName);
            this.scFindPatient.Panel1.Controls.Add(this.tbLastName);
            this.scFindPatient.Panel1.Controls.Add(this.lbFirstName);
            this.scFindPatient.Panel1.Controls.Add(this.tbMiddleName);
            this.scFindPatient.Panel1MinSize = 229;
            // 
            // scFindPatient.Panel2
            // 
            this.scFindPatient.Panel2.Controls.Add(this.lvPatients);
            this.scFindPatient.Panel2MinSize = 550;
            this.scFindPatient.Size = new System.Drawing.Size(783, 438);
            this.scFindPatient.SplitterDistance = 229;
            this.scFindPatient.TabIndex = 7;
            // 
            // gpPassport
            // 
            this.gpPassport.Controls.Add(this.mtbPassportSeries);
            this.gpPassport.Controls.Add(this.lbSeries);
            this.gpPassport.Controls.Add(this.mtbPassportNumber);
            this.gpPassport.Controls.Add(this.lbPassportNumber);
            this.gpPassport.Location = new System.Drawing.Point(13, 95);
            this.gpPassport.Name = "gpPassport";
            this.gpPassport.Size = new System.Drawing.Size(208, 56);
            this.gpPassport.TabIndex = 44;
            this.gpPassport.TabStop = false;
            this.gpPassport.Text = "Passport";
            // 
            // mtbPassportSeries
            // 
            this.mtbPassportSeries.HidePromptOnLeave = true;
            this.mtbPassportSeries.Location = new System.Drawing.Point(46, 19);
            this.mtbPassportSeries.Mask = " L L";
            this.mtbPassportSeries.Name = "mtbPassportSeries";
            this.mtbPassportSeries.Size = new System.Drawing.Size(34, 20);
            this.mtbPassportSeries.TabIndex = 42;
            // 
            // lbSeries
            // 
            this.lbSeries.AutoSize = true;
            this.lbSeries.Location = new System.Drawing.Point(6, 22);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(36, 13);
            this.lbSeries.TabIndex = 39;
            this.lbSeries.Text = "Series";
            // 
            // mtbPassportNumber
            // 
            this.mtbPassportNumber.HidePromptOnLeave = true;
            this.mtbPassportNumber.Location = new System.Drawing.Point(136, 19);
            this.mtbPassportNumber.Mask = " 0 0 0 0 0 0";
            this.mtbPassportNumber.Name = "mtbPassportNumber";
            this.mtbPassportNumber.Size = new System.Drawing.Size(66, 20);
            this.mtbPassportNumber.TabIndex = 41;
            // 
            // lbPassportNumber
            // 
            this.lbPassportNumber.AutoSize = true;
            this.lbPassportNumber.Location = new System.Drawing.Point(86, 22);
            this.lbPassportNumber.Name = "lbPassportNumber";
            this.lbPassportNumber.Size = new System.Drawing.Size(44, 13);
            this.lbPassportNumber.TabIndex = 40;
            this.lbPassportNumber.Text = "Number";
            // 
            // mtbInnNumber
            // 
            this.mtbInnNumber.HidePromptOnLeave = true;
            this.mtbInnNumber.Location = new System.Drawing.Point(108, 157);
            this.mtbInnNumber.Mask = "0000 0000 00";
            this.mtbInnNumber.Name = "mtbInnNumber";
            this.mtbInnNumber.Size = new System.Drawing.Size(110, 20);
            this.mtbInnNumber.TabIndex = 43;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(143, 201);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lbInn
            // 
            this.lbInn.AutoSize = true;
            this.lbInn.Location = new System.Drawing.Point(14, 160);
            this.lbInn.Name = "lbInn";
            this.lbInn.Size = new System.Drawing.Size(66, 13);
            this.lbInn.TabIndex = 13;
            this.lbInn.Text = "INN Number";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 438);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(108, 69);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(110, 20);
            this.dtpBirthday.TabIndex = 4;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(14, 75);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(45, 13);
            this.lbBirthday.TabIndex = 9;
            this.lbBirthday.Text = "Birthday";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(14, 51);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 7;
            this.lbLastName.Text = "Last Name";
            // 
            // btnSignUpPatient
            // 
            this.btnSignUpPatient.Enabled = false;
            this.btnSignUpPatient.Location = new System.Drawing.Point(470, 447);
            this.btnSignUpPatient.Name = "btnSignUpPatient";
            this.btnSignUpPatient.Size = new System.Drawing.Size(155, 23);
            this.btnSignUpPatient.TabIndex = 8;
            this.btnSignUpPatient.Text = "Sign up to doctor";
            this.btnSignUpPatient.UseVisualStyleBackColor = true;
            this.btnSignUpPatient.Click += new System.EventHandler(this.btSignInPatient_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(631, 447);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // UcFindPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSignUpPatient);
            this.Controls.Add(this.scFindPatient);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(800, 483);
            this.Name = "UcFindPatient";
            this.Size = new System.Drawing.Size(800, 500);
            this.scFindPatient.Panel1.ResumeLayout(false);
            this.scFindPatient.Panel1.PerformLayout();
            this.scFindPatient.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scFindPatient)).EndInit();
            this.scFindPatient.ResumeLayout(false);
            this.gpPassport.ResumeLayout(false);
            this.gpPassport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPatients;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.SplitContainer scFindPatient;
        private System.Windows.Forms.Button btnSignUpPatient;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chMiddleName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chBirthday;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.Label lbInn;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader chPassportNumber;
        private System.Windows.Forms.ColumnHeader chInnNumber;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.MaskedTextBox mtbPassportSeries;
        private System.Windows.Forms.MaskedTextBox mtbPassportNumber;
        private System.Windows.Forms.Label lbPassportNumber;
        private System.Windows.Forms.Label lbSeries;
        private System.Windows.Forms.MaskedTextBox mtbInnNumber;
        private System.Windows.Forms.GroupBox gpPassport;
    }
}
