using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'UCButtonDoctor'
    public partial class UCButtonDoctor : UserControl
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'UCButtonDoctor'
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'UCButtonDoctor.UCButtonDoctor()'
        public UCButtonDoctor()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'UCButtonDoctor.UCButtonDoctor()'
        {
            InitializeComponent();
        }

        private void UCButtonDoctor_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
