using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface IUserRepository : IRepository<User>{
        void Update(User entity);
        IEnumerable<GameInfo> GetGamesPerUser(int id);
    }
}
