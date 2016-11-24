using System.Data.Entity;

namespace Enterprise.OA.Data.Repositories
{
    public interface IRepositoryWithDbContext
    {
        DbContext GetDbContext();
    }
}
