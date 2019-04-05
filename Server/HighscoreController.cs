using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using EFRepository;
using System.Text;
using System.Threading.Tasks;

namespace Server {
    public delegate ISessionScope Factory();

    public class HighscoreController {
        private Factory factory;

        public HighscoreController(Factory factory) {
            this.factory = factory;
        }

        public User CreateUser(string name) {
            using (var scope = factory.Invoke()) {
                var user = new User { Name = name };
                return scope.UserRepository.Create(user);
            }
        }

        public Game CreateGame(string name) {
            using (var scope = factory.Invoke()) {
                var game = new Game { Name = name };
                return scope.GameRepository.Create(game);
            }
        }

        public Score CreateScore(int points, int gameid, int userid) {
            using (var scope = factory.Invoke()) {
                var score = new Score { Points = points, GameId = gameid, UserId = userid };
                return scope.ScoreRepository.Create(score);
            }
        }

        public IEnumerable<Game> GetGames() {
            using (var scope = factory.Invoke()) {
                return scope.GameRepository.GetAll();
            }
        }

        public IEnumerable<GameInfo> GetGamesWithHighscore() {
            using (var scope = factory.Invoke()) {
                return scope.GameRepository.GetGamesWithHighscore();
            }
        }

        public IEnumerable<User> GetUsers() {
            using (var scope = factory.Invoke()) {
                return scope.UserRepository.GetAll();
            }
        }

        public IEnumerable<Score> GetScoresPerGame(int gameid) {
            using (var scope = factory.Invoke()) {
                return scope.GameRepository.GetScoresPerGame(gameid);
            }
        }
        public IEnumerable<GameInfo> GetGamesPerUser(int userid) {
            using (var scope = factory.Invoke()) {
                return scope.UserRepository.GetGamesPerUser(userid);
            }
        }
        public IEnumerable<UserInfo> GetTotalScores() {
            using (var scope = factory.Invoke()) {
                return scope.ScoreRepository.GetTotalScores();
            }
        }
    }
}
