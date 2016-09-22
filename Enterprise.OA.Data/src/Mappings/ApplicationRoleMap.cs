using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class ApplicationRoleMap : EntityTypeConfiguration<ApplicationRole>
    {
        public ApplicationRoleMap()
        {
            this.ToTable("AspNetRoles");

            this.HasKey(x => x.Id);
            this.Property(x => x.Description).HasMaxLength(512);

            this.HasMany(x => x.Actions).WithMany(y => y.Roles).Map(m => m.ToTable("oa_user_RoleInActions").MapLeftKey("RoleId").MapRightKey("ActionId"));
        }
    }
}
