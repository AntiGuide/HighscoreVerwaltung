using System;
using System.Collections.Generic;
using System.Data.Entity;
using Repository;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository {
    class HighscoreInitializer : DropCreateDatabaseAlways<HighscoreContext> {
        protected override void Seed(HighscoreContext ctx) {
            base.Seed(ctx);
        }
    }
}
