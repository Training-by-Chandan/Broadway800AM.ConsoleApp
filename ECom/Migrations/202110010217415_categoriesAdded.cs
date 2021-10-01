namespace ECom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoriesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Description = c.String(nullable: false, maxLength: 200),
                        ParentId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.ParentId)
                .Index(t => t.ParentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "ParentId", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "ParentId" });
            DropTable("dbo.Categories");
        }
    }
}
