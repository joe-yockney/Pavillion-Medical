namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Imagechanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "ImageName", c => c.String());
            AddColumn("dbo.Images", "ImageDesc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "ImageDesc");
            DropColumn("dbo.Images", "ImageName");
        }
    }
}
