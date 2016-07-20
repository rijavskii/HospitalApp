using System.Data.Entity;
using HospitalApp.Context;

namespace HospitalApp.DAL
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext (): base("hospitalDb")
        {
            //Set db initializer for default value of dictionary on create db
            Database.SetInitializer<HospitalDbContext>(new HospitalDbInitializer());
        }

        public DbSet<Users> Users{ get; set;}
        public DbSet<Positions> Positions { get; set; }
        public DbSet<WorkSchedules> WorkSchedules { get; set; }
        public DbSet<Adresses> Adresses { get; set; }
        //public DbSet<ContactInfo> ContactInfo { get; set; }
        //public DbSet<ContactType> ContactType { get; set; }
        //public DbSet<CardPatient> CardPatient { get; set; }
        public DbSet<Records> Records { get; set; }
       // public DbSet<Records> Records { get; set; }
         



    }
}
