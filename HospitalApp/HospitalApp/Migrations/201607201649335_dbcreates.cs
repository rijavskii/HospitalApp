namespace HospitalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcreates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(nullable: false),
                        District = c.String(nullable: false),
                        Region = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        HouseNumber = c.String(nullable: false),
                        Appartment = c.Int(nullable: false),
                        IdUser = c.Int(nullable: false),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Patient = c.Boolean(nullable: false),
                        Passport = c.String(nullable: false),
                        IdentificationNumber = c.Int(nullable: false),
                        Adress = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        Positions_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Positions", t => t.Positions_Id)
                .Index(t => t.Positions_Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PositionName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CardPatients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FkUserRecords = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdDoctor = c.Int(nullable: false),
                        IdPatient = c.Int(nullable: false),
                        RecordDate = c.DateTime(nullable: false),
                        DischargeDate = c.DateTime(nullable: false),
                        AdditionalInfo = c.String(),
                        FkDisease = c.Int(nullable: false),
                        FkMedicine = c.Int(nullable: false),
                        CardPatient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CardPatients", t => t.CardPatient_Id)
                .Index(t => t.CardPatient_Id);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPatient = c.Int(nullable: false),
                        DiseaseName = c.String(),
                        Treatment = c.String(),
                        Record_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Records", t => t.Record_Id)
                .Index(t => t.Record_Id);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Manufacturer_Id = c.Int(),
                        MedicineType_Id = c.Int(),
                        Record_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.MedicineTypes", t => t.MedicineType_Id)
                .ForeignKey("dbo.Records", t => t.Record_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.MedicineType_Id)
                .Index(t => t.Record_Id);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FactoryName = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MedicineTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FkIdUser = c.Int(nullable: false),
                        FkContactType = c.Int(nullable: false),
                        Contact = c.String(),
                        Default = c.Boolean(nullable: false),
                        IdUser_Id = c.Int(),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.IdUser_Id)
                .ForeignKey("dbo.ContactTypes", t => t.Type_Id)
                .Index(t => t.IdUser_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.ContactTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkSchedules",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        IdDoctor = c.Int(nullable: false),
                        WorkRoom = c.Int(nullable: false),
                        StartWork = c.DateTime(nullable: false),
                        EndWork = c.DateTime(nullable: false),
                        IdUser = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkSchedules", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ContactInfoes", "Type_Id", "dbo.ContactTypes");
            DropForeignKey("dbo.ContactInfoes", "IdUser_Id", "dbo.Users");
            DropForeignKey("dbo.Records", "CardPatient_Id", "dbo.CardPatients");
            DropForeignKey("dbo.Medicines", "Record_Id", "dbo.Records");
            DropForeignKey("dbo.Medicines", "MedicineType_Id", "dbo.MedicineTypes");
            DropForeignKey("dbo.Medicines", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.Diseases", "Record_Id", "dbo.Records");
            DropForeignKey("dbo.Adresses", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Positions_Id", "dbo.Positions");
            DropIndex("dbo.WorkSchedules", new[] { "User_Id" });
            DropIndex("dbo.ContactInfoes", new[] { "Type_Id" });
            DropIndex("dbo.ContactInfoes", new[] { "IdUser_Id" });
            DropIndex("dbo.Medicines", new[] { "Record_Id" });
            DropIndex("dbo.Medicines", new[] { "MedicineType_Id" });
            DropIndex("dbo.Medicines", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Diseases", new[] { "Record_Id" });
            DropIndex("dbo.Records", new[] { "CardPatient_Id" });
            DropIndex("dbo.Users", new[] { "Positions_Id" });
            DropIndex("dbo.Adresses", new[] { "Users_Id" });
            DropTable("dbo.WorkSchedules");
            DropTable("dbo.ContactTypes");
            DropTable("dbo.ContactInfoes");
            DropTable("dbo.MedicineTypes");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Medicines");
            DropTable("dbo.Diseases");
            DropTable("dbo.Records");
            DropTable("dbo.CardPatients");
            DropTable("dbo.Positions");
            DropTable("dbo.Users");
            DropTable("dbo.Adresses");
        }
    }
}
