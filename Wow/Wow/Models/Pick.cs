﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wow.Models
{
    public class Pick
    {
        public int Id { get; set; }

        public Player Player { get; set; }
        [Display(Name = "Player")]
        [Required]
        public int PlayerId { get; set; }

        public Character Character { get; set; }
        [Display(Name = "Character")]
        [Required]
        public int CharacterId { get; set; }

        public DateTime DatePicked { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}