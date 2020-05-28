using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CointMarket.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Rank { get; set; }
        public string Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public OrderStatus Status { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
    public enum OrderStatus
    {
        ACTIVE = 0,
        DISABLE = 1,
        DELETED = -1
    }
}