namespace StatTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStatsString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "StatsString", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "StatsString");
        }
    }
}
