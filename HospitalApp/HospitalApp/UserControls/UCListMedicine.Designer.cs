namespace HospitalApp
{
    partial class UcListMedicine
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
            this.lvDrugs = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDrugs
            // 
            this.lvDrugs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chManufacturer,
            this.chCountry,
            this.chType});
            this.lvDrugs.FullRowSelect = true;
            this.lvDrugs.GridLines = true;
            this.lvDrugs.Location = new System.Drawing.Point(4, 8);
            this.lvDrugs.Name = "lvDrugs";
            this.lvDrugs.ShowItemToolTips = true;
            this.lvDrugs.Size = new System.Drawing.Size(749, 338);
            this.lvDrugs.TabIndex = 0;
            this.lvDrugs.UseCompatibleStateImageBehavior = false;
            this.lvDrugs.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 253;
            // 
            // chManufacturer
            // 
            this.chManufacturer.Text = "Manufacturer";
            this.chManufacturer.Width = 170;
            // 
            // chCountry
            // 
            this.chCountry.Text = "Country";
            this.chCountry.Width = 151;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 169;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(643, 352);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // UcListMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvDrugs);
            this.Name = "UcListMedicine";
            this.Size = new System.Drawing.Size(756, 386);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDrugs;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chManufacturer;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader chCountry;
    }
}
