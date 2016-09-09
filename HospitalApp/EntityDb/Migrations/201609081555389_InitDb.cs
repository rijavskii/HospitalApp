namespace EntityDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
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
                        Region = c.String(),
                        City = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        HouseNumber = c.String(nullable: false),
                        Appartment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CardPatients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RecordDate = c.DateTime(nullable: false),
                        DischargeDate = c.DateTime(nullable: false),
                        AdditionalInfo = c.String(),
                        Doctor_Id = c.Int(),
                        Patient_Id = c.Int(),
                        CardPatient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Doctor_Id)
                .ForeignKey("dbo.Users", t => t.Patient_Id)
                .ForeignKey("dbo.CardPatients", t => t.CardPatient_Id)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Patient_Id)
                .Index(t => t.CardPatient_Id);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Treatment = c.String(),
                        Name = c.String(nullable: false),
                        Patient_Id = c.Int(),
                        Record_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Patient_Id)
                .ForeignKey("dbo.Records", t => t.Record_Id)
                .Index(t => t.Patient_Id)
                .Index(t => t.Record_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        MiddleName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Birthday = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        IsPatient = c.Boolean(nullable: false),
                        Passport = c.String(nullable: false),
                        IdentificationNumber = c.String(nullable: false),
                        Adress_Id = c.Int(nullable: false),
                        Position_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresses", t => t.Adress_Id, cascadeDelete: true)
                .ForeignKey("dbo.Positions", t => t.Position_Id, cascadeDelete: true)
                .Index(t => t.Adress_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PositionCode = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        WorkerPositionType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PositionTypes", t => t.WorkerPositionType_Id)
                .Index(t => t.WorkerPositionType_Id);
            
            CreateTable(
                "dbo.PositionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Room = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
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
                        FactoryName = c.String(nullable: false),
                        Country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MedicineTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Contact = c.String(),
                        IsDefault = c.Boolean(nullable: false),
                        Type_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContactTypes", t => t.Type_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Type_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.ContactTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkRoom = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Patient_Id = c.Int(),
                        Worker_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Patient_Id)
                .ForeignKey("dbo.Users", t => t.Worker_Id, cascadeDelete: true)
                .Index(t => t.Patient_Id)
                .Index(t => t.Worker_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkSchedules", "Worker_Id", "dbo.Users");
            DropForeignKey("dbo.WorkSchedules", "Patient_Id", "dbo.Users");
            DropForeignKey("dbo.ContactInfoes", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ContactInfoes", "Type_Id", "dbo.ContactTypes");
            DropForeignKey("dbo.Records", "CardPatient_Id", "dbo.CardPatients");
            DropForeignKey("dbo.Records", "Patient_Id", "dbo.Users");
            DropForeignKey("dbo.Medicines", "Record_Id", "dbo.Records");
            DropForeignKey("dbo.Medicines", "MedicineType_Id", "dbo.MedicineTypes");
            DropForeignKey("dbo.Medicines", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.Records", "Doctor_Id", "dbo.Users");
            DropForeignKey("dbo.Diseases", "Record_Id", "dbo.Records");
            DropForeignKey("dbo.Diseases", "Patient_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Position_Id", "dbo.Positions");
            DropForeignKey("dbo.Positions", "WorkerPositionType_Id", "dbo.PositionTypes");
            DropForeignKey("dbo.Users", "Adress_Id", "dbo.Adresses");
            DropIndex("dbo.WorkSchedules", new[] { "Worker_Id" });
            DropIndex("dbo.WorkSchedules", new[] { "Patient_Id" });
            DropIndex("dbo.ContactInfoes", new[] { "User_Id" });
            DropIndex("dbo.ContactInfoes", new[] { "Type_Id" });
            DropIndex("dbo.Medicines", new[] { "Record_Id" });
            DropIndex("dbo.Medicines", new[] { "MedicineType_Id" });
            DropIndex("dbo.Medicines", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Positions", new[] { "WorkerPositionType_Id" });
            DropIndex("dbo.Users", new[] { "Position_Id" });
            DropIndex("dbo.Users", new[] { "Adress_Id" });
            DropIndex("dbo.Diseases", new[] { "Record_Id" });
            DropIndex("dbo.Diseases", new[] { "Patient_Id" });
            DropIndex("dbo.Records", new[] { "CardPatient_Id" });
            DropIndex("dbo.Records", new[] { "Patient_Id" });
            DropIndex("dbo.Records", new[] { "Doctor_Id" });
            DropTable("dbo.WorkSchedules");
            DropTable("dbo.ContactTypes");
            DropTable("dbo.ContactInfoes");
            DropTable("dbo.MedicineTypes");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Medicines");
            DropTable("dbo.PositionTypes");
            DropTable("dbo.Positions");
            DropTable("dbo.Users");
            DropTable("dbo.Diseases");
            DropTable("dbo.Records");
            DropTable("dbo.CardPatients");
            DropTable("dbo.Adresses");
        }
    }
}
