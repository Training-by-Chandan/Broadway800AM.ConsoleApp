namespace Broadway800AM.App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class updateproc : DbMigration
    {
        public override void Up()
        {
            var drop = @"alter procedure [dbo].[DemoStroredProcNew]
                            as
                            select * from Teacher_info";
            this.Sql(drop);
        }

        public override void Down()
        {
            var stroredprocstr = @"Alter PROCEDURE [dbo].[DemoStroredProcNew]
                                AS
                                select * from student
                                select * from parent
                                select * from studentparent";
            this.Sql(stroredprocstr);
        }
    }
}