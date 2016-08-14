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
    public partial class Authorization : Form
    {
        public Users _user { get; private set; }
        
        public Authorization()
        {
            InitializeComponent();
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
            if (tbPassword.PasswordChar == '*') tbPassword.PasswordChar = '\0';
            else tbPassword.PasswordChar = '*';
        }
    }
}
