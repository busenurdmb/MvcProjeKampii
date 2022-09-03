namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contentstamig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "ContentStatues", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contents", "ContentStatues");
        }
    }
}
