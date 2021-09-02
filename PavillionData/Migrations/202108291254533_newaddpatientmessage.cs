namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newaddpatientmessage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientMessages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        MessageContent = c.String(),
                        PatientName = c.String(),
                        PatientEmail = c.String(),
                    })
                .PrimaryKey(t => t.MessageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientMessages");
        }
    }
}
