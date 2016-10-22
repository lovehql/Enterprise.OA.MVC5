using System;
using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class ViewLinkDirectory : EntityBase<int>
    {
        public string Number { get; set; }

        public string IconSource { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }

        public string AuthoriztionAction { get; set; }

        public virtual ICollection<ViewLinkDirectory> Children { get; set; }

        public virtual ICollection<ViewLink> Links { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
