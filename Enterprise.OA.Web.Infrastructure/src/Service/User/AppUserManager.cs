using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Enterprise.OA.Data.Entities;
using Enterprise.OA.Web.Infrastructure.Identity;
using System.Web;
using Microsoft.AspNet.Identity.Owin;

namespace Enterprise.OA.Web.Infrastructure.Service
{
    public class AppUserManager : IAppUserManager
    {
        public AppUserManager(HttpContextBase httpContext)
        {
            _userManager = httpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
        }

        private ApplicationUserManager _userManager;

        protected ApplicationUserManager UserManager
        {
            get { return _userManager; }
        }

        public ICollection<ApplicationUser> GetUsers()
        {
            return UserManager.Users.ToList();
        }
    }
}
