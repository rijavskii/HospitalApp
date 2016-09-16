namespace HospitalApp
{
    partial class SearchDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDoctor));
            this.lvDoctors = new System.Windows.Forms.ListView();
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDocType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFind = new System.Windows.Forms.Button();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.gbWorkerInfo = new System.Windows.Forms.GroupBox();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.tbPositionsType = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblPositionType = new System.Windows.Forms.Label();
            this.mtbInnNumber = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbPassportSeries = new System.Windows.Forms.MaskedTextBox();
            this.tbDocMiddleName = new System.Windows.Forms.TextBox();
            this.mtbPassportNumber = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDocLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDocFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPassportNumber = new System.Windows.Forms.Label();
            this.lbBirhday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.gbWorkerInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.lvDoctors.Location = new System.Drawing.Point(21, 108);
            this.lvDoctors.MultiSelect = false;
            this.lvDoctors.Name = "lvDoctors";
            this.lvDoctors.Size = new System.Drawing.Size(233, 277);
            this.lvDoctors.TabIndex = 64;
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
            this.chRoom.Width = 47;
            // 
            // btnFind
            // 
            this.btnFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFind.Location = new System.Drawing.Point(143, 79);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(111, 23);
            this.btnFind.TabIndex = 63;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbLastName.Location = new System.Drawing.Point(18, 56);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 61;
            this.lbLastName.Text = "Last Name";
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMiddleName.Location = new System.Drawing.Point(18, 35);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lbMiddleName.TabIndex = 60;
            this.lbMiddleName.Text = "Middle Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(112, 11);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(142, 20);
            this.tbFirstName.TabIndex = 55;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(112, 53);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(142, 20);
            this.tbLastName.TabIndex = 57;
            this.tbLastName.Tag = "";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbFirstName.Location = new System.Drawing.Point(18, 14);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 59;
            this.lbFirstName.Text = "First Name";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(112, 32);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(142, 20);
            this.tbMiddleName.TabIndex = 56;
            // 
            // btnChoose
            // 
            this.btnChoose.Enabled = false;
            this.btnChoose.Location = new System.Drawing.Point(407, 359);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(118, 26);
            this.btnChoose.TabIndex = 65;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // gbWorkerInfo
            // 
            this.gbWorkerInfo.Controls.Add(this.tbRoom);
            this.gbWorkerInfo.Controls.Add(this.tbPositionsType);
            this.gbWorkerInfo.Controls.Add(this.lblRoom);
            this.gbWorkerInfo.Controls.Add(this.lblPositionType);
            this.gbWorkerInfo.Controls.Add(this.mtbInnNumber);
            this.gbWorkerInfo.Controls.Add(this.label4);
            this.gbWorkerInfo.Controls.Add(this.mtbPassportSeries);
            this.gbWorkerInfo.Controls.Add(this.tbDocMiddleName);
            this.gbWorkerInfo.Controls.Add(this.mtbPassportNumber);
            this.gbWorkerInfo.Controls.Add(this.label6);
            this.gbWorkerInfo.Controls.Add(this.label2);
            this.gbWorkerInfo.Controls.Add(this.tbDocLastName);
            this.gbWorkerInfo.Controls.Add(this.label1);
            this.gbWorkerInfo.Controls.Add(this.tbDocFirstName);
            this.gbWorkerInfo.Controls.Add(this.label3);
            this.gbWorkerInfo.Controls.Add(this.label5);
            this.gbWorkerInfo.Controls.Add(this.lbPassportNumber);
            this.gbWorkerInfo.Controls.Add(this.lbBirhday);
            this.gbWorkerInfo.Controls.Add(this.dtpBirthday);
            this.gbWorkerInfo.Location = new System.Drawing.Point(277, 12);
            this.gbWorkerInfo.Name = "gbWorkerInfo";
            this.gbWorkerInfo.Size = new System.Drawing.Size(248, 341);
            this.gbWorkerInfo.TabIndex = 66;
            this.gbWorkerInfo.TabStop = false;
            this.gbWorkerInfo.Text = "Worker";
            this.gbWorkerInfo.Visible = false;
            // 
            // tbRoom
            // 
            this.tbRoom.Enabled = false;
            this.tbRoom.Location = new System.Drawing.Point(100, 211);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(81, 20);
            this.tbRoom.TabIndex = 94;
            // 
            // tbPositionsType
            // 
            this.tbPositionsType.Enabled = false;
            this.tbPositionsType.Location = new System.Drawing.Point(100, 184);
            this.tbPositionsType.Name = "tbPositionsType";
            this.tbPositionsType.Size = new System.Drawing.Size(142, 20);
            this.tbPositionsType.TabIndex = 96;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(6, 214);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 93;
            this.lblRoom.Text = "Room";
            // 
            // lblPositionType
            // 
            this.lblPositionType.AutoSize = true;
            this.lblPositionType.Location = new System.Drawing.Point(6, 191);
            this.lblPositionType.Name = "lblPositionType";
            this.lblPositionType.Size = new System.Drawing.Size(67, 13);
            this.lblPositionType.TabIndex = 95;
            this.lblPositionType.Text = "Position type";
            // 
            // mtbInnNumber
            // 
            this.mtbInnNumber.Enabled = false;
            this.mtbInnNumber.HidePromptOnLeave = true;
            this.mtbInnNumber.Location = new System.Drawing.Point(100, 162);
            this.mtbInnNumber.Mask = "0000 0000 00";
            this.mtbInnNumber.Name = "mtbInnNumber";
            this.mtbInnNumber.Size = new System.Drawing.Size(78, 20);
            this.mtbInnNumber.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Last Name";
            // 
            // mtbPassportSeries
            // 
            this.mtbPassportSeries.Enabled = false;
            this.mtbPassportSeries.HidePromptOnLeave = true;
            this.mtbPassportSeries.Location = new System.Drawing.Point(144, 110);
            this.mtbPassportSeries.Mask = " L L";
            this.mtbPassportSeries.Name = "mtbPassportSeries";
            this.mtbPassportSeries.Size = new System.Drawing.Size(34, 20);
            this.mtbPassportSeries.TabIndex = 91;
            // 
            // tbDocMiddleName
            // 
            this.tbDocMiddleName.Enabled = false;
            this.tbDocMiddleName.Location = new System.Drawing.Point(100, 39);
            this.tbDocMiddleName.Name = "tbDocMiddleName";
            this.tbDocMiddleName.Size = new System.Drawing.Size(142, 20);
            this.tbDocMiddleName.TabIndex = 79;
            // 
            // mtbPassportNumber
            // 
            this.mtbPassportNumber.Enabled = false;
            this.mtbPassportNumber.HidePromptOnLeave = true;
            this.mtbPassportNumber.Location = new System.Drawing.Point(144, 136);
            this.mtbPassportNumber.Mask = " 0 0 0 0 0 0";
            this.mtbPassportNumber.Name = "mtbPassportNumber";
            this.mtbPassportNumber.Size = new System.Drawing.Size(66, 20);
            this.mtbPassportNumber.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Number";
            // 
            // tbDocLastName
            // 
            this.tbDocLastName.Enabled = false;
            this.tbDocLastName.Location = new System.Drawing.Point(100, 60);
            this.tbDocLastName.Name = "tbDocLastName";
            this.tbDocLastName.Size = new System.Drawing.Size(142, 20);
            this.tbDocLastName.TabIndex = 80;
            this.tbDocLastName.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Series";
            // 
            // tbDocFirstName
            // 
            this.tbDocFirstName.Enabled = false;
            this.tbDocFirstName.Location = new System.Drawing.Point(100, 18);
            this.tbDocFirstName.Name = "tbDocFirstName";
            this.tbDocFirstName.Size = new System.Drawing.Size(142, 20);
            this.tbDocFirstName.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "INN Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Middle Name";
            // 
            // lbPassportNumber
            // 
            this.lbPassportNumber.AutoSize = true;
            this.lbPassportNumber.Location = new System.Drawing.Point(6, 110);
            this.lbPassportNumber.Name = "lbPassportNumber";
            this.lbPassportNumber.Size = new System.Drawing.Size(51, 13);
            this.lbPassportNumber.TabIndex = 86;
            this.lbPassportNumber.Text = "Passport:";
            // 
            // lbBirhday
            // 
            this.lbBirhday.AutoSize = true;
            this.lbBirhday.Location = new System.Drawing.Point(6, 87);
            this.lbBirhday.Name = "lbBirhday";
            this.lbBirhday.Size = new System.Drawing.Size(45, 13);
            this.lbBirhday.TabIndex = 84;
            this.lbBirhday.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Enabled = false;
            this.dtpBirthday.Location = new System.Drawing.Point(100, 81);
            this.dtpBirthday.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(142, 20);
            this.dtpBirthday.TabIndex = 85;
            this.dtpBirthday.Value = new System.DateTime(2016, 8, 16, 0, 0, 0, 0);
            // 
            // SearchDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 397);
            this.Controls.Add(this.gbWorkerInfo);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lvDoctors);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbMiddleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchDoctor";
            this.ShowInTaskbar = false;
            this.Text = "SearchDoctor";
            this.gbWorkerInfo.ResumeLayout(false);
            this.gbWorkerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDoctors;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chDocType;
        private System.Windows.Forms.ColumnHeader chRoom;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.MaskedTextBox mtbInnNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbPassportSeries;
        private System.Windows.Forms.TextBox tbDocMiddleName;
        private System.Windows.Forms.MaskedTextBox mtbPassportNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDocLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDocFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPassportNumber;
        private System.Windows.Forms.Label lbBirhday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.TextBox tbPositionsType;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblPositionType;
        private System.Windows.Forms.GroupBox gbWorkerInfo;
    }
}