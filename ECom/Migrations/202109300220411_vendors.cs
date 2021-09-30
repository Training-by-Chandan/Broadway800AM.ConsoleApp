namespace ECom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vendors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.String(maxLength: 128),
                        IsActive = c.Boolean(nullable: false),
                        Rating = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendors", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Vendors", new[] { "UserId" });
            DropTable("dbo.Vendors");
        }
    }
}
