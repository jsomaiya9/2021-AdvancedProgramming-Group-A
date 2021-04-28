using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheFootballFanClub.Models
{
    public class FootballClubModel
    {
        [Key]
        public virtual int FootballClubId { get; set; }
        public virtual LeagueTablesModel League { get; set; }
        public virtual int LeagueId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Wins { get; set; }
        public virtual int Losses { get; set; }
        public virtual int Draws { get; set; }
        public virtual int Points { get; set; }
    }

}