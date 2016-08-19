﻿namespace HospitalApp
{
    partial class CoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.ucEditPatientInfo1 = new HospitalApp.UCEditPatientInfo();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel2.SuspendLayout();
            this.scContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importMedicineToolStripMenuItem,
            this.exportMedicineToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importMedicineToolStripMenuItem
            // 
            this.importMedicineToolStripMenuItem.Name = "importMedicineToolStripMenuItem";
            this.importMedicineToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.importMedicineToolStripMenuItem.Text = "Import medicine";
            this.importMedicineToolStripMenuItem.Click += new System.EventHandler(this.importMedicineToolStripMenuItem_Click);
            // 
            // exportMedicineToolStripMenuItem
            // 
            this.exportMedicineToolStripMenuItem.Name = "exportMedicineToolStripMenuItem";
            this.exportMedicineToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exportMedicineToolStripMenuItem.Text = "Export medicine";
            this.exportMedicineToolStripMenuItem.Click += new System.EventHandler(this.exportMedicineToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // scContent
            // 
            this.scContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContent.Location = new System.Drawing.Point(0, 24);
            this.scContent.Name = "scContent";
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.ucEditPatientInfo1);
            this.scContent.Size = new System.Drawing.Size(995, 494);
            this.scContent.SplitterDistance = 184;
            this.scContent.TabIndex = 1;
            // 
            // ucEditPatientInfo1
            // 
            this.ucEditPatientInfo1.Location = new System.Drawing.Point(4, 4);
            this.ucEditPatientInfo1.Name = "ucEditPatientInfo1";
            this.ucEditPatientInfo1.Size = new System.Drawing.Size(828, 379);
            this.ucEditPatientInfo1.TabIndex = 0;
            // 
            // CoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 518);
            this.Controls.Add(this.scContent);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoreForm";
            this.Text = "Hospital";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importMedicineToolStripMenuItem;
        private UCEditPatientInfo ucEditPatientInfo1;
    }
}

