using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TheFootballFanClub.Models
{
    public class LeagueTablesModel
    {

        [Key]
        public virtual int LeagueId { get; set; } 
        public virtual string Name { get; set; }       
    }

}
