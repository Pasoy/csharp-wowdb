using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wow.Models;

namespace Wow.ViewModels
{
    public class PlayerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Player Player { get; set; }
    }
}