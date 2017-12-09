namespace Tours.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attachments_passengerphoto_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tours.Attachment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TourPackageId = c.Int(nullable: false),
                        FileData = c.Binary(),
                        OriginalFileName = c.String(),
                        MimeType = c.String(),
                        FileSize = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Tours.TourPackage", t => t.TourPackageId, cascadeDelete: true)
                .Index(t => t.TourPackageId);
            
            AddColumn("People.Passenger", "PhotoPath", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("Tours.Attachment", "TourPackageId", "Tours.TourPackage");
            DropIndex("Tours.Attachment", new[] { "TourPackageId" });
            DropColumn("People.Passenger", "PhotoPath");
            DropTable("Tours.Attachment");
        }
    }
}
