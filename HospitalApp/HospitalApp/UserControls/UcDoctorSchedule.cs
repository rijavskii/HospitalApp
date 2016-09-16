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
using HospitalApp.WinFirms;

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
            // if needed replase this to app.config
            //int workTime = 17;

            lvAppointment.Items.Clear();
            DateTime schedule = dtpAppointmentTime.Value;

            schedule = schedule.AddHours(9);
            using (var context = new HospitalDbContext())
            {
                while (true)
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

                    //repeat till 17:00 o clock
                    if (schedule.Hour > 16 && schedule.Minute > 0) break;
                }
            }
        }

        private void btnPatientCard_Click(object sender, EventArgs e)
        {
            var patientId = lvAppointment.FocusedItem.SubItems[chPatient.Index + 1].Text;

            if (!string.IsNullOrEmpty(patientId))
            {
                var patient = new PatientCard(Int32.Parse(patientId));

                patient.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"You need to choose a record", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var appointment = new PatientApointment(currentDoctor);

            appointment.ShowDialog();
        }
    }


    
}
