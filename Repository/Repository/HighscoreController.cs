using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public class HighscoreController {
        public User CreateUser(string name) {
            var user = new User { Name = name };
            using (var ctx = new HighscoreContext()) {
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }

            return user;
        }

        public Game CreateGame(string name) {
            var game = new Game { Name = name };
            using (var ctx = new HighscoreContext()) {
                ctx.Games.Add(game);
                ctx.SaveChanges();
            }

            return game;
        }

        public Score CreateScore(int points, int gameid, int userid) {
            var score = new Score { Points = points, GameId = gameid, UserId = userid };
            using (var ctx = new HighscoreContext()) {
                ctx.Scores.Add(score);
                ctx.SaveChanges();
            }

            return score;
        }

        public IEnumerable<GameInfo> GetGames() {
            using (var ctx = new HighscoreContext()) {
                return ctx.Games.Select(game => new GameInfo() { Game = game, Points = game.Scores.Max(s => s.Points) }).ToList();
            }
        }

        public IEnumerable<User> GetUsers() {
            using (var ctx = new HighscoreContext()) {
                return ctx.Users.ToList();
            }
        }
        public IEnumerable<Score> GetScoresPerGame(int gameid) {
            using (var ctx = new HighscoreContext()) {
                var scores = ctx.Scores
                    .Where(s => s.Game.Id == gameid);
                return scores.ToList();
            }
        }
        public IEnumerable<GameInfo> GetGamesPerUser(int userid) {
            using (var ctx = new HighscoreContext()) {
                return ctx.Scores.Where(s => s.UserId == userid).Select(s => new GameInfo() { Game = s.Game, Points = s.Points}).ToList();
            }
        }
        public IEnumerable<UserInfo> GetTotalScores() {
            using (var ctx = new HighscoreContext()) {
                return ctx.Users.Select(u => new UserInfo() { User = u, Points = u.Scores.Sum(s => s.Points)}).OrderByDescending(ui => ui.Points).Take(10).ToList();
            }
        }
    }
}
