namespace Broadway.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentgender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Gender", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Gender");
        }
    }
}
