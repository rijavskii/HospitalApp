using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp.UserControls
{
    public partial class UcDoctorSchedule : UserControl
    {
        private readonly int currentDoctor;
        public UcDoctorSchedule(int userId = 0)
        {
            if (userId != 0)
            {
                InitializeComponent();
                currentDoctor = userId;
                dtpAppointmentTime.MinDate = DateTime.Today;
                FillLvSchedule(DateTime.Today);
            }
            else
                MessageBox.Show("Doctor do not work in the hospital", "Info", MessageBoxButtons.OK);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillLvSchedule(dtpAppointmentTime.Value);
        }

        private void FillLvSchedule(DateTime date)
        {
            lblDayOfWeek.Text = dtpAppointmentTime.Value.DayOfWeek.ToString();

            var workingDate = date;
            //ToDo if needed replase this to app.config
            int workTime = 17;

            lvAppointment.Items.Clear();
            DateTime schedule = dtpAppointmentTime.Value;

            schedule = schedule.AddHours(9);
            using (var context = new HospitalDbContext())
            {
                for (int i = 0; i < workTime; i++)
                {
                    
                    WorkSchedules signIn =
                        context.WorkSchedules.Include(x=>x.Worker).Include(x=>x.Patient).
                                            FirstOrDefault(x => x.Worker.Id == currentDoctor
                                                                        && x.Data.Year == workingDate.Year
                                                                        && x.Data.Month == workingDate.Month
                                                                        && x.Data.Day == workingDate.Day
                                                                        && x.Data.Hour == schedule.Hour
                                                                        && x.Data.Minute == schedule.Minute);

                    string patient = $"{signIn?.Patient.LastName} {signIn?.Patient.FirstName}";

                    var time = new ListViewItem(schedule.ToShortTimeString());
                    //time.SubItems.Add(signIn == null ? "" : "busy");
                    time.SubItems.Add(patient);
                    time.SubItems.Add(signIn?.Patient.Id.ToString());
                    lvAppointment.Items.Add(time);

                    schedule = schedule.AddMinutes(30);
                }
            }
        }

        private void btnPatientCard_Click(object sender, EventArgs e)
        {
            var patient = new PatientCard();

            patient.ShowDialog();
        }


    }
}
