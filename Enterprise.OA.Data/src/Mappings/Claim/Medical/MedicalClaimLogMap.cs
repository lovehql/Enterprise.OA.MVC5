using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class MedicalClaimLogMap : EntityTypeConfiguration<MedicalClaimLog>
    {
        public MedicalClaimLogMap()
        {
            ToTable("oa_wfsLog_claim_MedicalLogs");

            this.HasKey(x => x.Id);

            this.HasRequired(x => x.Instance).WithMany().Map(m => m.MapKey("InstanceId"));
            this.HasRequired(x => x.Origin).WithOptional().Map(m => m.MapKey("OriginId"));
            this.HasOptional(x => x.Destinagion).WithOptionalDependent().Map(m => m.MapKey("DestinagionId"));
            this.HasRequired(x => x.Checker).WithMany().Map(m => m.MapKey("CheckerId"));
            this.HasOptional(x => x.Agent).WithMany().Map(m => m.MapKey("AgentId"));

            this.Property<ApplicationStatus>(x => x.Status);
            this.Property(x => x.Comment).HasMaxLength(1024);
            this.Property(x => x.IpAddress).HasMaxLength(15);

            this.WithTraceable();
        }
    }
}
