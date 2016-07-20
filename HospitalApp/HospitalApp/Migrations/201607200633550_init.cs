namespace HospitalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
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
                        Positions_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Positions", t => t.Positions_Id, cascadeDelete: true)
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
                "dbo.WorkSchedules",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        IdDoctor = c.Int(nullable: false),
                        WorkRoom = c.Int(nullable: false),
                        StartWork = c.DateTime(nullable: false),
                        EndWork = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkSchedules", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Adresses", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Positions_Id", "dbo.Positions");
            DropIndex("dbo.WorkSchedules", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "Positions_Id" });
            DropIndex("dbo.Adresses", new[] { "Users_Id" });
            DropTable("dbo.WorkSchedules");
            DropTable("dbo.Positions");
            DropTable("dbo.Users");
            DropTable("dbo.Adresses");
        }
    }
}
