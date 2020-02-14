using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Super_Hero.Models
{
    public class Suit
    {
        [Key]
        public int Id { get; set; }
        public string SuitNumber { get; set; }
        public string SuitName { get; set; }
        public string Specialty { get; set; }
    }
}
