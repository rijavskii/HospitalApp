namespace HospitalApp
{
    partial class UcButtonRegistry
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.btnSignInDoctor = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnNewPatient, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFindUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSignInDoctor, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 239);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPatient.Location = new System.Drawing.Point(3, 3);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(188, 53);
            this.btnNewPatient.TabIndex = 0;
            this.btnNewPatient.Text = "New patient";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindUser.Location = new System.Drawing.Point(3, 62);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(188, 53);
            this.btnFindUser.TabIndex = 1;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnSignInDoctor
            // 
            this.btnSignInDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignInDoctor.Location = new System.Drawing.Point(3, 121);
            this.btnSignInDoctor.Name = "btnSignInDoctor";
            this.btnSignInDoctor.Size = new System.Drawing.Size(188, 53);
            this.btnSignInDoctor.TabIndex = 2;
            this.btnSignInDoctor.Text = "Sign in to doctor";
            this.btnSignInDoctor.UseVisualStyleBackColor = true;
            // 
            // UcButtonRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcButtonRegistry";
            this.Size = new System.Drawing.Size(200, 250);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Button btnSignInDoctor;
    }
}
