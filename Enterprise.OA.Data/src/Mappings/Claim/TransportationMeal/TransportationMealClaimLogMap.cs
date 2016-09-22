using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class TransportationMealClaimLogMap : EntityTypeConfiguration<TransportationMealClaimLog>
    {
        public TransportationMealClaimLogMap()
        {
            ToTable("oa_wfsLog_claim_TransportationMealLogs");

            this.HasKey(x => x.Id);

            this.HasRequired(x => x.Instance).WithMany().Map(m => m.MapKey("InstanceId"));
            this.HasRequired(x => x.Origin).WithOptional().Map(m => m.MapKey("OriginId"));
            this.HasOptional(x => x.Destinagion).WithOptionalDependent().Map(m => m.MapKey("DestinagionId"));
            this.HasRequired(x => x.Checker).WithOptional().Map(m => m.MapKey("CheckerId"));
            this.HasOptional(x => x.Agent).WithOptionalDependent().Map(m => m.MapKey("AgentId"));

            this.Property<ApplicationStatus>(x => x.Status);
            this.Property(x => x.Comment).HasMaxLength(1024);
            this.Property(x => x.IpAddress).HasMaxLength(15);

            this.HasRequired(x => x.Creator).WithOptional().Map(m => m.MapKey("Creator"));
            this.Property(x => x.CreateDate).IsRequired();
            this.HasRequired(x => x.Modificator).WithOptional().Map(m => m.MapKey("Modificator"));
            this.Property(x => x.ModifyDate).IsRequired();
        }
    }
}
