using System.Data.Entity;
using EntityDb.Context;

namespace EntityDb.DAL
{
    /// <summary>
    /// Connecting to Database
    /// </summary>
    public class HospitalDbContext : DbContext
    {
        /// <summary>
        /// Constructor which create our Database
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
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasRequired(x => x.Adress).WithOptional(y => y.Users);
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// View for Users Table
        /// </summary>
        public DbSet<Users> Users{ get; set;}

        /// <summary>
        /// View for Positions
        /// </summary>
        public DbSet<Positions> Positions { get; set; }

        /// <summary>
        /// View for WorkSchedules
        /// </summary>
        public DbSet<WorkSchedules> WorkSchedules { get; set; }

        /// <summary>
        /// View for Adresses 
        /// </summary>
        public DbSet<Adresses> Adresses { get; set; }

        /// <summary>
        /// View for ContactInfo
        /// </summary>
        public DbSet<ContactInfo> ContactInfo { get; set; }

        /// <summary>
        /// View for CardPatient
        /// </summary>
        public DbSet<CardPatient> CardPatient { get; set; }

        /// <summary>
        /// View for Records
        /// </summary>
        public DbSet<Record> Records { get; set; }

        /// <summary>
        /// View for Medicines
        /// </summary>
        public DbSet<Medicine> Medicines { get; set; }
    }
}
