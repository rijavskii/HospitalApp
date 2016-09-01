using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp
{
    /// <summary>
    /// Control to search patient in database
    /// </summary>
    public partial class UcFindPatient : UserControl
    {
        private ListViewItem _items;
        private List<Users> _users;
        /// <summary>
        /// Controller which allow to find users in database
        /// </summary>
        public UcFindPatient()
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Now;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            using (var context = new HospitalDbContext())
            {
                _users = context.Users.Include(x=>x.Position).Include(x=>x.Adress).ToList();
                //_users = context.Users.Where(x=>x.IsPatient).Include(x=>x.Position).Include(x=>x.Adress).ToList();
                
                
                if (tbFirstName.Text.Trim() != String.Empty)
                {
                    _users = _users.Where(x => x.FirstName.ToLower() == tbFirstName.Text.ToLower().Trim()).ToList();
                }

                if (tbLastName.Text.Trim() != String.Empty)
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
            string adress;
            using (var context = new HospitalDbContext())
            {
                foreach (var user in _users)
                {

                    adress = user.Adress.Country + ", " + user.Adress.District + ", " + user.Adress.Region + ", " + user.Adress.City + ", " +
                             user.Adress.Street + ", " + user.Adress.HouseNumber + ", " + user.Adress.Appartment;
                    _items = new ListViewItem(user.FirstName);

                    _items.SubItems.Add(user.MiddleName);
                    _items.SubItems.Add(user.LastName);
                    _items.SubItems.Add(user.Birthday.ToShortDateString());
                    _items.SubItems.Add(adress);
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
            var signToDoc = new SignInToDoctor();
            if (signToDoc.ShowDialog() == DialogResult.OK)
            {
                
            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditPatient();
        }

        private void EditPatient()
        {
            int size = lvFind.SelectedItems.Count;

            if (size == 1)
            {
                var currentUser = _users.ElementAt(_items.ListView.FocusedItem.Index);
                EditPatient editPatient = new EditPatient(currentUser);
                if (editPatient.ShowDialog() == DialogResult.Yes)
                {
                    var context = new HospitalDbContext();
                    _users = context.Users.ToList();
                    AddToList();
                }
            }

        }
    }
}
