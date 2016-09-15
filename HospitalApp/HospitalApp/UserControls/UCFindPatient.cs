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
        //ToDo remove global variables. Use only local
        
        private List<Users> _users;

        /// <summary>
        /// Controller which allow to find users in database
        /// </summary>
        public UcFindPatient()
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Today;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            using (var context = new HospitalDbContext())
            {
                _users = context.Users.Where(x=>x.IsPatient).Include(x=>x.Position).Include(x=>x.Adress).ToList();
                //_users = context.Users.Where(x=>x.IsPatient).Include(x=>x.Position).Include(x=>x.Adress).ToList();
                
                //ToDo write extension method for string, that will be check it or use String.IsNullOrEmpty
                if (!String.IsNullOrWhiteSpace(tbFirstName.Text))
                {
                    _users = _users.Where(x => x.FirstName.ToLower() == tbFirstName.Text.ToLower().Trim()).ToList();
                }

                if (!String.IsNullOrWhiteSpace(tbLastName.Text))
                {
                    _users = _users.Where(x => x.LastName.ToLower() == tbLastName.Text.ToLower().Trim()).ToList();
                }
                
                if (!String.IsNullOrWhiteSpace(mtbPassportSeries.Text) && String.IsNullOrWhiteSpace(mtbPassportNumber.Text))
                {
                    var passport = mtbPassportSeries.Text + mtbPassportNumber.Text;
                    _users = _users.Where(x => x.Passport.ToLower() == passport.ToLower().Trim()).ToList();
                }

                if (!String.IsNullOrWhiteSpace(mtbInnNumber.Text))
                {
                    _users = _users.Where(x => x.IdentificationNumber.ToLower() == tbLastName.Text.ToLower().Trim()).ToList();
                }
                _users = _users.Where(x => x.Birthday.Year == dtpBirthday.Value.Year
                                        && x.Birthday.Month == dtpBirthday.Value.Month
                                        && x.Birthday.Day == dtpBirthday.Value.Day).ToList();

                _users = _users.OrderByDescending(x=>x.FirstName).ToList();
                AddToList();
                
            }
        }

        private bool IfSelectedLvItem()
        {
            bool result = lvPatients.SelectedIndices.Count>0;
            return result;
        }

        private void AddToList()
        {
            lvPatients.Items.Clear();
            
            foreach (var user in _users)
            {
                if (user.IsPatient)
                {
                    string adress =
                        $"{user.Adress.Country} {user.Adress.District} {user.Adress.Region} " +
                        $"{user.Adress.City} {Environment.NewLine} {user.Adress.HouseNumber} " +
                        $"{user.Adress.Appartment}";

                    var items = new ListViewItem(user.FirstName);
                    items.SubItems.Add(user.MiddleName);
                    items.SubItems.Add(user.LastName);
                    items.SubItems.Add(user.Birthday.ToShortDateString());
                    items.SubItems.Add(adress);
                    items.SubItems.Add(user.Passport);
                    items.SubItems.Add(user.IdentificationNumber);
                    items.SubItems.Add(user.Id.ToString());

                    lvPatients.Items.Add(items);
                }
            }
            
        }

        private void lvFind_DoubleClick(object sender, EventArgs e)
        {
            EditPatient();
        }

        private void btSignInPatient_Click(object sender, EventArgs e)
        {
            var signToDoc = new SignUpToDoctor(Convert.ToInt32(lvPatients.FocusedItem.SubItems[7].Text));
            signToDoc.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditPatient();
        }

        private void EditPatient()
        {
            //ToDo You can set up selection properties in properties of control and multiple selection will be denied

            var currentUser = _users.ElementAt(lvPatients.FocusedItem.Index);
            EditPatient editPatient = new EditPatient(currentUser);
            if (editPatient.ShowDialog() == DialogResult.Yes)
            {
                var context = new HospitalDbContext();
                _users = context.Users.ToList();
                AddToList();
            }
        }

        private void lvPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            var b = IfSelectedLvItem() ? btnSignUpPatient.Enabled = true : btnSignUpPatient.Enabled = false;
            var c = IfSelectedLvItem() ? btnEdit.Enabled = true : btnEdit.Enabled = false;
        }

    }
}
