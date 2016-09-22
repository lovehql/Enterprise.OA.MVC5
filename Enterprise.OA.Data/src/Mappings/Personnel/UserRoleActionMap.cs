using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class UserRoleActionMap : EntityTypeConfiguration<UserRoleAction>
    {
        public UserRoleActionMap()
        {
            this.ToTable("oa_user_UserRoleActions");

            this.Property(x => x.Name).HasMaxLength(256).IsRequired();
            this.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
