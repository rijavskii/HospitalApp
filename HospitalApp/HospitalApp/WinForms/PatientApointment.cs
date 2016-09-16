using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.WinFirms
{
    public partial class PatientApointment : Form
    {
        public readonly int _docId;
        public PatientApointment(int docId)
        {
            InitializeComponent();
            _docId = docId;
        }

        private void lvDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpSignPatientDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PatientApointment_Load(object sender, EventArgs e)
        {

        }
    }
}
