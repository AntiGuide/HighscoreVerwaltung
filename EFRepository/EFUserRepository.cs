using System;
using System.Collections.Generic;
using Repository;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository {
    public class EFUserRepository : EFRepository<User>, IUserRepository {
        public EFUserRepository(HighscoreContext ctx) : base(ctx) {

        }

        public void Update(User entity) {
            throw new NotImplementedException();
        }

        public IEnumerable<GameInfo> GetGamesPerUser(int id) {
            return ctx.Scores.Where(s => s.UserId == id).Select(s => new GameInfo() { Game = s.Game, Points = s.Points }).ToList();
        }
    }
}
