namespace HospitalApp.UserControls
{
    partial class UCAddUser
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
            this.btSave = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbInnNumber = new System.Windows.Forms.Label();
            this.tbInnNumber = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbBirhday = new System.Windows.Forms.Label();
            this.lbPassportNumber = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbPassportNunber = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpAdress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(467, 288);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(111, 23);
            this.btSave.TabIndex = 69;
            this.btSave.Text = "Create";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(21, 204);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 68;
            this.lbAddress.Text = "Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(446, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 152);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // lbInnNumber
            // 
            this.lbInnNumber.AutoSize = true;
            this.lbInnNumber.Location = new System.Drawing.Point(21, 157);
            this.lbInnNumber.Name = "lbInnNumber";
            this.lbInnNumber.Size = new System.Drawing.Size(66, 13);
            this.lbInnNumber.TabIndex = 65;
            this.lbInnNumber.Text = "INN Number";
            // 
            // tbInnNumber
            // 
            this.tbInnNumber.Location = new System.Drawing.Point(115, 154);
            this.tbInnNumber.Name = "tbInnNumber";
            this.tbInnNumber.Size = new System.Drawing.Size(325, 20);
            this.tbInnNumber.TabIndex = 64;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(115, 112);
            this.dtpBirthday.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(325, 20);
            this.dtpBirthday.TabIndex = 63;
            this.dtpBirthday.Value = new System.DateTime(2016, 8, 16, 0, 0, 0, 0);
            // 
            // lbBirhday
            // 
            this.lbBirhday.AutoSize = true;
            this.lbBirhday.Location = new System.Drawing.Point(21, 118);
            this.lbBirhday.Name = "lbBirhday";
            this.lbBirhday.Size = new System.Drawing.Size(45, 13);
            this.lbBirhday.TabIndex = 62;
            this.lbBirhday.Text = "Birthday";
            // 
            // lbPassportNumber
            // 
            this.lbPassportNumber.AutoSize = true;
            this.lbPassportNumber.Location = new System.Drawing.Point(21, 136);
            this.lbPassportNumber.Name = "lbPassportNumber";
            this.lbPassportNumber.Size = new System.Drawing.Size(88, 13);
            this.lbPassportNumber.TabIndex = 61;
            this.lbPassportNumber.Text = "Passport Number";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(21, 94);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 60;
            this.lbLastName.Text = "Last Name";
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Location = new System.Drawing.Point(21, 73);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lbMiddleName.TabIndex = 59;
            this.lbMiddleName.Text = "Middle Name";
            // 
            // tbPassportNunber
            // 
            this.tbPassportNunber.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbPassportNunber.Location = new System.Drawing.Point(115, 133);
            this.tbPassportNunber.Name = "tbPassportNunber";
            this.tbPassportNunber.Size = new System.Drawing.Size(325, 20);
            this.tbPassportNunber.TabIndex = 57;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(115, 49);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(325, 20);
            this.tbFirstName.TabIndex = 54;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(115, 91);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(325, 20);
            this.tbLastName.TabIndex = 56;
            this.tbLastName.Tag = "";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(21, 52);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 58;
            this.lbFirstName.Text = "First Name";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(115, 70);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(325, 20);
            this.tbMiddleName.TabIndex = 55;
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
            this.gpAdress.Location = new System.Drawing.Point(116, 187);
            this.gpAdress.Name = "gpAdress";
            this.gpAdress.Size = new System.Drawing.Size(324, 124);
            this.gpAdress.TabIndex = 70;
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
            this.tbRegion.Location = new System.Drawing.Point(60, 64);
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
            // UCAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpAdress);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbInnNumber);
            this.Controls.Add(this.tbInnNumber);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lbBirhday);
            this.Controls.Add(this.lbPassportNumber);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.tbPassportNunber);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbMiddleName);
            this.Name = "UCAddUser";
            this.Size = new System.Drawing.Size(604, 331);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpAdress.ResumeLayout(false);
            this.gpAdress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbInnNumber;
        private System.Windows.Forms.TextBox tbInnNumber;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lbBirhday;
        private System.Windows.Forms.Label lbPassportNumber;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbPassportNunber;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.GroupBox gpAdress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblDistrict;
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
    }
}
