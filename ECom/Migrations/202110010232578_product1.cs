namespace ECom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Description = c.String(nullable: false),
                        PicturePath = c.String(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                        VendorId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Vendors", t => t.VendorId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.VendorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "VendorId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
        }
    }
}
