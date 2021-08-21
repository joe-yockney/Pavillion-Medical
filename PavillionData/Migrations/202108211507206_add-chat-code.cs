namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addchatcode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChatCodes",
                c => new
                    {
                        CodeId = c.Int(nullable: false, identity: true),
                        CodeContent = c.Int(nullable: false),
                        Physician_Id = c.Int(),
                    })
                .PrimaryKey(t => t.CodeId)
                .ForeignKey("dbo.Physicians", t => t.Physician_Id)
                .Index(t => t.Physician_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChatCodes", "Physician_Id", "dbo.Physicians");
            DropIndex("dbo.ChatCodes", new[] { "Physician_Id" });
            DropTable("dbo.ChatCodes");
        }
    }
}
