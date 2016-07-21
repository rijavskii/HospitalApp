using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalApp.Context;
using HospitalApp.DAL;

namespace HospitalApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new HospitalDbContext())
            {
                ICollection<Positions> defaultPositions = new List<Positions>();

                defaultPositions.Add(new Positions() { PositionName = "Undefined" });
                defaultPositions.Add(new Positions() { PositionName = "Doctor" });
                defaultPositions.Add(new Positions() { PositionName = "Nurse" });

                foreach (var value in defaultPositions)
                {
                    context.Positions.Add(value);

                }
                context.SaveChanges();
                
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CoreForm());
        }
    }
}
