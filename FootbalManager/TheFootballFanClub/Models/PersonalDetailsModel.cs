using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheFootballFanClub.Models
{
    public class PersonalDetailsModel
    {
        [Key]
        public virtual int PersonalDetailsId { get; set; }
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string City { get; set; }
        public virtual string PostCode { get; set; }
        public virtual string Email { get; set; }
        public virtual UserModel User { get; set; }
        public virtual int UserId { get; set; }

    }
}