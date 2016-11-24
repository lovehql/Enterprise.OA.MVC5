using Enterprise.OA.Data;
using Enterprise.OA.Data.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Enterprise.OA.Web.Infrastructure.Identity
{
    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext context)
            : base(context)
        { }


    }
}
