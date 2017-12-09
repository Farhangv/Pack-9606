namespace Tours.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class passaenger_properties_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("People.Person", "NationalCode", c => c.String(maxLength: 10));
            AlterColumn("People.Passenger", "PassportNumber", c => c.String(nullable: false, maxLength: 9));
            CreateIndex("People.Passenger", "PassportNumber", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("People.Passenger", new[] { "PassportNumber" });
            AlterColumn("People.Passenger", "PassportNumber", c => c.String());
            DropColumn("People.Person", "NationalCode");
        }
    }
}
