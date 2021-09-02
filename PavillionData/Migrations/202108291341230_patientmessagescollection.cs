namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class patientmessagescollection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientMessages", "Physician_Id", c => c.Int());
            CreateIndex("dbo.PatientMessages", "Physician_Id");
            AddForeignKey("dbo.PatientMessages", "Physician_Id", "dbo.Physicians", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientMessages", "Physician_Id", "dbo.Physicians");
            DropIndex("dbo.PatientMessages", new[] { "Physician_Id" });
            DropColumn("dbo.PatientMessages", "Physician_Id");
        }
    }
}
