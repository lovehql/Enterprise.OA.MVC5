using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class SequentialLevelMap : EntityTypeConfiguration<SequentialLevel>
    {
        public SequentialLevelMap()
        {
            this.ToTable("oa_wfs_SequentialLevels");

            this.HasKey(x => x.Id);

            this.Property(x => x.Level).IsRequired();

            this.HasRequired(x => x.Setting).WithMany(y => y.Sequences).Map(m => m.MapKey("SettingId"));
            this.HasRequired(x => x.Checker).WithMany().Map(m => m.MapKey("CheckerId")).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}
