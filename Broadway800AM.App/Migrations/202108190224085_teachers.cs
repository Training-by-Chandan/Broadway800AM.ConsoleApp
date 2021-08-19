namespace Broadway800AM.App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teachers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teacher_info",
                c => new
                    {
                        TeacherId = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(),
                        Email = c.String(),
                        Status = c.Boolean(nullable: false),
                        DateofJoining = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teacher_info");
        }
    }
}
