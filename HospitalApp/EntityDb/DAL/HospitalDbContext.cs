using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Windows.Forms;
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
            try
            {
                Database.Initialize(true);
            }
            catch (DbEntityValidationException a)
            {
                foreach (var eve in a.EntityValidationErrors)
                {
                    MessageBox.Show("Entity of type \"" + eve.Entry.Entity.GetType().Name +
                                    "\" in state \"" + eve.Entry.State + "\" has the following validation errors:",
                        "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show("- Property: \"" + ve.PropertyName + "\", Error: \"" + ve.ErrorMessage + "\"",
                            "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasKey(x => x.Id);
            //modelBuilder.Entity<Users>().HasRequired(x => x.Adress).WithOptional(y => y.Users);
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

        /// <summary>
        /// View for Medicines
        /// </summary>
        public DbSet<Manufacturer> Manufacturers { get; set; }

        /// <summary>
        /// View for Medicines
        /// </summary>
        public DbSet<MedicineType> MedicineType { get; set; }
        
        /// <summary>
        /// View for Medicines
        /// </summary>
        public DbSet<PositionType> PositionTypes { get; set; }

    }
}
