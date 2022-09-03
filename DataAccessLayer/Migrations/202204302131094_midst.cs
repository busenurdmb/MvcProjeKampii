namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class midst : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterSatutes", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterSatutes");
        }
    }
}
