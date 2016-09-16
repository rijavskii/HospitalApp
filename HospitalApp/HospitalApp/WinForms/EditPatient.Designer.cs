namespace HospitalApp
{
    partial class EditPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPatient));
            this.btSave = new System.Windows.Forms.Button();
            this.mtbInnNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtbPassportSeries = new System.Windows.Forms.MaskedTextBox();
            this.mtbPassportNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPassportNumber = new System.Windows.Forms.Label();
            this.gpAdress = new System.Windows.Forms.GroupBox();
            this.tbAppartment = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbHouseNumber = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbDistrict = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.lblAppartment = new System.Windows.Forms.Label();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbBirhday = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.gpAdress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btSave.Location = new System.Drawing.Point(222, 341);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(85, 23);
            this.btSave.TabIndex = 61;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // mtbInnNumber
            // 
            this.mtbInnNumber.HidePromptOnLeave = true;
            this.mtbInnNumber.Location = new System.Drawing.Point(106, 122);
            this.mtbInnNumber.Mask = "0000 0000 00";
            this.mtbInnNumber.Name = "mtbInnNumber";
            this.mtbInnNumber.Size = new System.Drawing.Size(100, 20);
            this.mtbInnNumber.TabIndex = 94;
            // 
            // mtbPassportSeries
            // 
            this.mtbPassportSeries.HidePromptOnLeave = true;
            this.mtbPassportSeries.Location = new System.Drawing.Point(172, 101);
            this.mtbPassportSeries.Mask = " L L";
            this.mtbPassportSeries.Name = "mtbPassportSeries";
            this.mtbPassportSeries.Size = new System.Drawing.Size(34, 20);
            this.mtbPassportSeries.TabIndex = 93;
            // 
            // mtbPassportNumber
            // 
            this.mtbPassportNumber.HidePromptOnLeave = true;
            this.mtbPassportNumber.Location = new System.Drawing.Point(269, 101);
            this.mtbPassportNumber.Mask = " 0 0 0 0 0 0";
            this.mtbPassportNumber.Name = "mtbPassportNumber";
            this.mtbPassportNumber.Size = new System.Drawing.Size(66, 20);
            this.mtbPassportNumber.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Series";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "INN Number";
            // 
            // lbPassportNumber
            // 
            this.lbPassportNumber.AutoSize = true;
            this.lbPassportNumber.Location = new System.Drawing.Point(12, 104);
            this.lbPassportNumber.Name = "lbPassportNumber";
            this.lbPassportNumber.Size = new System.Drawing.Size(51, 13);
            this.lbPassportNumber.TabIndex = 88;
            this.lbPassportNumber.Text = "Passport:";
            // 
            // gpAdress
            // 
            this.gpAdress.Controls.Add(this.tbAppartment);
            this.gpAdress.Controls.Add(this.tbStreet);
            this.gpAdress.Controls.Add(this.tbHouseNumber);
            this.gpAdress.Controls.Add(this.tbCity);
            this.gpAdress.Controls.Add(this.tbRegion);
            this.gpAdress.Controls.Add(this.tbDistrict);
            this.gpAdress.Controls.Add(this.tbCountry);
            this.gpAdress.Controls.Add(this.lblAppartment);
            this.gpAdress.Controls.Add(this.lblHouseNumber);
            this.gpAdress.Controls.Add(this.lblStreet);
            this.gpAdress.Controls.Add(this.lblCity);
            this.gpAdress.Controls.Add(this.lblRegion);
            this.gpAdress.Controls.Add(this.lblDistrict);
            this.gpAdress.Controls.Add(this.lblCountry);
            this.gpAdress.Location = new System.Drawing.Point(107, 197);
            this.gpAdress.Name = "gpAdress";
            this.gpAdress.Size = new System.Drawing.Size(324, 124);
            this.gpAdress.TabIndex = 87;
            this.gpAdress.TabStop = false;
            // 
            // tbAppartment
            // 
            this.tbAppartment.Location = new System.Drawing.Point(234, 67);
            this.tbAppartment.Name = "tbAppartment";
            this.tbAppartment.Size = new System.Drawing.Size(81, 20);
            this.tbAppartment.TabIndex = 13;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(234, 38);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(81, 20);
            this.tbStreet.TabIndex = 12;
            // 
            // tbHouseNumber
            // 
            this.tbHouseNumber.Location = new System.Drawing.Point(234, 14);
            this.tbHouseNumber.Name = "tbHouseNumber";
            this.tbHouseNumber.Size = new System.Drawing.Size(81, 20);
            this.tbHouseNumber.TabIndex = 11;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(60, 86);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(81, 20);
            this.tbCity.TabIndex = 10;
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(60, 67);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(81, 20);
            this.tbRegion.TabIndex = 9;
            // 
            // tbDistrict
            // 
            this.tbDistrict.Location = new System.Drawing.Point(60, 38);
            this.tbDistrict.Name = "tbDistrict";
            this.tbDistrict.Size = new System.Drawing.Size(81, 20);
            this.tbDistrict.TabIndex = 8;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(60, 14);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(81, 20);
            this.tbCountry.TabIndex = 7;
            // 
            // lblAppartment
            // 
            this.lblAppartment.AutoSize = true;
            this.lblAppartment.Location = new System.Drawing.Point(150, 67);
            this.lblAppartment.Name = "lblAppartment";
            this.lblAppartment.Size = new System.Drawing.Size(61, 13);
            this.lblAppartment.TabIndex = 6;
            this.lblAppartment.Text = "Appartment";
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Location = new System.Drawing.Point(150, 17);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(78, 13);
            this.lblHouseNumber.TabIndex = 5;
            this.lblHouseNumber.Text = "House Number";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(150, 41);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(11, 89);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(11, 67);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Region";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(11, 41);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(39, 13);
            this.lblDistrict.TabIndex = 1;
            this.lblDistrict.Text = "District";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(11, 17);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(12, 214);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 86;
            this.lbAddress.Text = "Address";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(106, 72);
            this.dtpBirthday.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(325, 20);
            this.dtpBirthday.TabIndex = 85;
            this.dtpBirthday.Value = new System.DateTime(2016, 8, 16, 0, 0, 0, 0);
            // 
            // lbBirhday
            // 
            this.lbBirhday.AutoSize = true;
            this.lbBirhday.Location = new System.Drawing.Point(12, 78);
            this.lbBirhday.Name = "lbBirhday";
            this.lbBirhday.Size = new System.Drawing.Size(45, 13);
            this.lbBirhday.TabIndex = 84;
            this.lbBirhday.Text = "Birthday";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(12, 54);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 83;
            this.lbLastName.Text = "Last Name";
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Location = new System.Drawing.Point(12, 33);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lbMiddleName.TabIndex = 82;
            this.lbMiddleName.Text = "Middle Name";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(107, 171);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(325, 20);
            this.tbPassword.TabIndex = 78;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(106, 51);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(325, 20);
            this.tbLastName.TabIndex = 80;
            this.tbLastName.Tag = "";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Location = new System.Drawing.Point(13, 174);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lbNewPassword.TabIndex = 81;
            this.lbNewPassword.Text = "New Password";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(106, 30);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(325, 20);
            this.tbMiddleName.TabIndex = 79;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(13, 151);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 81;
            this.lbLogin.Text = "Login";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(107, 148);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(325, 20);
            this.tbLogin.TabIndex = 78;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(341, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 95;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(107, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(325, 20);
            this.tbFirstName.TabIndex = 96;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(13, 7);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 97;
            this.lbFirstName.Text = "First Name";
            // 
            // EditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 376);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.mtbInnNumber);
            this.Controls.Add(this.mtbPassportSeries);
            this.Controls.Add(this.mtbPassportNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPassportNumber);
            this.Controls.Add(this.gpAdress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lbBirhday);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.btSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPatient";
            this.ShowInTaskbar = false;
            this.Text = "Edit Patient";
            this.gpAdress.ResumeLayout(false);
            this.gpAdress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.MaskedTextBox mtbInnNumber;
        private System.Windows.Forms.MaskedTextBox mtbPassportSeries;
        private System.Windows.Forms.MaskedTextBox mtbPassportNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPassportNumber;
        private System.Windows.Forms.GroupBox gpAdress;
        private System.Windows.Forms.TextBox tbAppartment;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbHouseNumber;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbDistrict;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lblAppartment;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lbBirhday;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbFirstName;
    }
}