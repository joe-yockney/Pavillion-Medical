namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addspecialisation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Physicians", "Specialisation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Physicians", "Specialisation");
        }
    }
}
