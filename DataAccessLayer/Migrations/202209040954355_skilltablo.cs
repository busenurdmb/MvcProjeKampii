namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skilltablo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "SkillName", c => c.String());
            AddColumn("dbo.Skills", "SkillValue", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "SkillValue");
            DropColumn("dbo.Skills", "SkillName");
        }
    }
}
