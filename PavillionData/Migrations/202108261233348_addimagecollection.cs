namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addimagecollection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "Physician_Id", c => c.Int());
            CreateIndex("dbo.Images", "Physician_Id");
            AddForeignKey("dbo.Images", "Physician_Id", "dbo.Physicians", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "Physician_Id", "dbo.Physicians");
            DropIndex("dbo.Images", new[] { "Physician_Id" });
            DropColumn("dbo.Images", "Physician_Id");
        }
    }
}
