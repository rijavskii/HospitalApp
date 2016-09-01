namespace HospitalApp.UserControls
{
    partial class UcFindWorker
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.btEdit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.btSignInPatient = new System.Windows.Forms.Button();
            this.scFindPatient = new System.Windows.Forms.SplitContainer();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.lvFind = new System.Windows.Forms.ListView();
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPassportNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.scFindPatient)).BeginInit();
            this.scFindPatient.Panel1.SuspendLayout();
            this.scFindPatient.Panel2.SuspendLayout();
            this.scFindPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(636, 454);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(155, 23);
            this.btEdit.TabIndex = 12;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(143, 116);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
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
            // btSignInPatient
            // 
            this.btSignInPatient.Location = new System.Drawing.Point(475, 454);
            this.btSignInPatient.Name = "btSignInPatient";
            this.btSignInPatient.Size = new System.Drawing.Size(155, 23);
            this.btSignInPatient.TabIndex = 11;
            this.btSignInPatient.Text = "Sign in to doctor";
            this.btSignInPatient.UseVisualStyleBackColor = true;
            // 
            // scFindPatient
            // 
            this.scFindPatient.Location = new System.Drawing.Point(8, 10);
            this.scFindPatient.Name = "scFindPatient";
            // 
            // scFindPatient.Panel1
            // 
            this.scFindPatient.Panel1.Controls.Add(this.comboBox1);
            this.scFindPatient.Panel1.Controls.Add(this.label1);
            this.scFindPatient.Panel1.Controls.Add(this.btnFind);
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
            this.scFindPatient.Panel2.Controls.Add(this.lvFind);
            this.scFindPatient.Panel2MinSize = 550;
            this.scFindPatient.Size = new System.Drawing.Size(783, 438);
            this.scFindPatient.SplitterDistance = 229;
            this.scFindPatient.TabIndex = 10;
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
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(108, 6);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(110, 20);
            this.tbFirstName.TabIndex = 1;
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
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(108, 27);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(110, 20);
            this.tbMiddleName.TabIndex = 2;
            // 
            // lvFind
            // 
            this.lvFind.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFirstName,
            this.chMiddleName,
            this.chLastName,
            this.chBirthday,
            this.chAddress,
            this.chPassportNumber,
            this.chInnNumber});
            this.lvFind.FullRowSelect = true;
            this.lvFind.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup1.Tag = "1";
            this.lvFind.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lvFind.Location = new System.Drawing.Point(4, 3);
            this.lvFind.Name = "lvFind";
            this.lvFind.Size = new System.Drawing.Size(543, 432);
            this.lvFind.TabIndex = 0;
            this.lvFind.UseCompatibleStateImageBehavior = false;
            this.lvFind.View = System.Windows.Forms.View.Details;
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
            this.chAddress.Width = 109;
            // 
            // chPassportNumber
            // 
            this.chPassportNumber.Text = "Passport Number";
            this.chPassportNumber.Width = 91;
            // 
            // chInnNumber
            // 
            this.chInnNumber.Text = "INN Number";
            this.chInnNumber.Width = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Position";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // UcCreateWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btSignInPatient);
            this.Controls.Add(this.scFindPatient);
            this.Name = "UcCreateWorker";
            this.Size = new System.Drawing.Size(798, 492);
            this.scFindPatient.Panel1.ResumeLayout(false);
            this.scFindPatient.Panel1.PerformLayout();
            this.scFindPatient.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scFindPatient)).EndInit();
            this.scFindPatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Button btSignInPatient;
        private System.Windows.Forms.SplitContainer scFindPatient;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.ListView lvFind;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chMiddleName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chBirthday;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chPassportNumber;
        private System.Windows.Forms.ColumnHeader chInnNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
