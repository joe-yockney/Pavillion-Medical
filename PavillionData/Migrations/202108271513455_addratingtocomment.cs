namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addratingtocomment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientComments", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientComments", "Rating");
        }
    }
}
