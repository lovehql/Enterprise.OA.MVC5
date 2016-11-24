using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class SequentialWorkflowStateSettingMap : EntityTypeConfiguration<SequentialWorkflowStateSetting>
    {
        public SequentialWorkflowStateSettingMap()
        {
            this.ToTable("oa_wfs_SequentialWorkflowStateSettings");

            this.HasKey(x => x.Id);

            this.HasRequired(x => x.State).WithOptional().Map(m => m.MapKey("StateId"));
            this.HasRequired(x => x.Applicant).WithMany().Map(m => m.MapKey("ApplicantId")).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}
