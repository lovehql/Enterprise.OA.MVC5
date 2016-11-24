using System;

namespace Enterprise.OA.Data.Entities
{
    public class DateFormatedNumberInstance : EntityBase<int>, ITraceable
    {
        public virtual DateFormatedNumberTemplate Template { get; set; }

        public string Prefix { get; set; }

        public int Seed { get; set; }

        public DateTime LastGenerateDate { get; set; }

        public string ApplicationName { get; set; }

        public virtual Subsidiary Subsidiary { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}
