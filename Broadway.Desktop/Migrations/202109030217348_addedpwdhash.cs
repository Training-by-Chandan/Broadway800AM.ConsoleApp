namespace Broadway.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpwdhash : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "HashPwd", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "HashPwd");
        }
    }
}
