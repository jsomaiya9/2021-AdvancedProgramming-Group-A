using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheFootballFanClub.Models
{
    public class UserModel
    {
        [Key] 
        public virtual int UserId { get; set; }
        public virtual string Username { get; set; }
        public virtual string PasswordText { get; set; }
    }
}