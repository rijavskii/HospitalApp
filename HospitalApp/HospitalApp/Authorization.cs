using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Authorization'
    public partial class Authorization : Form
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Authorization'
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Authorization._user'
        public Users _user { get; private set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Authorization._user'
        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Authorization.Authorization()'
        public Authorization()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Authorization.Authorization()'
        {
            InitializeComponent();
#if DEBUG
            tbLogin.Text = "admin";
            tbPassword.Text = "admin";
            //var e = new EventArgs();
            //btnAuthorizate_Click(this, e );
#endif
        }

        private void btnAuthorizate_Click(object sender, EventArgs e)
        {
            var context = new HospitalDbContext();

            var myLogin = this.tbLogin.Text;
            var myPsd = this.tbPassword.Text;

           
                _user = context.Users.FirstOrDefault(x => x.Login == myLogin && x.Password == myPsd);
                if (_user == null)
                {
                    MessageBox.Show("Wrong Login or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void btShowPassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*')
            {
                this.btShowPassword.Text = @"Hide password";
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                this.btShowPassword.Text = @"Show password";
                tbPassword.PasswordChar = '*';
            }
        }
    }
}
