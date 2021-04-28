using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TheFootballFanClub.Models
{
    public class DataInitialiser : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            //populate datebase with some leagues, players and teams
            LeagueTablesModel League = new LeagueTablesModel();
            League.LeagueId = 1;
            League.Name = "Premier League";
            context.LeagueTablesModels.Add(League); 

            LeagueTablesModel League2 = new LeagueTablesModel();
            League2.LeagueId = 2;
            League2.Name = "Amateur League";
            context.LeagueTablesModels.Add(League2);

            FootballClubModel Club = new FootballClubModel();
            Club.FootballClubId = 1;
            Club.Name = "Leicester Football Club";
            Club.LeagueId = 1;
            Club.Wins = 5;
            Club.Losses = 10;
            Club.Draws = 10;
            Club.Points = 25;
            context.FootballClubModels.Add(Club);

            FootballClubModel Club1 = new FootballClubModel();
            Club1.FootballClubId = 2;
            Club1.Name = "Manchester Football Club";
            Club1.LeagueId = 1;
            Club1.Wins = 6;
            Club1.Losses = 5;
            Club1.Draws = 7;
            Club1.Points = 20;
            context.FootballClubModels.Add(Club1);

            FootballClubModel Club2 = new FootballClubModel();
            Club.FootballClubId = 3;
            Club2.Name = "London Football Club";
            Club2.LeagueId = 1;
            Club2.Wins = 15;
            Club2.Losses = 20;
            Club2.Draws = 16;
            Club2.Points = 45;
            context.FootballClubModels.Add(Club2);

            FootballClubModel Club3 = new FootballClubModel();
            Club.FootballClubId = 4;
            Club3.Name = "Birmingham Football Club";
            Club3.LeagueId = 1;
            Club3.Wins = 25;
            Club3.Losses = 16;
            Club3.Draws = 11;
            Club3.Points = 60;
            context.FootballClubModels.Add(Club3);

            FootballClubModel Club4 = new FootballClubModel();
            Club.FootballClubId = 5;
            Club4.Name = "Doncaster Football Club";
            Club4.LeagueId = 1;
            Club4.Wins = 35;
            Club4.Losses = 12;
            Club4.Draws = 19;
            Club4.Points = 30;
            context.FootballClubModels.Add(Club4);

            FootballClubModel Club5 = new FootballClubModel();
            Club.FootballClubId = 6;
            Club5.Name = "Peterborough Football Club";
            Club5.LeagueId = 2;
            Club5.Wins = 5;
            Club5.Losses = 6;
            Club5.Draws = 1;
            Club5.Points = 6;
            context.FootballClubModels.Add(Club5);

            FootballClubModel Club6 = new FootballClubModel();
            Club.FootballClubId = 7;
            Club6.Name = "Northanmpton Football Club";
            Club6.LeagueId = 2;
            Club6.Wins = 9;
            Club6.Losses = 5;
            Club6.Draws = 9;
            Club6.Points = 26;
            context.FootballClubModels.Add(Club6);

            FootballClubModel Club7 = new FootballClubModel();
            Club.FootballClubId = 8;
            Club7.Name = "Dover Football Club";
            Club7.LeagueId = 1;
            Club7.Wins = 19;
            Club7.Losses = 15;
            Club7.Draws = 6;
            Club7.Points = 36;
            context.FootballClubModels.Add(Club7);

            FootballClubModel Club8 = new FootballClubModel();
            Club.FootballClubId = 9;
            Club8.Name = "Blackburn Football Club";
            Club8.LeagueId = 1;
            Club8.Wins = 39;
            Club8.Losses = 5;
            Club8.Draws = 19;
            Club8.Points = 16;
            context.FootballClubModels.Add(Club8);

            FootballClubModel Club9 = new FootballClubModel();
            Club.FootballClubId = 10;
            Club9.Name = "Croydon Lions Football Club";
            Club9.LeagueId = 1;
            Club9.Wins = 9;
            Club9.Losses = 3;
            Club9.Draws = 6;
            Club9.Points = 9;
            context.FootballClubModels.Add(Club9);

            FootballClubModel Club10 = new FootballClubModel();
            Club.FootballClubId = 11;
            Club10.Name = "Nottingham Geenies Football Club";
            Club10.LeagueId = 1;
            Club10.Wins = 29;
            Club10.Losses = 13;
            Club10.Draws = 36;
            Club10.Points = 49;
            context.FootballClubModels.Add(Club10);

            FootballClubModel Club11 = new FootballClubModel();
            Club.FootballClubId = 12;
            Club11.Name = "Oadby Fairies Football Club";
            Club11.LeagueId = 1;
            Club11.Wins = 22;
            Club11.Losses = 3;
            Club11.Draws = 18;
            Club11.Points = 59;
            context.FootballClubModels.Add(Club11);

            PlayerModel Player = new PlayerModel();
            Player.PlayerId = 1;
            Player.FootballClubId = 1;
            Player.Name = "James Bond";
            context.PlayerModels.Add(Player);

            PlayerModel Player1 = new PlayerModel();
            Player1.PlayerId = 2;
            Player1.FootballClubId = 1;
            Player1.Name = "Boris Johnson";
            context.PlayerModels.Add(Player1);

            PlayerModel Player2 = new PlayerModel();
            Player2.PlayerId = 3;
            Player2.FootballClubId = 2;
            Player2.Name = "Tony Blair";
            context.PlayerModels.Add(Player2);

            PlayerModel Player3 = new PlayerModel();
            Player3.PlayerId = 4;
            Player3.FootballClubId = 2;
            Player3.Name = "Kevin Samuel";
            context.PlayerModels.Add(Player3);

            PlayerModel Player4 = new PlayerModel();
            Player4.PlayerId = 5;
            Player4.FootballClubId = 3;
            Player4.Name = "Jai Somaiya";
            context.PlayerModels.Add(Player4);

            PlayerModel Player5 = new PlayerModel();
            Player5.PlayerId = 6;
            Player5.FootballClubId = 3;
            Player5.Name = "Paresh Patel";
            context.PlayerModels.Add(Player5);

            PlayerModel Player6 = new PlayerModel();
            Player6.PlayerId = 7;
            Player6.FootballClubId = 4;
            Player6.Name = "Karl Indans";
            context.PlayerModels.Add(Player6);

            PlayerModel Player7 = new PlayerModel();
            Player7.PlayerId = 8;
            Player7.FootballClubId = 4;
            Player7.Name = "James Follower";
            context.PlayerModels.Add(Player7);

            PlayerModel Player8 = new PlayerModel();
            Player8.PlayerId = 9;
            Player8.FootballClubId = 5;
            Player8.Name = "James Flower";
            context.PlayerModels.Add(Player8);

            PlayerModel Player9 = new PlayerModel();
            Player9.PlayerId = 10;
            Player9.FootballClubId = 5;
            Player9.Name = "Ross Parkinson";
            context.PlayerModels.Add(Player9);

            PlayerModel Player10 = new PlayerModel();
            Player10.PlayerId = 11;
            Player10.FootballClubId = 6;
            Player10.Name = "Ross Simon";
            context.PlayerModels.Add(Player10);

            PlayerModel Player11 = new PlayerModel();
            Player11.PlayerId = 12;
            Player11.FootballClubId = 6;
            Player11.Name = "Dominic Patel";
            context.PlayerModels.Add(Player11);

            PlayerModel Player12 = new PlayerModel();
            Player12.PlayerId = 13;
            Player12.FootballClubId = 7;
            Player12.Name = "Marcus Aurelius";
            context.PlayerModels.Add(Player12);

            PlayerModel Player13 = new PlayerModel();
            Player13.PlayerId = 14;
            Player13.FootballClubId = 7;
            Player13.Name = "Paul Jenkins";
            context.PlayerModels.Add(Player13);

            PlayerModel Player14 = new PlayerModel();
            Player14.PlayerId = 15;
            Player14.FootballClubId = 8;
            Player14.Name = "Nemessis Polo";
            context.PlayerModels.Add(Player14);

            PlayerModel Player15 = new PlayerModel();
            Player15.PlayerId = 16;
            Player15.FootballClubId = 8;
            Player15.Name = "Oliver Stone";
            context.PlayerModels.Add(Player15);

            PlayerModel Player16 = new PlayerModel();
            Player16.PlayerId = 17;
            Player16.FootballClubId = 9;
            Player16.Name = "Jamie Oliver";
            context.PlayerModels.Add(Player16);

            PlayerModel Player17 = new PlayerModel();
            Player17.PlayerId = 18;
            Player17.FootballClubId = 9;
            Player17.Name = "William Royal";
            context.PlayerModels.Add(Player17);

            PlayerModel Player18 = new PlayerModel();
            Player18.PlayerId = 19;
            Player18.FootballClubId = 10;
            Player18.Name = "Price Royal";
            context.PlayerModels.Add(Player18);

            PlayerModel Player19 = new PlayerModel();
            Player19.PlayerId = 20;
            Player19.FootballClubId = 10;
            Player19.Name = "Noah Dragasanu";
            context.PlayerModels.Add(Player17);

            PlayerModel Player20 = new PlayerModel();
            Player20.PlayerId = 21;
            Player20.FootballClubId = 11;
            Player20.Name = "Lucas Somebody";
            context.PlayerModels.Add(Player20);

            PlayerModel Player21 = new PlayerModel();
            Player21.PlayerId = 22;
            Player21.FootballClubId = 11;
            Player21.Name = "Benjamin Otherguy";
            context.PlayerModels.Add(Player17);

            PlayerModel Player22 = new PlayerModel();
            Player22.PlayerId = 23;
            Player22.FootballClubId = 12;
            Player22.Name = "Jimmy Somebodyelse";
            context.PlayerModels.Add(Player22);

            PlayerModel Player23 = new PlayerModel();
            Player23.PlayerId = 24;
            Player23.FootballClubId = 12;
            Player23.Name = "Benjamin Nobodyknows";
            context.PlayerModels.Add(Player23);
        }
    }
}