namespace StunningCommunity.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        EmailAddres = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Emails", new[] { "UserId" });
            DropForeignKey("dbo.Emails", "UserId", "dbo.Users");
            DropTable("dbo.Emails");
            DropTable("dbo.Users");
        }
    }
}
