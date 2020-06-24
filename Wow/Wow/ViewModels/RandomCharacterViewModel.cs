using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wow.Models;

namespace Wow.ViewModels
{
    public class RandomCharacterViewModel
    {
        public Character Character { get; set; }
        public List<Player> Players { get; set; }
    }
}