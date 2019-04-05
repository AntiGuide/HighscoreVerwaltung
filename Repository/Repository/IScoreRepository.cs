using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface IScoreRepository : IRepository<Score>{
        void Update(Score entity);
        IEnumerable<Score> GetByUserIdSorted(int userId, int first = 0, int length = 10);
        IEnumerable<UserInfo> GetTotalScores();
    }
}
