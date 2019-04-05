using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository {
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class {
        protected HighscoreContext ctx;

        public EFRepository(HighscoreContext ctx) {
            this.ctx = ctx;
        }

        public TEntity Create(TEntity entity) {
            var ret = ctx.Set<TEntity>().Add(entity);
            ctx.SaveChanges();
            return ret;
        }

        public IEnumerable<TEntity> GetAll() {
            return ctx.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id) {
            return ctx.Set<TEntity>().Find(id);
        }
    }
}
