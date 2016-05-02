namespace Project2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genre3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HipHops",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        SubGenre = c.String(),
                        Comment = c.String(),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.ContactId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HipHops");
        }
    }
}
