﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSkillsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.SkillID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
        }
    }
}
