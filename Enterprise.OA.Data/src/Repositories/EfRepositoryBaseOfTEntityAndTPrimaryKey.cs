using Enterprise.OA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.OA.Data.Repositories
{
    public class EfRepositoryBase<TDbContext, TEntity, TPrimaryKey> : RepositoryBase<TEntity, TPrimaryKey>, IRepositoryWithDbContext
        where TEntity : EntityBase<TPrimaryKey>
        where TDbContext : DbContext
    {
        public virtual TDbContext Context { get { return null; } }

        public virtual DbSet<TEntity> Table { get { return Context.Set<TEntity>(); } }

        public DbContext GetDbContext()
        {
            return Context;
        }

        public override IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public override TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public override void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
