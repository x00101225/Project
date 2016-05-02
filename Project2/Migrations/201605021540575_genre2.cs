namespace Project2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genre2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Electronics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        SubGenre = c.String(),
                        Comment = c.String(),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Electronics");
        }
    }
}
