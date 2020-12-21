using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace StatTracker.Models
{
    public class StatTrackerContext : DbContext
    {

        public StatTrackerContext()

        {

        }

        //Entities

        public DbSet<Game> Games { get; set; }

        public DbSet<Player> Players { get; set; }
    }
}