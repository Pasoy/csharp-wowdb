using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wow.Dtos
{
    public class NewPickDto
    {
        public int PlayerId { get; set; }
        public List<int> CharacterIds { get; set; }
    }
}