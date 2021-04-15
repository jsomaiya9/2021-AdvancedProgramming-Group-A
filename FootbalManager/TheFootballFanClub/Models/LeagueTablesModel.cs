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
        public virtual int LeagueTable { get; set; }
        public virtual string City { get; set; }
        public virtual string Name { get; set; }
        public virtual int Rating { get; set; }

    }

}
