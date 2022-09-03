namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSkiilsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                {
                    SkillID = c.Int(nullable: false, identity: true),
                    SkillName = c.String(maxLength: 50),
                    SkillValue = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.SkillID);
        }
        
        public override void Down()
        {
            AddColumn("dbo.Skiils", "values", c => c.Int(nullable: false));
            DropColumn("dbo.Skiils", "Skillvalues");
        }
    }
}
