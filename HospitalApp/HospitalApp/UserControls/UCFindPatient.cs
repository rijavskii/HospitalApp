using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class UCFindPatient : UserControl
    {
        private ListViewItem _items;
        private List<Users> _users;
        /// <summary>
        /// Controller which allow to find users in database
        /// </summary>
        public UCFindPatient()
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Now;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            using (var context = new HospitalDbContext())
            {
                _users = context.Users.Include(x=>x.Position).Include(x=>x.Adress).ToList();
                
                
                if (tbFirstName.Text != String.Empty)
                {
                    _users = _users.Where(x => x.FirstName.ToLower() == tbFirstName.Text.ToLower().Trim()).ToList();
                }

                if (tbLastName.Text != String.Empty)
                {
                    _users = _users.Where(x => x.LastName.ToLower() == tbLastName.Text.ToLower().Trim()).ToList();
                }
                
                if (mtbPassportSeries.Text.Trim() != String.Empty && mtbPassportNumber.Text.Trim() != String.Empty)
                {
                    var passport = mtbPassportSeries.Text + mtbPassportNumber.Text;
                    _users = _users.Where(x => x.Passport.ToLower() == passport.ToLower().Trim()).ToList();
                }

                if (mtbInnNumber.Text.Trim() != String.Empty)
                {
                    _users = _users.Where(x => x.IdentificationNumber.ToLower() == tbLastName.Text.ToLower().Trim()).ToList();
                }

                _users = _users.OrderByDescending(x=>x.FirstName).ToList();
                AddToList();
            }
        }

        private void AddToList()
        {
            lvFind.Items.Clear();
            using (var context = new HospitalDbContext())
            {
                foreach (var user in _users)
                {
                    _items = new ListViewItem(user.FirstName);

                    //items.SubItems.Add(user.MiddleName);
                    _items.SubItems.Add(user.LastName);
                    //items.SubItems.Add(user.Birthday);
                    //items.SubItems.Add(user.Adress);
                    _items.SubItems.Add(user.Passport);
                    _items.SubItems.Add(user.IdentificationNumber);

                    lvFind.Items.Add(_items);
                }
            }
        }

        private void lvFind_DoubleClick(object sender, EventArgs e)
        {
            EditPatient();
        }

        private void btSignInPatient_Click(object sender, EventArgs e)
        {

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditPatient();
        }

        private void EditPatient()
        {
            var currentUser = _users.ElementAt(_items.ListView.FocusedItem.Index);
            EditPatient editPatient = new EditPatient(currentUser);
            if (editPatient.ShowDialog() == DialogResult.Yes)
            {
                AddToList();
            }
            
        }
    }
}
