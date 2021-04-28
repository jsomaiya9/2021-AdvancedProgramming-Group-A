using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheFootballFanClub.Models
{
    public class PlayerModel
    {
        [Key]
        public virtual int PlayerId { get; set; }
        public virtual FootballClubModel FootballClub { get; set; }
        public virtual int FootballClubId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Followers { get; set; }
    }
}