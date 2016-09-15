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
using EntityDb;
using EntityDb.Context;
using EntityDb.DAL;
using HospitalApp.Enum;
using HospitalApp.UserControls;

namespace HospitalApp
{
    
    /// <summary>
    /// User Controller with doctor buttons
    /// </summary>
    public partial class UcButtonDoctor : UserControl
    {
        private readonly Panel _panel;
        private int doctor;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="panel"></param>
        public UcButtonDoctor(Panel panel, int docId=0)
        {
            //TODO Check if doctor. If true return id doctor, else show dialog to choose doctor if admin
            //CheckIfDoctor(docId);
            doctor = CheckDoctor(docId);
            if (doctor > 0)
            {
                InitializeComponent();

                _panel = panel;

                btnSchedule.PerformClick();
            }
            //var me = this.ParentForm.FindForm();
            //var me = ParentForm.Owner.GetType();
        }


        private int CheckDoctor(int docId)
        {
            using (var context = new HospitalDbContext())
            {
                Users user = context.Users.Include(x=>x.Position).First(x => x.Id == docId);

                switch ((EPositions)user.Position.PositionCode)
                {
                        case EPositions.Doctor:
                            return user.Id;
                            //break;
                        case EPositions.Admin:
                            var doc = new SearchDoctor();
                            if (doc.ShowDialog() == DialogResult.OK)
                            {
                               return doc.GetDoctor();
                            }
                        return 0;
                        
                    default:
                        return 0;
                }
            }
        } 
        private void btListMedicine_Click(object sender, EventArgs e)
        {
            _panel.Controls.Clear();
            _panel.Controls.Add(new UcListMedicine());
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            _panel.Controls.Clear();
            _panel.Controls.Add(new UcDoctorSchedule(doctor));
        }
    }
}
