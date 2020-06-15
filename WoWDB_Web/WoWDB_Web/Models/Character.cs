using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WoWDB_Web.Models
{
    // POCO
    public class Character
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Class { get; set; }
        public String Race { get; set; }
    }
}