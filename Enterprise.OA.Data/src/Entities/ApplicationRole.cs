using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base()
        {
            Actions = new List<UserRoleAction>();
        }

        public ApplicationRole(string name, string description) : base(name)
        {
            Description = description;
        }
        
        public string Description { get; set; }

        public virtual ICollection<UserRoleAction> Actions { get; set; }
    }
}
