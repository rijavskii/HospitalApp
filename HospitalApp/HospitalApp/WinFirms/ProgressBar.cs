using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProgressBar'
    public partial class ProgressBar : Form
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProgressBar'
    {
        private string _myFile;

        private FileInfo _fileInfo;

        /// <summary>
        /// Show result of loading or saving file
        /// </summary>
        /// <param name="fileName"></param>
        public ProgressBar(string fileName)
        {
            _myFile = fileName;
            _fileInfo = new FileInfo(_myFile);
            InitializeComponent();
        }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProgressBar.UpdateProgress()'
        public void UpdateProgress()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProgressBar.UpdateProgress()'
        {
            var percent = _fileInfo.Length/100;


        }
    }
}
