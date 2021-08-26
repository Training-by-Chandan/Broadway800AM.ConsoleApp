﻿namespace Broadway.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Address = c.String(),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "UserId", "dbo.Users");
            DropIndex("dbo.Students", new[] { "UserId" });
            DropTable("dbo.Students");
        }
    }
}
