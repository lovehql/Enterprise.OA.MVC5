using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class SubsidiaryMap : EntityTypeConfiguration<Subsidiary>
    {
        public SubsidiaryMap()
        {
            this.ToTable("oa_user_Subsidiaries");

            this.HasKey(x => x.Id);
            this.Property(x => x.Number).HasMaxLength(16).IsRequired();
            this.Property(x => x.LegalName).HasMaxLength(256).IsRequired();
            this.Property(x => x.IsEnabled).IsRequired();
        }
    }
}
