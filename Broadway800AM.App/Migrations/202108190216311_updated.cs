namespace Broadway800AM.App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.People", "Address", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Address", c => c.String());
            AlterColumn("dbo.People", "Name", c => c.String());
        }
    }
}
