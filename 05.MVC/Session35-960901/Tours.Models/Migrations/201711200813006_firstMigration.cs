namespace Tours.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactType = c.Int(nullable: false),
                        Value = c.String(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        Username = c.String(),
                        PasswordHash = c.String(),
                        PassportNumber = c.String(),
                        BirthDate = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TourPackages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TourPackagePassengers",
                c => new
                    {
                        TourPackage_Id = c.Int(nullable: false),
                        Passenger_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TourPackage_Id, t.Passenger_Id })
                .ForeignKey("dbo.TourPackages", t => t.TourPackage_Id, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Passenger_Id, cascadeDelete: true)
                .Index(t => t.TourPackage_Id)
                .Index(t => t.Passenger_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TourPackagePassengers", "Passenger_Id", "dbo.People");
            DropForeignKey("dbo.TourPackagePassengers", "TourPackage_Id", "dbo.TourPackages");
            DropForeignKey("dbo.Contacts", "Person_Id", "dbo.People");
            DropIndex("dbo.TourPackagePassengers", new[] { "Passenger_Id" });
            DropIndex("dbo.TourPackagePassengers", new[] { "TourPackage_Id" });
            DropIndex("dbo.Contacts", new[] { "Person_Id" });
            DropTable("dbo.TourPackagePassengers");
            DropTable("dbo.TourPackages");
            DropTable("dbo.People");
            DropTable("dbo.Contacts");
        }
    }
}
