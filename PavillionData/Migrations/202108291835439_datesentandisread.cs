namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datesentandisread : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientMessages", "Datesent", c => c.DateTime(nullable: false));
            AddColumn("dbo.PatientMessages", "IsRead", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientMessages", "IsRead");
            DropColumn("dbo.PatientMessages", "Datesent");
        }
    }
}
