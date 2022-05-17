using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBase
{
    [Table("Flights")]
    public class Flight : BaseEntity<int>
    {
        [ForeignKey("From")]
        public int FromId { get; set; }
        [ForeignKey("To")]
        public int ToId { get; set; }
        [Required]
        public Place From { get; set; }
        [Required]
        public Place To { get; set; }
        [Required]
        public int MaxClients { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public DateTime date { get; set; }
    }
}