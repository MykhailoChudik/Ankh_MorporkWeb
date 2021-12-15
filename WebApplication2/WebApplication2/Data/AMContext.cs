using System;
using System.Collections.Generic;

using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models.AM;

namespace WebApplication2.Data
{
    public class AMContext: DbContext
    {
        public AMContext() :base("DefaultConnection")
        {
        }

        public DbSet<Assasins> Assasin { get; set; }
        public DbSet<Beggary> Beggaries { get; set; }
        public DbSet<Fools> Fool { get; set; }
        public DbSet<Player> Player { get; set; }
    }
}