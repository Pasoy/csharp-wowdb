using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wow.Models
{
    public class Character
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Class Class { get; set; }
        [Display(Name = "Class")]
        [Required]
        public byte ClassId { get; set; }

        public Race Race { get; set; }
        [Display(Name = "Race")]
        [Required]
        public byte RaceId { get; set; }

        public DateTime DateCreated { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public string Gender { get; set; }
    }
}