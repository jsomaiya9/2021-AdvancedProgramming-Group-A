namespace TheFootballFanClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWinsToFootballClubModel : DbMigration
    {
        public override void Up()
        {
             DropPrimaryKey("dbo.LeagueTablesModels");
            DropColumn("dbo.LeagueTablesModels", "LeagueTable");
            AddColumn("dbo.FootballClubModels", "LeagueId", c => c.Int(nullable: false));
            AddColumn("dbo.FootballClubModels", "Wins", c => c.Int(nullable: false));
            AddColumn("dbo.FootballClubModels", "Losses", c => c.Int(nullable: false));
            AddColumn("dbo.FootballClubModels", "Draws", c => c.Int(nullable: false));
            AddColumn("dbo.FootballClubModels", "Points", c => c.Int(nullable: false));
            AddColumn("dbo.LeagueTablesModels", "LeagueId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.LeagueTablesModels", "LeagueId");
            CreateIndex("dbo.FootballClubModels", "LeagueId");
            AddForeignKey("dbo.FootballClubModels", "LeagueId", "dbo.LeagueTablesModels", "LeagueId", cascadeDelete: true);
            DropColumn("dbo.FootballClubModels", "City");
            
            DropColumn("dbo.LeagueTablesModels", "City");
            DropColumn("dbo.LeagueTablesModels", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LeagueTablesModels", "Rating", c => c.Int(nullable: false));
            AddColumn("dbo.LeagueTablesModels", "City", c => c.String());
            AddColumn("dbo.LeagueTablesModels", "LeagueTable", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.FootballClubModels", "City", c => c.String());
            DropForeignKey("dbo.FootballClubModels", "LeagueId", "dbo.LeagueTablesModels");
            DropIndex("dbo.FootballClubModels", new[] { "LeagueId" });
            DropPrimaryKey("dbo.LeagueTablesModels");
            DropColumn("dbo.LeagueTablesModels", "LeagueId");
            DropColumn("dbo.FootballClubModels", "Points");
            DropColumn("dbo.FootballClubModels", "Draws");
            DropColumn("dbo.FootballClubModels", "Losses");
            DropColumn("dbo.FootballClubModels", "Wins");
            DropColumn("dbo.FootballClubModels", "LeagueId");
            AddPrimaryKey("dbo.LeagueTablesModels", "LeagueTable");
        }
    }
}
