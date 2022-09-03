namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgheadingsta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "HeadingSatutes", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Headings", "HeadingSatutes");
        }
    }
}
