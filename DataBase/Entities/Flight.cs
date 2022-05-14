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
        [Required]
        public Place From { get; set; }
        [Required]
        public Place To { get; set; }
        [Required]
        public int MaxClients { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public DateTime date { get; set; }
    }
}