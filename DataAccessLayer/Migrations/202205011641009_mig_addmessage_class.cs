namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addmessage_class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MesajId = c.Int(nullable: false, identity: true),
                        SenderMail = c.String(maxLength: 50),
                        RecelverMail = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 200),
                        MesajContact = c.String(),
                        MesajDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MesajId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
