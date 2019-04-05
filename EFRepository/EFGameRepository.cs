using System;
using System.Collections.Generic;
using Repository;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository {
    public class EFGameRepository : EFRepository<Game>, IGameRepository {
        public EFGameRepository(HighscoreContext ctx) : base(ctx) {

        }

        public void Update(Game game) {
            throw new NotImplementedException();
        }

        public IEnumerable<GameInfo> GetGamesWithHighscore() {
            return ctx.Games.Select(game => new GameInfo() { Game = game, Points = game.Scores.Max(s => s.Points) }).ToList();
        }

        public IEnumerable<Score> GetScoresPerGame(int id) {
            return ctx.Scores.Where(s => s.Game.Id == id).ToList();
        }
    }
}
