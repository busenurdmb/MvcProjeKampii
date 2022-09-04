namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class silme : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Skiils");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Skiils",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        SkillName = c.String(maxLength: 50),
                        Skillvalues = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.SkillID);
            
        }
    }
}
