using System;
using System.Collections.Generic;
using Repository;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository {
    public class EFSessionScope : ISessionScope {
        private Lazy<HighscoreContext> ctx = new Lazy<HighscoreContext>(() => new HighscoreContext(), false);

        private Lazy<IGameRepository> gameRepository;
        private Lazy<IUserRepository> userRepository;
        private Lazy<IScoreRepository> scoreRepository;

        public IUserRepository UserRepository => userRepository.Value;
        public IGameRepository GameRepository => gameRepository.Value;
        public IScoreRepository ScoreRepository => scoreRepository.Value;

        public EFSessionScope() {
            gameRepository = new Lazy<IGameRepository>(() => new EFGameRepository(ctx.Value), false);
            userRepository = new Lazy<IUserRepository>(() => new EFUserRepository(ctx.Value), false);
            scoreRepository = new Lazy<IScoreRepository>(() => new EFScoreRepository(ctx.Value), false);
        }

        #region IDisposable Support
        private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                    // Verwalteten Zustand (verwaltete Objekte) entsorgen.
                    if (ctx.IsValueCreated) {
                        ctx.Value.Dispose();
                    }
                }

                // TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
                // TODO: große Felder auf Null setzen.

                disposedValue = true;
            }
        }

        // TODO: Finalizer nur überschreiben, wenn Dispose(bool disposing) weiter oben Code für die Freigabe nicht verwalteter Ressourcen enthält.
        // ~EFSessionScope() {
        //   // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
        //   Dispose(false);
        // }

        // Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
        public void Dispose() {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
            Dispose(true);
            // TODO: Auskommentierung der folgenden Zeile aufheben, wenn der Finalizer weiter oben überschrieben wird.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
