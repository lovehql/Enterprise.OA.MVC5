using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class Subsidiary : EntityBase<int>
    {
        public Subsidiary()
        {
            Staffs = new List<UserProfile>();

            Departments = new List<Department>();
        }

        public string Number { get; set; }

        public string LegalName { get; set; }
        
        public bool IsEnabled { get; set; }
        
        public virtual ICollection<UserProfile> Staffs { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
