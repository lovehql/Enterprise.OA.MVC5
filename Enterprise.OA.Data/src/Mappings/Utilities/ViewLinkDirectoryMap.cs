using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class ViewLinkDirectoryMap : EntityTypeConfiguration<ViewLinkDirectory>
    {
        public ViewLinkDirectoryMap()
        {
            this.ToTable("oa_utility_ViewLinkDirectories");

            this.HasKey(x => x.Id);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.IconSource).HasMaxLength(256);
            this.Property(x => x.DisplayName).HasMaxLength(256);
            this.Property(x => x.Description).HasMaxLength(512);
            this.Property(x => x.ListOrder).IsRequired();
            this.Property(x => x.AuthoriztionAction).HasMaxLength(128).IsRequired();

            this.HasMany(x => x.Children).WithOptional().Map(m => m.MapKey("ParentId"));

            this.Property(x => x.IsEnabled).IsRequired();
            this.Property(x => x.CreateDate).IsRequired();
        }
    }
}
