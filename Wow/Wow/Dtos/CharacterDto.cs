using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Wow.Models;

namespace Wow.Dtos
{
    public class CharacterDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte ClassId { get; set; }

        [Required]
        public byte RaceId { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Gender { get; set; }
    }
}