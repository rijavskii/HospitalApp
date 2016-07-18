namespace HospitalApp
{
    partial class UCButtonRegistry
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
            this.btNewPatient = new System.Windows.Forms.Button();
            this.btFindPatient = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btDoctors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNewPatient
            // 
            this.btNewPatient.Location = new System.Drawing.Point(6, 35);
            this.btNewPatient.Name = "btNewPatient";
            this.btNewPatient.Size = new System.Drawing.Size(162, 23);
            this.btNewPatient.TabIndex = 3;
            this.btNewPatient.Text = "New Patient";
            this.btNewPatient.UseVisualStyleBackColor = true;
            // 
            // btFindPatient
            // 
            this.btFindPatient.Location = new System.Drawing.Point(6, 6);
            this.btFindPatient.Name = "btFindPatient";
            this.btFindPatient.Size = new System.Drawing.Size(162, 23);
            this.btFindPatient.TabIndex = 2;
            this.btFindPatient.Text = "Find Patient";
            this.btFindPatient.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(6, 91);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(162, 23);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDoctors
            // 
            this.btDoctors.Location = new System.Drawing.Point(6, 62);
            this.btDoctors.Name = "btDoctors";
            this.btDoctors.Size = new System.Drawing.Size(162, 23);
            this.btDoctors.TabIndex = 7;
            this.btDoctors.Text = "Doctors";
            this.btDoctors.UseVisualStyleBackColor = true;
            // 
            // UCButtonRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDoctors);
            this.Controls.Add(this.btNewPatient);
            this.Controls.Add(this.btFindPatient);
            this.Name = "UCButtonRegistry";
            this.Size = new System.Drawing.Size(174, 245);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNewPatient;
        private System.Windows.Forms.Button btFindPatient;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDoctors;
    }
}
