using System;
using System.Net.Mail;

namespace Enterprise.OA.Data.Entities
{
    public class MailTemplate : EntityBase<int>, ITraceable
    {
        public string Number { get; set; }

        public string Description { get; set; }

        public string Recipients { get; set; }

        public string CopyRecipients { get; set; }

        public string BlindCopyRecipients { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool IsBodyHtml { get; set; }

        public MailPriority Priority { get; set; }

        public string Comment { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual  ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}
