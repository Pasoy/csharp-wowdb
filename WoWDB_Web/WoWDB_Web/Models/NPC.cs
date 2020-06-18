using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WoWDB_Web.Models
{
    public class NPC
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Class { get; set; }
        public String Race { get; set; }
        public int Faction { get; set; }
        public int modelid { get; set; }
        public int health { get; set; }
        public int mana { get; set; }
    }
}