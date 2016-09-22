using System;

namespace Enterprise.OA.Data.Entities
{
    public class DateFormattedNumberInstance : EntityBase<int>
    {
        public virtual DateFormattedNumberTemplate Template { get; set; }

        public virtual string Prefix { get; set; }

        public virtual int Seed { get; set; }

        public virtual DateTime LastGenerateDate { get; set; }
    }
}
