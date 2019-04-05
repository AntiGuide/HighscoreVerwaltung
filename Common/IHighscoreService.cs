using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Repository;

namespace Common {
    [ServiceContract]
    public interface IHighscoreService {
        [OperationContract]
        DTO_User CreateUser(string name);

        [OperationContract]
        DTO_Game CreateGame(string name);

        [OperationContract]
        DTO_Score CreateScore(int points, int gameid, int userid);

        [OperationContract]
        IEnumerable<DTO_Game> GetGames();

        [OperationContract]
        IEnumerable<DTO_GameInfo> GetGamesWithHighscore();

        [OperationContract]
        IEnumerable<DTO_User> GetUsers();

        [OperationContract]
        IEnumerable<DTO_Score> GetScoresPerGame(int gameid);

        [OperationContract]
        IEnumerable<DTO_GameInfo> GetGamesPerUser(int userid);

        [OperationContract]
        IEnumerable<DTO_UserInfo> GetTotalScores();
    }
}
