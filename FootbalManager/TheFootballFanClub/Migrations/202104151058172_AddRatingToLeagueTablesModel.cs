namespace TheFootballFanClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingToLeagueTablesModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeagueTablesModels",
                c => new
                    {
                        LeagueTable = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Name = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LeagueTable);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LeagueTablesModels");
        }
    }
}
