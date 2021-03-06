﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp
{
    /// <summary>
    /// Authorization form
    /// </summary>
    public partial class Authorization : Form
    {
        /// <summary>
        /// Concrete user which exist in db
        /// </summary>
        public Users _user { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Authorization()
        {
            InitializeComponent();
#if DEBUG
            tbLogin.Text = "admin";
            tbPassword.Text = "admin";
            //btnAuthorizate_Click(null, EventArgs.Empty);
            //var e = new EventArgs();
            //btnAuthorizate_Click(this, e );
#endif
        }

        private void btnAuthorizate_Click(object sender, EventArgs e)
        {
            
            // Use context like this
            using (var context = new HospitalDbContext())
            {
                var myLogin = this.tbLogin.Text;
                var myPsd = this.tbPassword.Text.GetMd5Hash();
                _user = context.Users.Include(x=>x.Position).FirstOrDefault(x => x.Login == myLogin && x.Password == myPsd);
                //include position to user
            }
            
            if (_user == null)
            {
                MessageBox.Show("Wrong Login or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                Close();

            //var context = new HospitalDbContext();

            //var myLogin = this.tbLogin.Text;
            //var myPsd = this.tbPassword.Text.GetMd5Hash();

           
            //    _user = context.Users.FirstOrDefault(x => x.Login == myLogin && x.Password == myPsd);
            //    if (_user == null)
            //    {
            //        MessageBox.Show("Wrong Login or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //        Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((Keys)e.KeyChar)
            {
                case Keys.Enter:
                    btnAuthorizate_Click(sender, e);
                    e.Handled = true;
                    break;
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((Keys)e.KeyChar)
            {
                case Keys.Enter:
                    btnAuthorizate_Click(sender, e);
                    e.Handled = true;
                    break;  
            }
        }

        private void Authorization_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((Keys)e.KeyChar)
            {
                case Keys.Escape:
                    btnCancel_Click(sender, e);
                    e.Handled = true;
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*')
            {
                pictureBox2.Image = global::HospitalApp.Properties.Resources.eye_open;
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                pictureBox2.Image = global::HospitalApp.Properties.Resources.eye_closed;
                tbPassword.PasswordChar = '*';
            }
        }
    }
}
