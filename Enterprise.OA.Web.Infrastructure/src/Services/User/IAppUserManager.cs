using Enterprise.OA.Web.Infrastructure.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Enterprise.OA.Web.Infrastructure.Services
{
    public interface IAppUserManager
    {
        Task<ICollection<UserProfileDto>> GetUsersAsync();
    }
}
