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
using System.Data.Entity;
using Enterprise.OA.Data;
using System.Collections;
using Enterprise.OA.Web.Infrastructure.Dtos;
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace Enterprise.OA.Web.Infrastructure.Services
{
    public class AppUserManager : IAppUserManager
    {
        public AppUserManager(HttpContextBase httpContext)
        {
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext));

            _userManager = httpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
        }

        private ApplicationUserManager _userManager;

        protected ApplicationUserManager UserManager
        {
            get { return _userManager; }
        }

        protected DbContext AppDbContext
        {
            get { return new ApplicationDbContext(); }
        }

        public async Task<ICollection<UserProfileDto>> GetUsersAsync()
        {
            //IEnumerable result = await UserManager.Users
            //    .Include(x => x.UserProfile)
            //    .Include(x => x.UserProfile.Subsidiary)
            //    .Include(x => x.UserProfile.Department)
            //    .Select(m => new {
            //        UserName = m.UserName,

            //        Email = m.Email
            //    }).ToListAsync();

            Mapper.CreateMap<ApplicationUser, UserProfileDto>();

            var result = await UserManager.Users
                .Include(x=>x.UserProfile)
                .Project().To<UserProfileDto>()
                .ToListAsync();
            
            return result;
            
            //return await UserManager.Users
            //    .Include(x => x.UserProfile)
            //    .Include(x => x.UserProfile.Subsidiary)
            //    .Include(x => x.UserProfile.Department)
            //    .Select(m => new { })
            //    .ToListAsync();
        }
    }
}
