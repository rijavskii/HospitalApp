namespace HospitalApp
{
    partial class SignInToDoctor
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
            this.ucEditPatientInfo1 = new HospitalApp.UCEditPatientInfo();
            this.btSave = new System.Windows.Forms.Button();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbPassportNunber = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView2 = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBusy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucEditPatientInfo1
            // 
            this.ucEditPatientInfo1.Location = new System.Drawing.Point(1, 0);
            this.ucEditPatientInfo1.Name = "ucEditPatientInfo1";
            this.ucEditPatientInfo1.Size = new System.Drawing.Size(828, 379);
            this.ucEditPatientInfo1.TabIndex = 0;
            this.ucEditPatientInfo1.Load += new System.EventHandler(this.ucEditPatientInfo1_Load);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(139, 112);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(111, 23);
            this.btSave.TabIndex = 53;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(14, 89);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(35, 13);
            this.lbRoom.TabIndex = 41;
            this.lbRoom.Text = "Room";
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
            // tbPassportNunber
            // 
            this.tbPassportNunber.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbPassportNunber.Location = new System.Drawing.Point(108, 86);
            this.tbPassportNunber.Name = "tbPassportNunber";
            this.tbPassportNunber.Size = new System.Drawing.Size(142, 20);
            this.tbPassportNunber.TabIndex = 37;
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFirstName,
            this.chLastName});
            this.listView1.Location = new System.Drawing.Point(17, 141);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(233, 234);
            this.listView1.TabIndex = 54;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chBusy,
            this.chPatient});
            this.listView2.Location = new System.Drawing.Point(305, 49);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(255, 325);
            this.listView2.TabIndex = 56;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
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
            // chFirstName
            // 
            this.chFirstName.Text = "First name";
            this.chFirstName.Width = 70;
            // 
            // chLastName
            // 
            this.chLastName.Text = "LastName";
            this.chLastName.Width = 69;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(580, 344);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(97, 30);
            this.btnSignIn.TabIndex = 57;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // SignInToDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 392);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbRoom);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.tbPassportNunber);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbMiddleName);
            this.Name = "SignInToDoctor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCEditPatientInfo ucEditPatientInfo1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbPassportNunber;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chBusy;
        private System.Windows.Forms.ColumnHeader chPatient;
        private System.Windows.Forms.Button btnSignIn;
    }
}