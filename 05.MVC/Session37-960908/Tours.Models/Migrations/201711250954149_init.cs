namespace Tours.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "People.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactType = c.Int(nullable: false),
                        Value = c.String(nullable: false, maxLength: 50),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("People.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.Value, unique: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "People.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Tours.TourPackage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Tours.TourPackage_Passenger",
                c => new
                    {
                        TourPackage_Id = c.Int(nullable: false),
                        Passenger_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TourPackage_Id, t.Passenger_Id })
                .ForeignKey("Tours.TourPackage", t => t.TourPackage_Id, cascadeDelete: true)
                .ForeignKey("People.Passenger", t => t.Passenger_Id, cascadeDelete: true)
                .Index(t => t.TourPackage_Id)
                .Index(t => t.Passenger_Id);
            
            CreateTable(
                "People.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 50),
                        PasswordHash = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("People.Person", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "People.Passenger",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PassportNumber = c.String(),
                        BirthDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("People.Person", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("People.Passenger", "Id", "People.Person");
            DropForeignKey("People.Employee", "Id", "People.Person");
            DropForeignKey("Tours.TourPackage_Passenger", "Passenger_Id", "People.Passenger");
            DropForeignKey("Tours.TourPackage_Passenger", "TourPackage_Id", "Tours.TourPackage");
            DropForeignKey("People.Contact", "PersonId", "People.Person");
            DropIndex("People.Passenger", new[] { "Id" });
            DropIndex("People.Employee", new[] { "Username" });
            DropIndex("People.Employee", new[] { "Id" });
            DropIndex("Tours.TourPackage_Passenger", new[] { "Passenger_Id" });
            DropIndex("Tours.TourPackage_Passenger", new[] { "TourPackage_Id" });
            DropIndex("People.Contact", new[] { "PersonId" });
            DropIndex("People.Contact", new[] { "Value" });
            DropTable("People.Passenger");
            DropTable("People.Employee");
            DropTable("Tours.TourPackage_Passenger");
            DropTable("Tours.TourPackage");
            DropTable("People.Person");
            DropTable("People.Contact");
        }
    }
}
