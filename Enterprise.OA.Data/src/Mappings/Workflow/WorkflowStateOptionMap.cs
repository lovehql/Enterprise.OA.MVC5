using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class WorkflowStateOptionMap : EntityTypeConfiguration<WorkflowStateOption>
    {
        public WorkflowStateOptionMap()
        {
            this.ToTable("oa_wfs_WorkflowStateOptions");

            this.HasKey(x => x.Id);

            this.Property(x => x.Priority).IsRequired();
            this.Property(x => x.Eval).HasMaxLength(1024).IsRequired();

            this.HasRequired(x => x.State).WithMany(y => y.Options).Map(m => m.MapKey("StateId"));
            this.HasRequired(x => x.Destinagion).WithOptional().Map(m => m.MapKey("DestinagionId"));

            this.WithTraceable();
        }
    }
}
