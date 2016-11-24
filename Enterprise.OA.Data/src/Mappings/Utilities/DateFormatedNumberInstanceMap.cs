using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class DateFormatedNumberInstanceMap : EntityTypeConfiguration<DateFormatedNumberInstance>
    {
        public DateFormatedNumberInstanceMap()
        {
            this.ToTable("oa_utility_DateFormatedNumberInstances");

            this.HasKey(x => x.Id);

            this.Property(x => x.Prefix).HasMaxLength(32).IsRequired();
            this.Property(x => x.Seed).IsRequired();
            this.Property(x => x.LastGenerateDate).IsRequired();

            this.HasRequired(x => x.Template).WithMany(y => y.Instances).Map(m => m.MapKey("TemplateId"));

            this.Property(x => x.ApplicationName).HasMaxLength(128).IsRequired();
            this.HasRequired(x => x.Subsidiary).WithMany().Map(m => m.MapKey("SubsidiaryId")).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}
