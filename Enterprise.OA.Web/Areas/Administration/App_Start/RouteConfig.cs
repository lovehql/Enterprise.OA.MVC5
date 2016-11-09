using System.Web.Mvc;

namespace Enterprise.OA.Web.Administration
{
    public class RouteConfig
    {
        public static void RegisterRoutes(AreaRegistrationContext context)
        {
            context.MapLocaleRoute(
                name: "admin_user_list",
                url: "Admin/User/Index",
                defaults: new { area = "Administration", controller = "User", action = "Index" },
                namespaces: new[] { "Enterprise.OA.Web.Administration.Controllers" }
            );
        }
    }
}
