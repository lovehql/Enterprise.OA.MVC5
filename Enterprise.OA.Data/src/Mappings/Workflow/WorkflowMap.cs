using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class WorkflowMap : EntityTypeConfiguration<Workflow>
    {
        public WorkflowMap()
        {
            this.ToTable("oa_wfs_Workflows");

            this.HasKey(x => x.Id);

            this.Property(x => x.DisplayName).HasMaxLength(50).IsRequired();
            this.Property(x => x.ApplicationName).HasMaxLength(128);

            this.HasRequired(x => x.InitialState).WithOptional().Map(m => m.MapKey("InitialStateId"));

            this.Property(x => x.Comment).HasMaxLength(512);

            this.WithTraceable();
        }
    }
}
