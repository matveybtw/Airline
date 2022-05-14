using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBase
{
    [Table("Places")]
    public class Place : BaseEntity<int>
    {
        [Required]
        public string Title { get; set; }
    }
}