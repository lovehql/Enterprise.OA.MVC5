using Enterprise.OA.Data.Entities;
using System.Collections.Generic;

namespace Enterprise.OA.Web.Infrastructure.Service
{
    public interface IAppUserManager
    {
        ICollection<ApplicationUser> GetUsers();
    }
}
