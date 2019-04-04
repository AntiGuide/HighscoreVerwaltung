using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    class HighscoreInitializer : DropCreateDatabaseAlways<HighscoreContext>{
        protected override void Seed(HighscoreContext ctx) {
            base.Seed(ctx);

            var u1 = new User { Name = "Lukas" };
            var u2 = new User { Name = "Janik" };
            var u3 = new User { Name = "Almin" };

            var game = new Game { Name = "CS:GO" };

            var s1 = new Score { Points = 100, Game = game, User = u1 };
            var s2 = new Score { Points = 200, Game = game, User = u2 };
            var s3 = new Score { Points = 300, Game = game, User = u3 };

            ctx.Users.Add(u1);
            ctx.Users.Add(u2);
            ctx.Users.Add(u3);

            ctx.Games.Add(game);

            ctx.Scores.Add(s1);
            ctx.Scores.Add(s2);
            ctx.Scores.Add(s3);

            ctx.SaveChanges();
        }
    }
}
