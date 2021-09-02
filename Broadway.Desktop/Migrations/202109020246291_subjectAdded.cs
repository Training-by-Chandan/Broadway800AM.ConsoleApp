namespace Broadway.Desktop.Migrations
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
                        SubCode = c.String(),
                        ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId)
                .Index(t => t.ClassId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "ClassId", "dbo.Classes");
            DropIndex("dbo.Subjects", new[] { "ClassId" });
            DropTable("dbo.Subjects");
        }
    }
}
