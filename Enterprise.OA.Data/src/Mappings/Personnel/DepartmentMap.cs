using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            this.ToTable("oa_user_Departments");

            this.HasKey(x => x.Id);
            this.Property(x => x.DisplayName).HasMaxLength(256).IsRequired();
            this.Property(x => x.IsEnabled).IsRequired();

            this.HasRequired(x => x.Subsidiary).WithMany(y => y.Departments).Map(m => m.MapKey("SubsidiaryId")).WillCascadeOnDelete(false);
        }
    }
}
