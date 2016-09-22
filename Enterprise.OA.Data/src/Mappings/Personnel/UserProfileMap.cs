using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class UserProfileMap : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMap()
        {
            this.ToTable("oa_user_UserProfiles");

            this.HasKey(x => x.Id);
            this.Property(x => x.FullName).HasMaxLength(50).IsRequired();
            this.Property(x => x.Alias).HasMaxLength(128);
            this.Property(x => x.StaffNumber).HasMaxLength(12);
            this.Property<Gender>(x => x.Gender).IsRequired();
            this.Property(x => x.Birthday).IsRequired();
            this.Property<MaritalStatus>(x => x.MaritalStatus).IsRequired();

            this.Property(x => x.Nationality).HasMaxLength(50);
            this.Property(x => x.IdentityNumber).HasMaxLength(50);
            this.Property(x => x.Qualification).HasMaxLength(50);
            this.Property(x => x.AddressLine1).HasMaxLength(512);
            this.Property(x => x.AddressLine2).HasMaxLength(512);
            this.Property(x => x.AddressLine3).HasMaxLength(512);
            this.HasMany(x => x.EmergencyContacts).WithRequired(y => y.UserProfile).Map(m => m.MapKey("UserProfileId"));

            this.HasRequired(x => x.Subsidiary).WithMany(y => y.Staffs).Map(m => m.MapKey("SubsidiaryId"));
            this.HasRequired(x => x.Department).WithMany(y => y.Staffs).Map(m => m.MapKey("DepartmentId"));
            this.Property(x => x.JobPosition).HasMaxLength(50);
            this.Property<EmploymentGrade>(x => x.Grade).IsRequired();
            this.Property<UserStatus>(x => x.Status).IsRequired();
            this.Property(x => x.JoinDate).IsRequired();
            this.Property(x => x.ResignDate);
            this.HasOptional(x => x.Agent).WithMany(y => y.AgentFors).Map(m => m.MapKey("AgentId"));
        }
    }
}
