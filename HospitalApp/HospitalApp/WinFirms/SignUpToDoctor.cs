using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;
using HospitalApp.Enum;
using Microsoft.Win32;

namespace HospitalApp
{
    /// <summary>
    /// Allow sign patient to doctor 
    /// </summary>
    public partial class SignUpToDoctor : Form
    {
        private readonly int concreteUser;
        private readonly AutoCompleteStringCollection _collection = new AutoCompleteStringCollection();

        /// <summary>
        /// Main constructor
        /// </summary>
        public SignUpToDoctor(int patient)
        {
            InitializeComponent();

            concreteUser = patient;
            tbDocType.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbDocType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            dtpSignPatientDate.MinDate = DateTime.Today;
            //FillTime();
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<Users> doctors;

            using (var context = new HospitalDbContext())
            {
                //ToDo Move "doctor" to enum
                 doctors = context.Users.Where(x => x.Position.PositionCode == (int)EPositions.Doctor).Include(x=>x.Position.WorkerPositionType).ToList();
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
            if (!String.IsNullOrWhiteSpace(tbDocType.Text.Trim()))
            {
                doctors = doctors.FindAll(x => x.Position.WorkerPositionType.Name.ToLower().Trim() == tbDocType.Text.Trim().ToLower());
            }

            FillLvDoc(doctors);
        }

        private void FillLvDoc(List<Users> doctors)
        {
            foreach (var doc in doctors)
            {
                var concreteDoc = lvDoctors.Items.Add(doc.FirstName);
                concreteDoc.SubItems.Add(doc.LastName);
                concreteDoc.SubItems.Add(doc.Position.WorkerPositionType.Name);
                concreteDoc.SubItems.Add(doc.Position.WorkerPositionType.Room.ToString());
                concreteDoc.SubItems.Add(doc.Id.ToString());
            }
        }

        private void tbDocType_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

            this.tbDocType.AutoCompleteCustomSource = _collection;
            
            //allow take selected items in schedule list
            //var ac = lvSchedule.FocusedItem.SubItems[0].Text;
            //var cb = lvSchedule.FocusedItem.SubItems[1].Text;
            //var c = lvSchedule.FocusedItem.SubItems[2].Text;
        }

        private void SignInToDoctor_Load(object sender, EventArgs e)
        {
            using (var context = new HospitalDbContext())
            {
                var arr = context.Positions.ToList();
                string[] myArr = new string[arr.Count];

                int i = 0;

                foreach (var pos in arr)
                {
                    myArr[i++] = pos.Name;
                }

                _collection.AddRange(myArr);
            }

            
        }

        private void FillTime()
        {
            int workTime = 17;
            DateTime schedule = DateTime.Today;
            schedule = schedule.AddHours(9);
            
            for (int i = 0; i < workTime; i++)
            {
                var a = lvSchedule.Items.Add(schedule.ToShortTimeString());
                
                schedule = schedule.AddMinutes(30);
                
            }
            
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    lvSchedule.Items.Clear();
        //    if (lvDoctors.SelectedIndices.Count > 0)
        //    {
        //        var date = dtpSignPatientDate.Value;

        //        using (var context = new HospitalDbContext())
        //        {

        //            //Select focused Id doctor from list view, lvHeader with id not exist
        //            int docId = Convert.ToInt32(lvDoctors.FocusedItem.SubItems[4].Text);
        //            var concreteSchedule = context.WorkSchedules.Where(x => x.Worker.Id == docId);
        //            concreteSchedule = concreteSchedule.OrderBy(x => x.Data);

        //            int workTime = 17;
        //            DateTime schedule = dtpSignPatientDate.Value;

        //            schedule = schedule.AddHours(9);

        //            for (int i = 0; i < workTime; i++)
        //            {
        //                var a = lvSchedule.Items.Add(schedule.ToShortTimeString());
        //                WorkSchedules signIn =
        //                    context.WorkSchedules.Include(x => x.Worker).Include(x => x.Patient).FirstOrDefault(x => x.Worker.Id == docId
        //                                                            && x.Data.Year == date.Year
        //                                                            && x.Data.Month == date.Month
        //                                                            && x.Data.Day == date.Day
        //                                                            && x.Data.Hour == schedule.Hour
        //                                                            && x.Data.Minute == schedule.Minute);
        //                string patient = $"{signIn?.Patient.LastName} {signIn?.Patient.FirstName}";
        //                a.SubItems.Add(signIn == null ? "" : "busy");
        //                a.SubItems.Add(patient);

        //                schedule = schedule.AddMinutes(30);
        //            }
        //        }
        //    }
        //}

        private int SelectedDocId()
        {
            var size = lvDoctors.FocusedItem.SubItems.Count;
            //return last subitem in listview with id
            return Convert.ToInt32(lvDoctors.FocusedItem.SubItems[--size].Text);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var a = Registry.Users.GetSubKeyNames();

            using (var context = new HospitalDbContext())
            {
                var doc = SelectedDocId();
                //var patient = sender.GetType().GUID;
                var myData = Convert.ToDateTime(lvSchedule.FocusedItem.SubItems[0].Text);

                var data = dtpSignPatientDate.Value;
                data = data.AddHours(myData.Hour);
                data = data.AddMinutes(myData.Minute);

                var myDoc = context.Users.First(x => x.Id == doc);
                var myPatient = context.Users.First(x => x.Id == concreteUser);

                WorkSchedules currentSchedules = new WorkSchedules()
                {
                    Worker = myDoc,
                    Patient = myPatient,
                    Data = data,
                    WorkRoom = 105,
                };

                context.WorkSchedules.Add(currentSchedules);
                context.SaveChanges();
                var result =
                    $"\"{myPatient.FirstName} {myPatient.LastName}\" signed to \"{myDoc.Position.WorkerPositionType.Name}\"" +
                    $" {data.ToLongDateString()} {data.ToShortTimeString()}";

                MessageBox.Show(result,"Sign up", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void dtpSignPatientDate_ValueChanged(object sender, EventArgs e)
        {
            DocSchedule();
        }

        private void DocSchedule()
        {
            lvSchedule.Items.Clear();
            if (lvDoctors.SelectedIndices.Count <= 0) return;

            var date = dtpSignPatientDate.Value;

            using (var context = new HospitalDbContext())
            {
                //Select focused Id doctor from list view, lvHeader with id not exist
                int docId = Convert.ToInt32(lvDoctors.FocusedItem.SubItems[4].Text);

                int workTime = 17;
                DateTime schedule = dtpSignPatientDate.Value;

                schedule = schedule.AddHours(9);

                for (int i = 0; i < workTime; i++)
                {
                    WorkSchedules signIn =
                        context.WorkSchedules.Include(x => x.Worker).
                            Include(x => x.Patient).FirstOrDefault(x => x.Worker.Id == docId
                                                                        && x.Data.Year == date.Year
                                                                        && x.Data.Month == date.Month
                                                                        && x.Data.Day == date.Day
                                                                        && x.Data.Hour == schedule.Hour
                                                                        && x.Data.Minute == schedule.Minute);

                    string patient = $"{signIn?.Patient.LastName} {signIn?.Patient.FirstName}";

                    var time = new ListViewItem(schedule.ToShortTimeString());
                    time.SubItems.Add(signIn == null ? "" : "busy");
                    time.SubItems.Add(patient);
                    lvSchedule.Items.Add(time);

                    schedule = schedule.AddMinutes(30);
                }
            }
        }

        private void lvDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocSchedule();
        }

        private void lvSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSignUp.Enabled = true;
        }
    }
}
