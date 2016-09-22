using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class ApplicationUserRoleMap : EntityTypeConfiguration<ApplicationUserRole>
    {
        public ApplicationUserRoleMap()
        {
            this.ToTable("AspNetUserRoles");

            this.HasKey(x => new { UserId = x.UserId, RoleId = x.RoleId });
        }
    }
}
