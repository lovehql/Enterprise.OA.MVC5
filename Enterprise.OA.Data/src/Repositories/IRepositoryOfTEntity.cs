using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.OA.Data.Repositories
{
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class
    {
    }
}
