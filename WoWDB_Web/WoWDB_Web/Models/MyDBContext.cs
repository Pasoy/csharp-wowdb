using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WoWDB_Web.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() {}

        public DbSet<Character> Characters { get; set; }
    }
}