using System;

namespace Enterprise.OA.Data.Entities
{
    public class NumberTemplate : EntityBase<int>
    {
        public virtual string Number { get; set; }

        public virtual string Description { get; set; }

        public virtual string Body { get; set; }

        public virtual int Seed { get; set; }

        public virtual NumberFormat Format { get; set; }

        public virtual string Comment { get; set; }

        public virtual DateTime CreateDate { get; set; }
    }
}
