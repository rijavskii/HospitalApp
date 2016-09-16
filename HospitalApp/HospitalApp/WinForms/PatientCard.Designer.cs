namespace HospitalApp
{
    partial class PatientCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientCard));
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.mtbInnNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbBannedDrugs = new System.Windows.Forms.Label();
            this.tbBannedDrugs = new System.Windows.Forms.TextBox();
            this.lbDisease = new System.Windows.Forms.Label();
            this.clbDisease = new System.Windows.Forms.CheckedListBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbInnNumber = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbBirhday = new System.Windows.Forms.Label();
            this.lbPassportNumber = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassport
            // 
            this.tbPassport.Enabled = false;
            this.tbPassport.Location = new System.Drawing.Point(119, 100);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(128, 20);
            this.tbPassport.TabIndex = 60;
            // 
            // mtbInnNumber
            // 
            this.mtbInnNumber.Enabled = false;
            this.mtbInnNumber.HidePromptOnLeave = true;
            this.mtbInnNumber.Location = new System.Drawing.Point(119, 121);
            this.mtbInnNumber.Mask = "0000 0000 00";
            this.mtbInnNumber.Name = "mtbInnNumber";
            this.mtbInnNumber.Size = new System.Drawing.Size(100, 20);
            this.mtbInnNumber.TabIndex = 59;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(481, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 23);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbBannedDrugs
            // 
            this.lbBannedDrugs.AutoSize = true;
            this.lbBannedDrugs.Location = new System.Drawing.Point(25, 262);
            this.lbBannedDrugs.Name = "lbBannedDrugs";
            this.lbBannedDrugs.Size = new System.Drawing.Size(75, 13);
            this.lbBannedDrugs.TabIndex = 57;
            this.lbBannedDrugs.Text = "Banned Drugs";
            // 
            // tbBannedDrugs
            // 
            this.tbBannedDrugs.Enabled = false;
            this.tbBannedDrugs.Location = new System.Drawing.Point(119, 259);
            this.tbBannedDrugs.Name = "tbBannedDrugs";
            this.tbBannedDrugs.Size = new System.Drawing.Size(473, 20);
            this.tbBannedDrugs.TabIndex = 56;
            // 
            // lbDisease
            // 
            this.lbDisease.AutoSize = true;
            this.lbDisease.Location = new System.Drawing.Point(25, 164);
            this.lbDisease.Name = "lbDisease";
            this.lbDisease.Size = new System.Drawing.Size(45, 13);
            this.lbDisease.TabIndex = 55;
            this.lbDisease.Text = "Disease";
            // 
            // clbDisease
            // 
            this.clbDisease.Enabled = false;
            this.clbDisease.FormattingEnabled = true;
            this.clbDisease.Location = new System.Drawing.Point(119, 164);
            this.clbDisease.Name = "clbDisease";
            this.clbDisease.Size = new System.Drawing.Size(473, 94);
            this.clbDisease.TabIndex = 54;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(25, 145);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 53;
            this.lbAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Location = new System.Drawing.Point(119, 142);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(473, 20);
            this.tbAddress.TabIndex = 52;
            // 
            // lbInnNumber
            // 
            this.lbInnNumber.AutoSize = true;
            this.lbInnNumber.Location = new System.Drawing.Point(25, 124);
            this.lbInnNumber.Name = "lbInnNumber";
            this.lbInnNumber.Size = new System.Drawing.Size(66, 13);
            this.lbInnNumber.TabIndex = 50;
            this.lbInnNumber.Text = "INN Number";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Enabled = false;
            this.dtpBirthday.Location = new System.Drawing.Point(119, 79);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(473, 20);
            this.dtpBirthday.TabIndex = 49;
            // 
            // lbBirhday
            // 
            this.lbBirhday.AutoSize = true;
            this.lbBirhday.Location = new System.Drawing.Point(25, 85);
            this.lbBirhday.Name = "lbBirhday";
            this.lbBirhday.Size = new System.Drawing.Size(45, 13);
            this.lbBirhday.TabIndex = 48;
            this.lbBirhday.Text = "Birthday";
            // 
            // lbPassportNumber
            // 
            this.lbPassportNumber.AutoSize = true;
            this.lbPassportNumber.Location = new System.Drawing.Point(25, 103);
            this.lbPassportNumber.Name = "lbPassportNumber";
            this.lbPassportNumber.Size = new System.Drawing.Size(91, 13);
            this.lbPassportNumber.TabIndex = 47;
            this.lbPassportNumber.Text = "Passport Number:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(25, 61);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 46;
            this.lbLastName.Text = "Last Name";
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Location = new System.Drawing.Point(25, 40);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lbMiddleName.TabIndex = 45;
            this.lbMiddleName.Text = "Middle Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Location = new System.Drawing.Point(119, 16);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(473, 20);
            this.tbFirstName.TabIndex = 41;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Location = new System.Drawing.Point(119, 58);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(473, 20);
            this.tbLastName.TabIndex = 43;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(25, 19);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 44;
            this.lbFirstName.Text = "First Name";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Enabled = false;
            this.tbMiddleName.Location = new System.Drawing.Point(119, 37);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(473, 20);
            this.tbMiddleName.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(623, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 222);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // PatientCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 317);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.mtbInnNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbBannedDrugs);
            this.Controls.Add(this.tbBannedDrugs);
            this.Controls.Add(this.lbDisease);
            this.Controls.Add(this.clbDisease);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbInnNumber);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lbBirhday);
            this.Controls.Add(this.lbPassportNumber);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbMiddleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientCard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PatientCard";
            this.Load += new System.EventHandler(this.PatientCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.MaskedTextBox mtbInnNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbBannedDrugs;
        private System.Windows.Forms.TextBox tbBannedDrugs;
        private System.Windows.Forms.Label lbDisease;
        private System.Windows.Forms.CheckedListBox clbDisease;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbInnNumber;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lbBirhday;
        private System.Windows.Forms.Label lbPassportNumber;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
    }
}