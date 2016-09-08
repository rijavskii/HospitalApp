using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp
{
    
    /// <summary>
    /// User Controller with doctor buttons
    /// </summary>
    public partial class UcButtonDoctor : UserControl
    {
        private readonly Panel _panel;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="panel"></param>
        public UcButtonDoctor(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
        }

        private void btListMedicine_Click(object sender, EventArgs e)
        {
            _panel.Controls.Clear();
            _panel.Controls.Add(new UcListMedicine());
        }
    }
}
