using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CointMarket.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public List<Post> Posts { get; set; }
        public List<Order> Orders { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public UserStatus Status { get; set; }
    }

    public enum UserStatus
    {
      ACTIVE =0,
      DISABLED=1,
      DELETED=-1
    }
}