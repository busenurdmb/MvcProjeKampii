namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vbc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skiils", "add", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skiils", "add");
        }
    }
}
