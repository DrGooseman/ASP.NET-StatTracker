namespace StatTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGameAndPlayer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GameId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.GameId, cascadeDelete: true)
                .Index(t => t.GameId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "GameId", "dbo.Games");
            DropIndex("dbo.Players", new[] { "GameId" });
            DropTable("dbo.Players");
            DropTable("dbo.Games");
        }
    }
}
