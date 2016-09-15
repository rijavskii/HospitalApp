using System;
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
using HospitalApp.Enum;

namespace HospitalApp
{
    public partial class SearchDoctor : Form
    {
        //ToDO why public not private?
        public int doctorId;
        public SearchDoctor()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<Users> doctors;
            lvDoctors.Items.Clear();

            using (var context = new HospitalDbContext())
            {
                doctors = context.Users.Where(x => x.Position.PositionCode == (int)EPositions.Doctor).Include(x => x.Position.WorkerPositionType).ToList();
            }
            if (!String.IsNullOrWhiteSpace(tbFirstName.Text.Trim()))
            {
                doctors = doctors.FindAll(x => x.FirstName.ToLower().Trim() == tbFirstName.Text.Trim().ToLower());
            }
            if (!String.IsNullOrWhiteSpace(tbMiddleName.Text.Trim()))
            {
                doctors = doctors.FindAll(x => x.MiddleName.ToLower().Trim() == tbMiddleName.Text.Trim().ToLower());
            }
            if (!String.IsNullOrWhiteSpace(tbLastName.Text.Trim()))
            {
                doctors = doctors.FindAll(x => x.LastName.ToLower().Trim() == tbLastName.Text.Trim().ToLower());
            }
            

            FillLvDoc(doctors);
        }

        public void FillLvDoc(List<Users> doctors)
        {
            foreach (var doc in doctors)
            {
                var concreteDoc = new ListViewItem(doc.FirstName);
                concreteDoc.SubItems.Add(doc.LastName);
                concreteDoc.SubItems.Add(doc.Position.WorkerPositionType.Name);
                concreteDoc.SubItems.Add(doc.Position.WorkerPositionType.Room.ToString());
                concreteDoc.SubItems.Add(doc.Id.ToString());

                lvDoctors.Items.Add(concreteDoc);
            }
        }

        private void lvDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var size = lvDoctors.FocusedItem.SubItems.Count-1;
            //ToDo use new variable with lvDoctors.FocusedItem.SubItems[size].Text
            //because you two times read this data
            if (String.IsNullOrWhiteSpace(lvDoctors.FocusedItem.SubItems[size].Text)) return;

            var userId = Convert.ToInt32(lvDoctors.FocusedItem.SubItems[size].Text);
            using (var context = new HospitalDbContext())
            {
                var myDoc = context.Users.Include(x=>x.Position.WorkerPositionType).First(x => x.Id == userId);
                FillUserInfo(myDoc);
                gbWorkerInfo.Visible = true;

                btnChoose.Enabled = true;

            }
        }

        private void FillUserInfo(Users user)
        {
            this.tbDocFirstName.Text = user.FirstName;
            tbDocMiddleName.Text = user.MiddleName;
            tbDocLastName.Text = user.LastName;
            dtpBirthday.Value = user.Birthday;

            mtbInnNumber.Text = user.IdentificationNumber;
            tbPositionsType.Text = user.Position.WorkerPositionType.Name;
            tbRoom.Text = user.Position.WorkerPositionType.Room.ToString();
            mtbPassportSeries.Text =  user.Passport.Substring(0, 3);
            mtbPassportNumber.Text = user.Passport.Substring(3);

        }

        public int GetDoctor()
        {
            return doctorId;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            doctorId = Convert.ToInt32(lvDoctors.FocusedItem.SubItems[(lvDoctors.FocusedItem.SubItems.Count)- 1].Text);
            this.DialogResult=DialogResult.OK;
        }
    }
}
