namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatechatcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatCodes", "DateGenerated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChatCodes", "DateGenerated");
        }
    }
}
