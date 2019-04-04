using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    class HighscoreInitializer : DropCreateDatabaseAlways<HighscoreContext> {
        protected override void Seed(HighscoreContext ctx) {
            base.Seed(ctx);

            User[] users = { new User { Name = "Lukas" },
                             new User { Name = "Janik" },
                             new User { Name = "Almin" }};
            ctx.Users.AddRange(users);


            Game[] games = { new Game { Name = "CS:GO" } };
            ctx.Games.AddRange(games);

            Score[] scores = { new Score { Points = 100, Game = games[0], User = users[0] }, 
                               new Score { Points = 200, Game = games[0], User = users[1] },
                               new Score { Points = 300, Game = games[0], User = users[2] }};
            ctx.Scores.AddRange(scores);

            ctx.SaveChanges();
        }
    }
}
