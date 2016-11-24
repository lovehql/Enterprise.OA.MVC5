using Enterprise.OA.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class BasicWorkflowStateMap : EntityTypeConfiguration<BasicWorkflowState>
    {
        public BasicWorkflowStateMap()
        {
            this.ToTable("oa_wfs_BasicWorkflowStates");

            this.HasKey(x => x.Id);

            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("WorkflowStateId");

            this.HasRequired(x => x.Checker).WithMany().Map(m => m.MapKey("CheckerId")).WillCascadeOnDelete(false);
        }
    }
}
