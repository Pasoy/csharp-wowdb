using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wow.Models
{
    public class Pick
    {
        public int Id { get; set; }

        [Required]
        public Player Player { get; set; }

        [Required]
        public Character Character { get; set; }

        public DateTime DatePicked { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}