using System;

namespace Enterprise.OA.Data.Entities
{
    public class ViewLink : EntityBase<int>
    {
        public virtual ViewLinkDirectory Parent { get; set; }

        public string Number { get; set; }

        public string IconSource { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string ViewName { get; set; }

        public int ListOrder { get; set; }

        public string AuthoriztionAction { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
