using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class UserRoleAction : EntityBase<int>
    {
        public UserRoleAction()
        {
            Roles = new List<ApplicationRole>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ApplicationRole> Roles { get; set; }
    }
}
