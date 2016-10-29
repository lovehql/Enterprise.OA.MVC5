using Enterprise.OA.Framework.Localization;
using System.Web.Mvc;
using System.Web.Routing;

namespace Enterprise.OA.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            Locale.Configure("zh-cn", "en-us");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapLocaleRedirectRoute(
                name: "RedirectToLocale",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
