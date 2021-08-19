namespace Broadway800AM.App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class subjectAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                        Class = c.Int(nullable: false),
                        TeacherId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teacher_info", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "TeacherId", "dbo.Teacher_info");
            DropIndex("dbo.Subjects", new[] { "TeacherId" });
            DropTable("dbo.Subjects");
        }
    }
}
