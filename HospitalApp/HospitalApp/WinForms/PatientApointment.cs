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

namespace HospitalApp.WinFirms
{
    public partial class PatientApointment : Form
    {
        public readonly int _docId;
        public PatientApointment(int docId)
        {
            InitializeComponent();
            _docId = docId;
            dtpSignPatientDate.MinDate = DateTime.Today;
            dtpBirthday.MaxDate = DateTime.Today;
        }

        

        private void dtpSignPatientDate_ValueChanged(object sender, EventArgs e) => DocSchedule();

        private void PatientApointment_Load(object sender, EventArgs e) => DocSchedule();

        private void DocSchedule()
        {
            lvSchedule.Items.Clear();
            //Use .Any not Count
           
            var date = dtpSignPatientDate.Value;

            using (var context = new HospitalDbContext())
            {
                //why static data?
                //int workTime = 17;
                DateTime schedule = dtpSignPatientDate.Value;

                schedule = schedule.AddHours(9);

                while (true)
                {
                    WorkSchedules signIn =
                        context.WorkSchedules.Include(x => x.Worker).
                            Include(x => x.Patient).FirstOrDefault(x => x.Worker.Id == _docId
                                                                        && x.Data.Year == date.Year
                                                                        && x.Data.Month == date.Month
                                                                        && x.Data.Day == date.Day
                                                                        && x.Data.Hour == schedule.Hour
                                                                        && x.Data.Minute == schedule.Minute);

                    string patient = $"{signIn?.Patient.LastName} {signIn?.Patient.FirstName}";

                    var time = new ListViewItem(schedule.ToShortTimeString());
                    //time.SubItems.Add(signIn == null ? "" : "busy");
                    time.SubItems.Add(patient);
                    lvSchedule.Items.Add(time);

                    schedule = schedule.AddMinutes(30);

                    // repeat till 17 o clock will come
                    if (schedule.Hour > 16 && schedule.Minute > 0) break;
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var context = new HospitalDbContext())
            {
                List<Users> patients = context.Users.Where(x => x.IsPatient).ToList();
                if (!String.IsNullOrWhiteSpace(tbFirstName.Text))
                    patients = patients.FindAll(x => x.FirstName == tbFirstName.Text.Trim());
                if (!String.IsNullOrWhiteSpace(tbMiddleName.Text))
                    patients = patients.FindAll(x => x.MiddleName == tbMiddleName.Text.Trim());
                if (!String.IsNullOrWhiteSpace(tbLastName.Text))
                    patients = patients.FindAll(x => x.LastName == tbLastName.Text.Trim());

                patients = patients.FindAll(x => x.Birthday.Year == dtpBirthday.Value.Year
                                                 && x.Birthday.Month == dtpBirthday.Value.Month
                                                 && x.Birthday.Day == dtpBirthday.Value.Day
                    );
                FillListPatients(patients);
            }
        }

        private void FillListPatients(List<Users> users)
        {
            lvPatients.Items.Clear();
            foreach (var patient in users)
            {
                var item = new ListViewItem(patient.Id.ToString());
                item.SubItems.Add(patient.FirstName);
                item.SubItems.Add(patient.MiddleName);
                item.SubItems.Add(patient.LastName);

                lvPatients.Items.Add(item);

            }
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            using (var context = new HospitalDbContext())
            {
                var myData = Convert.ToDateTime(lvSchedule.FocusedItem.SubItems[chTime.Index].Text);

                var data = dtpSignPatientDate.Value;
                data = data.AddHours(myData.Hour);
                data = data.AddMinutes(myData.Minute);

                var worker = context.Users.Include(x=>x.Adress).Include(x=>x.Position.WorkerPositionType).FirstOrDefault(x => x.Id == _docId);
                var patientId =int.Parse(lvPatients.FocusedItem.SubItems[chId.Index].Text);

                var patient = context.Users.Include(x => x.Adress).Include(x => x.Position.WorkerPositionType).FirstOrDefault(x => x.Id == patientId);
                if (worker != null)
                    context.WorkSchedules.Add(new WorkSchedules()
                    {
                        Data = data,
                        Patient = patient,
                        Worker = worker,
                        WorkRoom = worker.Position.WorkerPositionType.Room
                    });
                await context.SaveChangesAsync();
            }
            Close();
        }
    }
    
}
