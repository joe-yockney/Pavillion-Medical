namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adduserid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Physicians", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Physicians", "UserId");
        }
    }
}
