namespace HospitalApp
{
    partial class UCFindPatient
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
            this.lvFind = new System.Windows.Forms.ListView();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPassportNunber = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.scFindPatient = new System.Windows.Forms.SplitContainer();
            this.lbPassportNumber = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lbInn = new System.Windows.Forms.Label();
            this.tbInnNumber = new System.Windows.Forms.TextBox();
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btEdit = new System.Windows.Forms.Button();
            this.chPassportNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scFindPatient)).BeginInit();
            this.scFindPatient.Panel1.SuspendLayout();
            this.scFindPatient.Panel2.SuspendLayout();
            this.scFindPatient.SuspendLayout();
            this.SuspendLayout();
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
            this.lvFind.Location = new System.Drawing.Point(3, 3);
            this.lvFind.Name = "lvFind";
            this.lvFind.Size = new System.Drawing.Size(547, 432);
            this.lvFind.TabIndex = 0;
            this.lvFind.UseCompatibleStateImageBehavior = false;
            this.lvFind.View = System.Windows.Forms.View.Details;
            this.lvFind.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(108, 6);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(185, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(108, 27);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(185, 20);
            this.tbMiddleName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(108, 48);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(185, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // tbPassportNunber
            // 
            this.tbPassportNunber.Location = new System.Drawing.Point(108, 90);
            this.tbPassportNunber.Name = "tbPassportNunber";
            this.tbPassportNunber.Size = new System.Drawing.Size(185, 20);
            this.tbPassportNunber.TabIndex = 4;
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
            this.scFindPatient.Panel1.Controls.Add(this.btFind);
            this.scFindPatient.Panel1.Controls.Add(this.lbInn);
            this.scFindPatient.Panel1.Controls.Add(this.tbInnNumber);
            this.scFindPatient.Panel1.Controls.Add(this.splitter1);
            this.scFindPatient.Panel1.Controls.Add(this.dateTimePicker1);
            this.scFindPatient.Panel1.Controls.Add(this.lbBirthday);
            this.scFindPatient.Panel1.Controls.Add(this.lbPassportNumber);
            this.scFindPatient.Panel1.Controls.Add(this.lbLastName);
            this.scFindPatient.Panel1.Controls.Add(this.lbMiddleName);
            this.scFindPatient.Panel1.Controls.Add(this.tbPassportNunber);
            this.scFindPatient.Panel1.Controls.Add(this.tbFirstName);
            this.scFindPatient.Panel1.Controls.Add(this.tbLastName);
            this.scFindPatient.Panel1.Controls.Add(this.lbFirstName);
            this.scFindPatient.Panel1.Controls.Add(this.tbMiddleName);
            // 
            // scFindPatient.Panel2
            // 
            this.scFindPatient.Panel2.Controls.Add(this.lvFind);
            this.scFindPatient.Size = new System.Drawing.Size(863, 438);
            this.scFindPatient.SplitterDistance = 306;
            this.scFindPatient.TabIndex = 7;
            // 
            // lbPassportNumber
            // 
            this.lbPassportNumber.AutoSize = true;
            this.lbPassportNumber.Location = new System.Drawing.Point(14, 95);
            this.lbPassportNumber.Name = "lbPassportNumber";
            this.lbPassportNumber.Size = new System.Drawing.Size(88, 13);
            this.lbPassportNumber.TabIndex = 8;
            this.lbPassportNumber.Text = "Passport Number";
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
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(711, 448);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(155, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(14, 75);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(49, 13);
            this.lbBirthday.TabIndex = 9;
            this.lbBirthday.Text = "Burthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 438);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // lbInn
            // 
            this.lbInn.AutoSize = true;
            this.lbInn.Location = new System.Drawing.Point(14, 114);
            this.lbInn.Name = "lbInn";
            this.lbInn.Size = new System.Drawing.Size(62, 13);
            this.lbInn.TabIndex = 13;
            this.lbInn.Text = "Inn Number";
            // 
            // tbInnNumber
            // 
            this.tbInnNumber.Location = new System.Drawing.Point(108, 111);
            this.tbInnNumber.Name = "tbInnNumber";
            this.tbInnNumber.Size = new System.Drawing.Size(185, 20);
            this.tbInnNumber.TabIndex = 12;
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
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(550, 447);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(155, 23);
            this.btEdit.TabIndex = 9;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // chPassportNumber
            // 
            this.chPassportNumber.Text = "Passport Number";
            this.chPassportNumber.Width = 98;
            // 
            // chInnNumber
            // 
            this.chInnNumber.Text = "Inn Number";
            this.chInnNumber.Width = 72;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(218, 137);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 14;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            // 
            // UCFindPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.scFindPatient);
            this.Name = "UCFindPatient";
            this.Size = new System.Drawing.Size(869, 483);
            this.scFindPatient.Panel1.ResumeLayout(false);
            this.scFindPatient.Panel1.PerformLayout();
            this.scFindPatient.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scFindPatient)).EndInit();
            this.scFindPatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFind;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbPassportNunber;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.SplitContainer scFindPatient;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbPassportNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chMiddleName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chBirthday;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.Label lbInn;
        private System.Windows.Forms.TextBox tbInnNumber;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.ColumnHeader chPassportNumber;
        private System.Windows.Forms.ColumnHeader chInnNumber;
        private System.Windows.Forms.Button btFind;
    }
}
