namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstatustochatcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatCodes", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChatCodes", "Status");
        }
    }
}
