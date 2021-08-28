namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameoncomment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientComments", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientComments", "Name");
        }
    }
}
