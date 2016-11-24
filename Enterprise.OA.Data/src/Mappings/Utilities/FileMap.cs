using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class FileMap : EntityTypeConfiguration<File>
    {
        public FileMap()
        {
            this.ToTable("oa_utility_Files");

            this.HasKey(x => x.Id);
            this.Property(x => x.FileName).HasMaxLength(128).IsRequired();
            this.Property(x => x.ContentType).HasMaxLength(20).IsRequired();
            this.Property(x => x.ContentLength).IsRequired();
            this.Property(x => x.LocalFileUrl).HasMaxLength(256).IsRequired();
            this.Property<FileStatus>(x => x.Status).IsRequired();

            this.WithTraceable();
        }
    }
}
