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
    public partial class UCFindPatient : UserControl
    {
        /// <summary>
        /// Controller which allow to find users in database
        /// </summary>
        public UCFindPatient()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var context = new HospitalDbContext())
            {
                List<Users> findedUsers = context.Users.ToList();
                string query=null;
                if (tbFirstName.Text != String.Empty)
                {
                    findedUsers = findedUsers.Where(x => x.FirstName.ToLower() == tbFirstName.Text.ToLower().Trim()).ToList();
                }

                if (tbLastName.Text != String.Empty)
                {
                    findedUsers = findedUsers.Where(x => x.LastName.ToLower() == tbLastName.Text.ToLower().Trim()).ToList();
                }

                if (tbPassportNumber.Text != String.Empty)
                {
                    findedUsers = findedUsers.Where(x => x.Passport.ToLower() == tbPassportNumber.Text.ToLower().Trim()).ToList();
                }

                if (tbInnNumber.Text != String.Empty)
                {
                    findedUsers = findedUsers.Where(x => x.IdentificationNumber.ToLower() == tbLastName.Text.ToLower().Trim()).ToList();
                }
            
            
                var repo = new BaseRepository<Users>();
                //var patients = context.Users.Where(x => x.FirstName.Trim().ToLower() == tbFirstName.Text.Trim().ToLower() &&
                //                                        x.LastName.Trim().ToLower() == tbLastName.Text.Trim().ToLower()&&
                //                                        x.Passport.Trim().ToLower() == tbPassportNumber.Text.Trim().ToLower()&&
                //                                        x.IdentificationNumber.ToLower() == tbInnNumber.Text.Trim().ToLower()).ToList();
                //repo.Get(x => x.FirstName == tbFirstName.Text).FirstOrDefault();

                findedUsers = findedUsers.OrderByDescending(x=>x.FirstName).ToList();
                AddToList(findedUsers);
            }

            
            
        }

        private void AddToList(List<Users> users)
        {
            lvFind.Items.Clear();
            using (var context = new HospitalDbContext())
            {
                foreach (var user in users)
                {
                    var items = new ListViewItem(user.FirstName);

                    //items.SubItems.Add(user.MiddleName);
                    items.SubItems.Add(user.LastName);
                    //items.SubItems.Add(user.Birthday);
                    //items.SubItems.Add(user.Adress);
                    items.SubItems.Add(user.Passport);
                    items.SubItems.Add(user.IdentificationNumber);

                    lvFind.Items.Add(items);
                }
            }
        }
    }
}
