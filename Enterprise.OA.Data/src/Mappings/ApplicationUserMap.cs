using Enterprise.OA.Data.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class ApplicationUserMap : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserMap()
        {
            this.ToTable("AspNetUsers");

            this.HasMany(x => x.UserRoles);

            this.HasOptional(x => x.UserProfile).WithOptionalDependent().Map(x => x.MapKey("UserProfileId")).WillCascadeOnDelete();
        }
    }
}
