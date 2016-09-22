using Enterprise.OA.Data.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Reflection;

namespace Enterprise.OA.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() 
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<IdentityUser>().ToTable("AspNetUsers");

            //modelBuilder.Entity<IdentityUserRole>().HasKey(x => new { UserId = x.UserId, RoleId = x.RoleId }).ToTable("AspNetUserRoles");

            //var userLogin = modelBuilder.Entity<IdentityUserLogin>();

            //userLogin.HasKey(x =>
            //new {
            //    UserId = x.UserId,
            //    LoginProvider = x.LoginProvider,
            //    ProviderKey = x.ProviderKey
            //}).ToTable("AspNetUserLogins");

            //modelBuilder.Entity<IdentityUserClaim>().ToTable("AspNetUserClaims");

            //modelBuilder.Entity<IdentityRole>().ToTable("AspNetRoles");
            
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
