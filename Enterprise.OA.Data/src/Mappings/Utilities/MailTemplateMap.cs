using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;
using System.Net.Mail;

namespace Enterprise.OA.Data.Mappings
{
    public class MailTemplateMap : EntityTypeConfiguration<MailTemplate>
    {
        public MailTemplateMap()
        {
            this.ToTable("oa_utility_MailTemplates");

            this.HasKey(x => x.Id);
            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.Description).HasMaxLength(128).IsRequired();
            this.Property(x => x.Recipients).HasMaxLength(256);
            this.Property(x => x.CopyRecipients).HasMaxLength(256);
            this.Property(x => x.BlindCopyRecipients).HasMaxLength(256);
            this.Property(x => x.Subject).HasMaxLength(256).IsRequired();
            this.Property(x => x.Body).HasMaxLength(1024).IsRequired();
            this.Property(x => x.IsBodyHtml).IsRequired();
            this.Property<MailPriority>(x => x.Priority).IsRequired();
            this.Property(x => x.Comment).HasMaxLength(1024);

            this.WithTraceable();
        }
    }
}
