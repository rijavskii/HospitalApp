using EntityDb.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using EntityDb.DAL;
using HospitalApp.Enum;
using HospitalApp.UserControls;

namespace HospitalApp
{
    /// <summary>
    /// Main application form
    /// </summary>
    public partial class CoreForm : Form
    {
        /// <summary>
        /// Authorized user
        /// </summary>
        // store user id in hidden field, and read it from db when it`s needed 
        private readonly Users _myUser;

        ///// <summary>
        ///// 
        ///// </summary>
        ////private UCButtonDoctor ucButtonDoctor = new UCButtonDoctor();
        
        /// <summary>
        /// Creates main program form
        /// </summary>
        public CoreForm()
        {
            Authorization newAuth = new Authorization();
            newAuth.ShowDialog();
            _myUser = newAuth._user;
            //InitializeComponent();
            if (_myUser != null)
            {
                InitializeComponent();
                LoadControls();
            }
            //scContent.Panel2.Controls.Add(new UCDoctors());
            //var d = scContent.Parent.Size;

        }

        private void LoadControls()
        {
            EPositions position;
            using (var context = new HospitalDbContext())
            {
                //Check for null
                var firstOrDefault = context.Users.Include(x=>x.Position).FirstOrDefault(x => x.Id == _myUser.Id);
                if (firstOrDefault != null)
                    position = (EPositions) firstOrDefault.Position.PositionCode;
                else return;
            }
            switch (position)
            {
                case EPositions.Admin:
                    scContent.Panel1.Controls.Clear();
                    scContent.Panel1.Controls.Add(new UcButtonAdmin(scContent.Panel2, _myUser.Id));
                    break;
                     
                case EPositions.Doctor:
                    scContent.Panel1.Controls.Clear();
                    scContent.Panel1.Controls.Add(new UcButtonDoctor(scContent.Panel2, _myUser.Id));
                    break;

                case EPositions.Nurse:
                    scContent.Panel1.Controls.Clear();
                    scContent.Panel1.Controls.Add(new UcButtonNurse());
                    break;

                case EPositions.Registry:
                    scContent.Panel1.Controls.Clear();
                    scContent.Panel1.Controls.Add(new UcButtonRegistry(scContent.Panel2));
                    break;

                //case EPositions.None:
                //    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }



        /// <summary>
        /// Closing main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // about
            var about = new AboutHospitalApp();
            about.ShowDialog();
        }
    }
}
