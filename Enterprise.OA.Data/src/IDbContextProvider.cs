using System.Data.Entity;

namespace Enterprise.OA.Data
{
    public interface IDbContextProvider<out TDbContext>
        where TDbContext : DbContext
    {
        TDbContext GetDbContext();
    }
}
