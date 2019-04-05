using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Repository;

namespace Server {
    class HighscoreService<T> : IHighscoreService where T : ISessionScope, new() {
        private HighscoreController controller = new HighscoreController(() => new T());

        public DTO_Game CreateGame(string name) {
            return controller.CreateGame(name).ToDTO();
        }

        public DTO_Score CreateScore(int points, int gameid, int userid) {
            return controller.CreateScore(points, gameid, userid).ToDTO();
        }

        public DTO_User CreateUser(string name) {
            return Converter.ToDTO(controller.CreateUser(name));
        }

        public IEnumerable<DTO_Game> GetGames() {
            return controller.GetGames().Select(game => game.ToDTO());
        }

        public IEnumerable<DTO_GameInfo> GetGamesPerUser(int userid) {
            return controller.GetGamesPerUser(userid).Select(game => game.ToDTO());
        }

        public IEnumerable<DTO_GameInfo> GetGamesWithHighscore() {
            return controller.GetGamesWithHighscore().Select(game => game.ToDTO());
        }

        public IEnumerable<DTO_Score> GetScoresPerGame(int gameid) {
            return controller.GetScoresPerGame(gameid).Select(score => score.ToDTO());
        }

        public IEnumerable<DTO_UserInfo> GetTotalScores() {
            throw new NotImplementedException();
        }

        public IEnumerable<DTO_User> GetUsers() {
            throw new NotImplementedException();
        }
    }
}
