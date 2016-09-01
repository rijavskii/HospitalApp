using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;

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
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<Users> doctors;
            using (var context = new HospitalDbContext())
            {
                 doctors = context.Users.Where(x => x.Position.Name.ToLower() == "doctor").ToList();
            }

            if (tbFirstName.Text.Trim() != String.Empty)
                {
                    doctors = doctors.FindAll(x => x.FirstName.ToLower().Trim() == tbFirstName.Text.Trim().ToLower());
                }
            if (tbMiddleName.Text.Trim() != String.Empty)
                {
                    doctors = doctors.FindAll(x => x.MiddleName.ToLower().Trim() == tbMiddleName.Text.Trim().ToLower());
                }
            if (tbLastName.Text.Trim() != String.Empty)
                {
                    doctors = doctors.FindAll(x => x.LastName.ToLower().Trim() == tbLastName.Text.Trim().ToLower());
                }
            //if (tb.Text.Trim() != String.Empty)
            //    {
            //        doctors = doctors.FindAll(x => x.MiddleName.ToLower().Trim() == tbMiddleName.Text.Trim().ToLower());
            //    }
        }

        private AutoCompleteStringCollection _collection = new AutoCompleteStringCollection();
        private void tbDocType_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

            var context = new HospitalDbContext();
            var arr = context.Positions.ToList();
            string[] myArr = new string[arr.Count];

            int i = 0;

            foreach (var pos in arr)
            {
                myArr[i++] = pos.Name;
            }
                 
            _collection.AddRange(myArr);
                
            this.tbDocType.AutoCompleteCustomSource = _collection;
           
        }

    }
}
