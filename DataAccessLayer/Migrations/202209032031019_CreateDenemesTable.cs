namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDenemesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.denemes",
                c => new
                    {
                        denemeıd = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.denemeıd);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.denemes");
        }
    }
}
