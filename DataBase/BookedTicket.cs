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
    public class BookedTicket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookedTicketId { get; set; }
        [Required]
        public Flight Flight { get; set; }
        [Required]
        public string ClientFirstName { get; set; }
        [Required]
        public string ClientLastName { get; set; }
    }
}