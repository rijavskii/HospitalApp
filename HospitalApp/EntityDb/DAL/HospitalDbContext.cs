using System.Data.Entity;
using EntityDb.Context;

namespace EntityDb.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class HospitalDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public HospitalDbContext() : base("hospitalDb")
        {
            //Set db initializer for default value of dictionary on create db
            Database.SetInitializer<HospitalDbContext>(new HospitalDbInitializer());
            Database.Initialize(true);
        }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Users> Users{ get; set;}

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Positions> Positions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<WorkSchedules> WorkSchedules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Adresses> Adresses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ContactInfo> ContactInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ContactType> ContactType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<CardPatient> CardPatient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Record> Records { get; set; }
       
    }
}
