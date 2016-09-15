namespace HospitalApp.UserControls
{
    partial class UcDoctorSchedule
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
            this.dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.lvAppointment = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPatientCard = new System.Windows.Forms.Button();
            this.btnDiagnose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpAppointmentTime
            // 
            this.dtpAppointmentTime.Location = new System.Drawing.Point(13, 15);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.Size = new System.Drawing.Size(247, 20);
            this.dtpAppointmentTime.TabIndex = 1;
            this.dtpAppointmentTime.Value = new System.DateTime(2016, 9, 13, 0, 0, 0, 0);
            this.dtpAppointmentTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDayOfWeek.Location = new System.Drawing.Point(68, 38);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(0, 24);
            this.lblDayOfWeek.TabIndex = 2;
            // 
            // lvAppointment
            // 
            this.lvAppointment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chPatient});
            this.lvAppointment.FullRowSelect = true;
            this.lvAppointment.GridLines = true;
            this.lvAppointment.Location = new System.Drawing.Point(13, 65);
            this.lvAppointment.Name = "lvAppointment";
            this.lvAppointment.ShowItemToolTips = true;
            this.lvAppointment.Size = new System.Drawing.Size(247, 338);
            this.lvAppointment.TabIndex = 3;
            this.lvAppointment.UseCompatibleStateImageBehavior = false;
            this.lvAppointment.View = System.Windows.Forms.View.Details;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 72;
            // 
            // chPatient
            // 
            this.chPatient.Text = "Patient";
            this.chPatient.Width = 170;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnPatientCard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDiagnose, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(282, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 391);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnPatientCard
            // 
            this.btnPatientCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPatientCard.Location = new System.Drawing.Point(3, 3);
            this.btnPatientCard.Name = "btnPatientCard";
            this.btnPatientCard.Size = new System.Drawing.Size(197, 72);
            this.btnPatientCard.TabIndex = 0;
            this.btnPatientCard.Text = "Open patient card";
            this.btnPatientCard.UseVisualStyleBackColor = true;
            this.btnPatientCard.Click += new System.EventHandler(this.btnPatientCard_Click);
            // 
            // btnDiagnose
            // 
            this.btnDiagnose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiagnose.Location = new System.Drawing.Point(3, 81);
            this.btnDiagnose.Name = "btnDiagnose";
            this.btnDiagnose.Size = new System.Drawing.Size(197, 72);
            this.btnDiagnose.TabIndex = 1;
            this.btnDiagnose.Text = "Write diagnose";
            this.btnDiagnose.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 71);
            this.button3.TabIndex = 1;
            this.button3.Text = "Patient appointment";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UcDoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lvAppointment);
            this.Controls.Add(this.lblDayOfWeek);
            this.Controls.Add(this.dtpAppointmentTime);
            this.Name = "UcDoctorSchedule";
            this.Size = new System.Drawing.Size(499, 424);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.ListView lvAppointment;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chPatient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPatientCard;
        private System.Windows.Forms.Button btnDiagnose;
        private System.Windows.Forms.Button button3;
    }
}
