using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class UserActionMap : EntityTypeConfiguration<UserAction>
    {
        public UserActionMap()
        {
            this.ToTable("oa_user_UserActions");

            this.Property(x => x.Name).HasMaxLength(256).IsRequired();
            this.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
