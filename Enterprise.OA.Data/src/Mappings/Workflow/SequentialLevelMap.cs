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
            this.HasRequired(x => x.Checker).WithOptional().Map(m => m.MapKey("CheckerId"));

            this.HasRequired(x => x.Creator).WithOptional().Map(m => m.MapKey("Creator"));
            this.Property(x => x.CreateDate).IsRequired();
            this.HasRequired(x => x.Modificator).WithOptional().Map(m => m.MapKey("Modificator"));
            this.Property(x => x.ModifyDate).IsRequired();
        }
    }
}
