namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatephysician : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Physicians", "Title", c => c.String());
            AddColumn("dbo.Physicians", "Qualifications", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Physicians", "Qualifications");
            DropColumn("dbo.Physicians", "Title");
        }
    }
}
