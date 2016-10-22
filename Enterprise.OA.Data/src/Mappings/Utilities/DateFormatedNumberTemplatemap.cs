using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class DateFormatedNumberTemplateMap : EntityTypeConfiguration<DateFormatedNumberTemplate>
    {
        public DateFormatedNumberTemplateMap()
        {
            this.ToTable("oa_utility_DateFormatedNumberTemplates");

            this.Property(x => x.ResetCriterion).HasMaxLength(128).IsRequired();
        }
    }
}
