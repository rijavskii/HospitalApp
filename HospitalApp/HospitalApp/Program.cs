using EntityDb.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb;
using EntityDb.DAL;


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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var repo = new BaseRepository<Manufacturer>();
            //var man = repo.Get(x => x.Country == "Country");
            //var anotherRepo = new BaseRepository<Users>();
            //var user = anotherRepo.Get(x => x.Id == 4).Include(x => x.Adress)
            //    .Include(x => x.Position).FirstOrDefault();

            //Pattern Repository

            Application.Run(new CoreForm());
        }
    }
}
