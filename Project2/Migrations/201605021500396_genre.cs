namespace Project2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Location", c => c.String());
            AddColumn("dbo.Contacts", "Genre", c => c.String());
            AddColumn("dbo.Contacts", "Comment", c => c.String());
            AddColumn("dbo.Contacts", "Link", c => c.String());
            DropColumn("dbo.Contacts", "Address");
            DropColumn("dbo.Contacts", "City");
            DropColumn("dbo.Contacts", "State");
            DropColumn("dbo.Contacts", "Zip");
            DropColumn("dbo.Contacts", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Email", c => c.String());
            AddColumn("dbo.Contacts", "Zip", c => c.String());
            AddColumn("dbo.Contacts", "State", c => c.String());
            AddColumn("dbo.Contacts", "City", c => c.String());
            AddColumn("dbo.Contacts", "Address", c => c.String());
            DropColumn("dbo.Contacts", "Link");
            DropColumn("dbo.Contacts", "Comment");
            DropColumn("dbo.Contacts", "Genre");
            DropColumn("dbo.Contacts", "Location");
        }
    }
}
