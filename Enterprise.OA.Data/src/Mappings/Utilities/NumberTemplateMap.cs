using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class NumberTemplateMap : EntityTypeConfiguration<NumberTemplate>
    {
        public NumberTemplateMap()
        {
            this.ToTable("oa_utility_NumberTemplates");

            this.HasKey(x => x.Id);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.Description).HasMaxLength(512).IsRequired();
            this.Property(x => x.Body).HasMaxLength(128).IsRequired();
            this.Property(x => x.Seed).IsRequired();
            this.Property<NumberFormat>(x => x.Format).IsRequired();
            this.Property(x => x.Comment).HasMaxLength(1024);
            this.Property(x => x.CreateDate);
        }
    }
}
