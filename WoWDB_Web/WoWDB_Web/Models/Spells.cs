using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WoWDB_Web.Models
{
    public class Spells
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Class { get; set; }
        public String Race { get; set; }
        public int CastTime{ get; set; }
        public int CdTime { get; set; }
        public int Manacost { get; set; }
        public int Healthcost { get; set; }
        public int DmgType { get; set; }
        public String Tooltip { get; set; }

    }
}