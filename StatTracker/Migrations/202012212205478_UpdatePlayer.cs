namespace StatTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "StatsString", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "StatsString");
        }
    }
}
