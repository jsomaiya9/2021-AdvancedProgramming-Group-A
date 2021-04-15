using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootbalManager.Models
{
    public class FootballClubModel
    {
        [Key]
        public virtual int FootballClubId { get; set; }
        public virtual string City { get; set; }
        public virtual string Name { get; set; }
    }

}