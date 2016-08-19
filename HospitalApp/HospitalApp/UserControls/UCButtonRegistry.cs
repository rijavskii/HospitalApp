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
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'UCButtonRegistry'
    public partial class UCButtonRegistry : UserControl
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'UCButtonRegistry'
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'UCButtonRegistry.UCButtonRegistry()'
        public UCButtonRegistry()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'UCButtonRegistry.UCButtonRegistry()'
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
