namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpicturetophysician : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Physicians", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Physicians", "ImagePath");
        }
    }
}
