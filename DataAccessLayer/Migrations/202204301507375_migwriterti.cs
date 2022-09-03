﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migwriterti : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "writerTitle", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "writerTitle");
        }
    }
}
