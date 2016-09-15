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
using EntityDb.Context;
using EntityDb.DAL;
using HospitalApp.Enum;

namespace HospitalApp.UserControls
{
    public partial class UcFindWorker : UserControl
    {
        public UcFindWorker()
        {
            InitializeComponent();
            FillCbPositions();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            using (var context = new HospitalDbContext())
            {
                var users = context.Users.Include(x => x.Position).Include(x => x.Adress).Include(x=>x.Position.WorkerPositionType).ToList();
                //_users = context.Users.Where(x=>x.IsPatient).Include(x=>x.Position).Include(x=>x.Adress).ToList();

                if (!String.IsNullOrWhiteSpace(tbFirstName.Text))
                {
                    users = users.Where(x => x.FirstName.ToLower() == tbFirstName.Text.ToLower().Trim()).ToList();
                }

                if (!String.IsNullOrWhiteSpace(tbLastName.Text))
                {
                    users = users.Where(x => x.LastName.ToLower() == tbLastName.Text.ToLower().Trim()).ToList();
                }

                users = users.Where(x => x.Position.PositionCode == ToPositionEnum(cbPositions.Text)).ToList();
                
                users = users.OrderByDescending(x => x.FirstName).ToList();
                
                AddToList(users);
            }
        }


        private int ToPositionEnum(string textToEnum)
        {
            //Update with other positions
            switch (textToEnum)
            {
                //ToDo Use parse to enum, not switch
                case "Doctor":
                    return (int)EPositions.Doctor;
                case "Registry":
                    return (int)EPositions.Registry;
                //case "None":
                //    return (int)EPositions.None;
                case "Nurse":
                    return (int)EPositions.Nurse;
                //default:
                //    return (int)EPositions.None;
            }

            return 0;
        }

        private void AddToList(List<Users> users )
        {
            lvFind.Items.Clear();
            
            foreach (var user in users)
            {

                var items = new ListViewItem(user.FirstName);
                items.SubItems.Add(user.MiddleName);
                items.SubItems.Add(user.LastName);
                items.SubItems.Add(user.Position.Name);
                items.SubItems.Add(user.Position.WorkerPositionType?.Name ?? "");
                items.SubItems.Add(user.Position.WorkerPositionType?.Room.ToString() ?? "");
                items.SubItems.Add(user.Id.ToString());

                lvFind.Items.Add(items);
            }

        }

        private void FillCbPositions()
        {
            foreach (string pos in GetDataSourceTypes() )
            {
                if(pos.ToLower() != "admin")
                    cbPositions.Items.Add(pos);
            }
            cbPositions.SelectedIndex = 0;
        }

        public List<string> GetDataSourceTypes()
        {
            return System.Enum.GetNames(typeof(EPositions)).ToList();
        }

        private void btnRemoveWorker_Click(object sender, EventArgs e)
        {
            if (lvFind.SelectedIndices.Count>0)
            {
                
                var subitemCount = lvFind.FocusedItem.SubItems.Count;
                var userId = Convert.ToInt32(lvFind.FocusedItem.SubItems[subitemCount - 1].Text);

                var delete = MessageBox.Show("Are you realy want to delete? ", "Confirmation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Hand);
                if (delete == DialogResult.OK)
                {
                    using (var context = new HospitalDbContext())
                    {
                        context.Users.Remove(context.Users.Find(userId));
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
