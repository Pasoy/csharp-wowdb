using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wow.Models
{
    public class Min18YearsIfPlayer : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var player = (Player) validationContext.ObjectInstance;

            if(player.MembershipTypeId == MembershipType.Unknown || player.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if(player.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - player.Birthdate.Value.Year;

            return age >= 18
                ? ValidationResult.Success
                : new ValidationResult("Player must be 18 years for a subscription.");
        }
    }
}