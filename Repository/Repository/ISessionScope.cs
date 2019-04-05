using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface ISessionScope : IDisposable {
        IUserRepository UserRepository { get; }
        IGameRepository GameRepository { get; }
        IScoreRepository ScoreRepository { get; }
    }
}
