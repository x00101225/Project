namespace Project2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vote : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        VoteId = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        Sugesstion = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.VoteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Votes");
        }
    }
}
