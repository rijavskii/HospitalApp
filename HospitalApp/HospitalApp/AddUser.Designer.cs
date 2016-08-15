namespace HospitalApp
{
    partial class AddUser
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
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 371);
            this.Controls.Add(this.ucEditPatientInfo1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);

        }

        #endregion

        private UCEditPatientInfo ucEditPatientInfo1;
    }
}