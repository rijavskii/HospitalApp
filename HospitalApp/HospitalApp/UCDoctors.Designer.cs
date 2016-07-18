namespace HospitalApp
{
    partial class UCDoctors
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chDoctorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMonday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTuesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWednesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThursday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFriday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSaturday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSunday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDoctorName,
            this.chMonday,
            this.chTuesday,
            this.chWednesday,
            this.chThursday,
            this.chFriday,
            this.chSaturday,
            this.chSunday});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(16, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(828, 374);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chDoctorName
            // 
            this.chDoctorName.Text = "";
            this.chDoctorName.Width = 245;
            // 
            // chMonday
            // 
            this.chMonday.Text = "Monday";
            this.chMonday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMonday.Width = 86;
            // 
            // chTuesday
            // 
            this.chTuesday.Text = "Tuesday";
            this.chTuesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTuesday.Width = 80;
            // 
            // chWednesday
            // 
            this.chWednesday.Text = "Wednesday";
            this.chWednesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWednesday.Width = 80;
            // 
            // chThursday
            // 
            this.chThursday.Text = "Thursday";
            this.chThursday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chThursday.Width = 87;
            // 
            // chFriday
            // 
            this.chFriday.Text = "Friday";
            this.chFriday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chFriday.Width = 81;
            // 
            // chSaturday
            // 
            this.chSaturday.Text = "Saturday";
            this.chSaturday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSaturday.Width = 83;
            // 
            // chSunday
            // 
            this.chSunday.Text = "Sunday";
            this.chSunday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSunday.Width = 81;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(734, 394);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(110, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // UCDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.listView1);
            this.Name = "UCDoctors";
            this.Size = new System.Drawing.Size(860, 429);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chDoctorName;
        private System.Windows.Forms.ColumnHeader chMonday;
        private System.Windows.Forms.ColumnHeader chTuesday;
        private System.Windows.Forms.ColumnHeader chWednesday;
        private System.Windows.Forms.ColumnHeader chThursday;
        private System.Windows.Forms.ColumnHeader chFriday;
        private System.Windows.Forms.ColumnHeader chSaturday;
        private System.Windows.Forms.ColumnHeader chSunday;
        private System.Windows.Forms.Button btCancel;
    }
}
