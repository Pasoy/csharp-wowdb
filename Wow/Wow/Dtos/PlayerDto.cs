using System;
using System.ComponentModel.DataAnnotations;
using Wow.Models;

namespace Wow.Dtos
{
    public class PlayerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribed { get; set; }
        
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        [Min18YearsIfPlayer]
        public DateTime? Birthdate { get; set; }
    }
}