using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class EmergencyContactMap : EntityTypeConfiguration<EmergencyContact>
    {
        public EmergencyContactMap()
        {
            this.ToTable("oa_user_EmergencyContacts");

            this.HasKey(x => x.Id);
            this.Property(x => x.FullName).HasMaxLength(50).IsRequired();
            this.Property(x => x.Relationship).HasMaxLength(50).IsRequired();
            this.Property(x => x.Phone).HasMaxLength(20).IsRequired();
            this.Property(x => x.CreateDate).IsRequired();
        }
    }
}
