using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;
using HospitalApp.Enum;

namespace HospitalApp
{
    /// <summary>
    /// Allow sign patient to doctor 
    /// </summary>
    public partial class SignInToDoctor : Form
    {
        /// <summary>
        /// Main constructor
        /// </summary>
        public SignInToDoctor()
        {
            InitializeComponent();
            tbDocType.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbDocType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //FillTime();
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<Users> doctors;

            using (var context = new HospitalDbContext())
            {
                //ToDo Move "doctor" to enum
                 doctors = context.Users.Where(x => x.Position.PositionCode == (int)EPositions.Doctor).ToList();
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

        private readonly AutoCompleteStringCollection _collection = new AutoCompleteStringCollection();
        private void tbDocType_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

            if (tbDocType.Text.Length > 2)
            {
                this.tbDocType.AutoCompleteCustomSource = _collection;
            }

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
                a.SubItems.Add("Empty");
                a.SubItems.Add("Me");
                schedule = schedule.AddMinutes(30);
                
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lvDoctors.SelectedIndices.Count>0)
            {
                var date = dtpSignPatientDate.Value.ToShortDateString();

                using (var context = new HospitalDbContext())
                {

                    //Select focused Id doctor from list view, header with id not exist
                    int docId = Convert.ToInt32(lvDoctors.FocusedItem.SubItems[4]);
                    var concreteSchedule =
                        context.WorkSchedules.Where(x => x.Data.ToShortDateString() == date && x.Worker.Id == docId);
                    concreteSchedule = concreteSchedule.OrderBy(x => x.Data);

                    int workTime = 17;
                    DateTime schedule = DateTime.Today;
                    schedule = schedule.AddHours(9);

                    for (int i = 0; i < workTime; i++)
                    {
                        var a = lvSchedule.Items.Add(schedule.ToShortTimeString());
                        WorkSchedules signIn =
                            concreteSchedule.FirstOrDefault(
                                x => x.Data.ToShortDateString().ToString() == schedule.ToString());
                        string patient = $"{signIn?.Patient.LastName} {signIn?.Patient.FirstName}";
                        a.SubItems.Add(signIn == null ? "" : "busy");
                        a.SubItems.Add(patient);

                        schedule = schedule.AddMinutes(30);
                    }
                }
            }
        }
    }
}
