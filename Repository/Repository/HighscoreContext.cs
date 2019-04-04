﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    class HighscoreContext : DbContext{
        static HighscoreContext() {
            Database.SetInitializer<HighscoreContext>(new HighscoreInitializer());
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Score> Scores { get; set; }
    }
}
