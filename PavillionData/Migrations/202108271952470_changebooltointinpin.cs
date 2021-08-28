namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changebooltointinpin : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ChatCodes", newName: "PatientPins");
            AlterColumn("dbo.PatientPins", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PatientPins", "Status", c => c.Boolean(nullable: false));
            RenameTable(name: "dbo.PatientPins", newName: "ChatCodes");
        }
    }
}
