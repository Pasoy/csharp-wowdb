using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WoWDB_Web.Models
{
    public class Achievements
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Requirements { get; set; }
        public String Rewards { get; set; }
        public int AchievementPoints { get; set; }
    }
}