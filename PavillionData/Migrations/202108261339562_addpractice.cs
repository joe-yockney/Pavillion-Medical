namespace PavillionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpractice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Physicians", "Practice", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Physicians", "Practice");
        }
    }
}
