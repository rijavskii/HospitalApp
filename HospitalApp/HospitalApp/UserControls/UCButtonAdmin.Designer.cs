﻿namespace HospitalApp.UserControls
{
    partial class UcButtonAdmin
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
            this.components = new System.ComponentModel.Container();
            this.tsChangeInterface = new System.Windows.Forms.ToolStrip();
            this.tsBtnRegBut = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDocButtons = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAdminButtons = new System.Windows.Forms.ToolStripButton();
            this.tlpAdminBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnFindWorker = new System.Windows.Forms.Button();
            this.btnCreateWorker = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.ttTipsForButtons = new System.Windows.Forms.ToolTip(this.components);
            this.lblInterface = new System.Windows.Forms.Label();
            this.tsChangeInterface.SuspendLayout();
            this.tlpAdminBtns.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsChangeInterface
            // 
            this.tsChangeInterface.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsChangeInterface.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnRegBut,
            this.tsBtnDocButtons,
            this.tsBtnAdminButtons});
            this.tsChangeInterface.Location = new System.Drawing.Point(0, 0);
            this.tsChangeInterface.Name = "tsChangeInterface";
            this.tsChangeInterface.ShowItemToolTips = false;
            this.tsChangeInterface.Size = new System.Drawing.Size(193, 25);
            this.tsChangeInterface.TabIndex = 0;
            this.tsChangeInterface.Text = "toolStrip1";
            // 
            // tsBtnRegBut
            // 
            this.tsBtnRegBut.AutoToolTip = false;
            this.tsBtnRegBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRegBut.Image = global::HospitalApp.Properties.Resources.user_female_olive_green;
            this.tsBtnRegBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRegBut.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsBtnRegBut.Name = "tsBtnRegBut";
            this.tsBtnRegBut.Size = new System.Drawing.Size(23, 22);
            this.tsBtnRegBut.Text = "Registry buttons Navigation";
            this.tsBtnRegBut.Click += new System.EventHandler(this.tsBtnRegBut_Click);
            // 
            // tsBtnDocButtons
            // 
            this.tsBtnDocButtons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDocButtons.Image = global::HospitalApp.Properties.Resources.user;
            this.tsBtnDocButtons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDocButtons.Name = "tsBtnDocButtons";
            this.tsBtnDocButtons.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDocButtons.Text = "Doctor buttons Navigation";
            this.tsBtnDocButtons.Click += new System.EventHandler(this.tsBtnDocButtons_Click);
            // 
            // tsBtnAdminButtons
            // 
            this.tsBtnAdminButtons.AutoToolTip = false;
            this.tsBtnAdminButtons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAdminButtons.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tsBtnAdminButtons.Image = global::HospitalApp.Properties.Resources.devid;
            this.tsBtnAdminButtons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdminButtons.Name = "tsBtnAdminButtons";
            this.tsBtnAdminButtons.Size = new System.Drawing.Size(23, 22);
            this.tsBtnAdminButtons.Text = "Admin buttons Navigation";
            this.tsBtnAdminButtons.ToolTipText = "Admin buttons Navigation";
            this.tsBtnAdminButtons.Click += new System.EventHandler(this.tsBtnAdminButtons_Click);
            // 
            // tlpAdminBtns
            // 
            this.tlpAdminBtns.AutoSize = true;
            this.tlpAdminBtns.ColumnCount = 1;
            this.tlpAdminBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAdminBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAdminBtns.Controls.Add(this.btnFindWorker, 0, 1);
            this.tlpAdminBtns.Controls.Add(this.btnCreateWorker, 0, 0);
            this.tlpAdminBtns.Location = new System.Drawing.Point(3, 3);
            this.tlpAdminBtns.Name = "tlpAdminBtns";
            this.tlpAdminBtns.RowCount = 3;
            this.tlpAdminBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAdminBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAdminBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAdminBtns.Size = new System.Drawing.Size(181, 245);
            this.tlpAdminBtns.TabIndex = 1;
            // 
            // btnFindWorker
            // 
            this.btnFindWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindWorker.Location = new System.Drawing.Point(3, 84);
            this.btnFindWorker.Name = "btnFindWorker";
            this.btnFindWorker.Size = new System.Drawing.Size(167, 75);
            this.btnFindWorker.TabIndex = 2;
            this.btnFindWorker.Text = "Find worker";
            this.btnFindWorker.UseVisualStyleBackColor = true;
            this.btnFindWorker.Click += new System.EventHandler(this.btnFindWorker_Click);
            // 
            // btnCreateWorker
            // 
            this.btnCreateWorker.AutoSize = true;
            this.btnCreateWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateWorker.Location = new System.Drawing.Point(3, 3);
            this.btnCreateWorker.Name = "btnCreateWorker";
            this.btnCreateWorker.Size = new System.Drawing.Size(167, 75);
            this.btnCreateWorker.TabIndex = 0;
            this.btnCreateWorker.Text = "Create worker";
            this.btnCreateWorker.UseVisualStyleBackColor = true;
            this.btnCreateWorker.Click += new System.EventHandler(this.btnCreateWorker_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.tlpAdminBtns);
            this.pnlButtons.Location = new System.Drawing.Point(3, 28);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(187, 251);
            this.pnlButtons.TabIndex = 2;
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInterface.Location = new System.Drawing.Point(20, 354);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(141, 24);
            this.lblInterface.TabIndex = 3;
            this.lblInterface.Text = "Admin interface";
            // 
            // UcButtonAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInterface);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.tsChangeInterface);
            this.Name = "UcButtonAdmin";
            this.Size = new System.Drawing.Size(193, 378);
            this.tsChangeInterface.ResumeLayout(false);
            this.tsChangeInterface.PerformLayout();
            this.tlpAdminBtns.ResumeLayout(false);
            this.tlpAdminBtns.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsChangeInterface;
        private System.Windows.Forms.ToolStripButton tsBtnRegBut;
        private System.Windows.Forms.TableLayoutPanel tlpAdminBtns;
        private System.Windows.Forms.Button btnCreateWorker;
        private System.Windows.Forms.Button btnFindWorker;
        private System.Windows.Forms.ToolStripButton tsBtnDocButtons;
        private System.Windows.Forms.ToolStripButton tsBtnAdminButtons;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.ToolTip ttTipsForButtons;
        private System.Windows.Forms.Label lblInterface;
    }
}
