using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Wow.Models;

namespace Wow.Dtos
{
    public class PickDto
    {
        public List<int> CharacterIds { get; set; }

        public int Id { get; set; }

        [Required]
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        [Required]
        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}