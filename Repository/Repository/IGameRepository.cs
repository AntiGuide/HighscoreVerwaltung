using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface IGameRepository : IRepository<Game>{
        void Update(Game entity);
        IEnumerable<Score> GetScoresPerGame(int id);
        IEnumerable<GameInfo> GetGamesWithHighscore();
    }
}
