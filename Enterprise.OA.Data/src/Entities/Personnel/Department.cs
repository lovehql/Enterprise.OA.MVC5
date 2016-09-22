using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class Department : EntityBase<int>
    {
        public Department()
        {
            Staffs = new List<UserProfile>();
        }

        public virtual string DisplayName { get; set; }

        public virtual bool IsEnabled { get; set; }

        public virtual Subsidiary Subsidiary { get; set; }
        
        public virtual IList<UserProfile> Staffs { get; set; }
    }
}
