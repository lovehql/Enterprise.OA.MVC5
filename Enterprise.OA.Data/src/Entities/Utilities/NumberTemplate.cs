using System;

namespace Enterprise.OA.Data.Entities
{
    public class NumberTemplate : EntityBase<int>
    {
        public string Number { get; set; }

        public string Description { get; set; }

        public string Body { get; set; }

        public int Seed { get; set; }

        public NumberFormat Format { get; set; }

        public string Comment { get; set; }
        
        public DateTime CreateDate { get; set; }
    }
}
