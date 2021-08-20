namespace Broadway800AM.App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class storedproc : DbMigration
    {
        public override void Up()
        {
            var stroredprocstr = @"CREATE PROCEDURE [dbo].[DemoStroredProcNew]
                                AS
                                select * from student
                                select * from parent
                                select * from studentparent";
            this.Sql(stroredprocstr);
        }

        public override void Down()
        {
            var drop = @"drop procedure [dbo].[DemoStroredProcNew]";
            this.Sql(drop);
        }
    }
}