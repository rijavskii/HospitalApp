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
    public partial class ProgressBar : Form
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


        public void UpdateProgress()
        {
            var percent = _fileInfo.Length/100;


        }
    }
}
