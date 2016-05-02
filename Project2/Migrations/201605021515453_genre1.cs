namespace Project2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genre1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "SubGenre", c => c.String());
            DropColumn("dbo.Contacts", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Genre", c => c.String());
            DropColumn("dbo.Contacts", "SubGenre");
        }
    }
}
