using System;
using System.Collections.Generic;
using Repository;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository {
    public class EFScoreRepository : EFRepository<Score>, IScoreRepository {
        public EFScoreRepository(HighscoreContext ctx) : base(ctx) {

        }

        public IEnumerable<Score> GetByUserIdSorted(int userId, int first = 0, int length = 10) {
            throw new NotImplementedException();
        }

        public IEnumerable<UserInfo> GetTotalScores() {
            return ctx.Users.Select(u => new UserInfo() { User = u, Points = u.Scores.Sum(s => s.Points) }).OrderByDescending(ui => ui.Points).Take(10).ToList();
        }

        public void Update(Score entity) {
            throw new NotImplementedException();
        }
    }
}
