using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class WorkflowInstanceMap : EntityTypeConfiguration<WorkflowInstance>
    {
        public WorkflowInstanceMap()
        {
            this.ToTable("oa_wfs_WorkflowInstances");

            this.HasKey(x => x.Id);

            this.Property(x => x.Level).IsRequired();

            this.HasRequired(x => x.Workflow).WithOptional().Map(m => m.MapKey("WorkflowId"));
            this.HasRequired(x => x.Applicant).WithMany().Map(m => m.MapKey("ApplicantId")).WillCascadeOnDelete(false);
            this.HasRequired(x => x.State).WithOptional().Map(m => m.MapKey("StateId"));
            this.HasRequired(x => x.Checker).WithMany().Map(m => m.MapKey("CheckerId")).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}
