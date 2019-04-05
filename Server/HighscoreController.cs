using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using EFRepository;
using System.Text;
using System.Threading.Tasks;

namespace Server {
    public class HighscoreController {
        public User CreateUser(string name) {
            using (var ctx = new HighscoreContext()) {
                IUserRepository userRepository = new EFUserRepository(ctx);
                var user = new User { Name = name };
                return userRepository.Create(user);
            }
        }

        public Game CreateGame(string name) {
            using (var ctx = new HighscoreContext()) {
                IGameRepository gameRepository = new EFGameRepository(ctx);
                var game = new Game { Name = name };
                return gameRepository.Create(game);
            }
        }

        public Score CreateScore(int points, int gameid, int userid) {
            using (var ctx = new HighscoreContext()) {
                var scoreRepository = new EFScoreRepository(ctx);
                var score = new Score { Points = points, GameId = gameid, UserId = userid };
                return scoreRepository.Create(score);
            }
        }

        public IEnumerable<Game> GetGames() {
            using (var ctx = new HighscoreContext()) {
                IGameRepository gameRepository = new EFGameRepository(ctx);
                return gameRepository.GetAll();
            }
        }

        public IEnumerable<GameInfo> GetGamesWithHighscore() {
            using (var ctx = new HighscoreContext()) {
                IGameRepository gameRepository = new EFGameRepository(ctx);
                return gameRepository.GetGamesWithHighscore();
            }
        }

        public IEnumerable<User> GetUsers() {
            using (var ctx = new HighscoreContext()) {
                IUserRepository userRepository = new EFUserRepository(ctx);
                return userRepository.GetAll();
            }
        }

        public IEnumerable<Score> GetScoresPerGame(int gameid) {
            using (var ctx = new HighscoreContext()) {
                IGameRepository gameRepository = new EFGameRepository(ctx);
                return gameRepository.GetScoresPerGame(gameid);
            }
        }
        public IEnumerable<GameInfo> GetGamesPerUser(int userid) {
            using (var ctx = new HighscoreContext()) {
                IUserRepository userRepository = new EFUserRepository(ctx);
                return userRepository.GetGamesPerUser(userid);
            }
        }
        public IEnumerable<UserInfo> GetTotalScores() {
            using (var ctx = new HighscoreContext()) {
                IScoreRepository scoreRepository = new EFScoreRepository(ctx);
                return scoreRepository.GetTotalScores();
            }
        }
    }
}
