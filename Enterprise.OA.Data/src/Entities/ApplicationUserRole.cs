using Microsoft.AspNet.Identity.EntityFramework;

namespace Enterprise.OA.Data.Entities
{
    public class ApplicationUserRole : IdentityUserRole
    {
        public ApplicationUserRole() : base() { }
        
        public virtual ApplicationRole Role { get; set; }
    }
}
