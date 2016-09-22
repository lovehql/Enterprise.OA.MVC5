using Enterprise.OA.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class SequentialWorkflowStateMap : EntityTypeConfiguration<SequentialWorkflowState>
    {
        public SequentialWorkflowStateMap()
        {
            this.ToTable("oa_wfs_SequentialWorkflowStates");

            this.HasKey(x => x.Id);

            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("WorkflowStateId");
        }
    }
}
