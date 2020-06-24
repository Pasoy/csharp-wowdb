using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Wow.Models;

namespace Wow.ViewModels
{
    public class CharacterFormViewModel
    {
        public IEnumerable<Class> Classes { get; set; }
        public IEnumerable<Race> Races { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Class")]
        [Required]
        public byte? ClassId { get; set; }

        [Display(Name = "Race")]
        [Required]
        public byte? RaceId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }

        public string Title => Id != 0 ? "Edit Character" : "New Character";

        public CharacterFormViewModel()
        {
            Id = 0;
        }

        public CharacterFormViewModel(Character character)
        {
            Id = character.Id;
            Name = character.Name;
            ClassId = character.ClassId;
            ReleaseDate = character.ReleaseDate;
            RaceId = character.RaceId;
            Gender = character.Gender;
        }
    }
}