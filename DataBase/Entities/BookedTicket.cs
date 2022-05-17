using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBase
{
    [Table("BookedTickets")]
    public class BookedTicket : BaseEntity<int>
    {
        [ForeignKey("Flight")]
        public int FlightId { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [Required]
        public Flight Flight { get; set; }
        [Required]
        public Client Client { get; set; }
    }
}