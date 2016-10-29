using Enterprise.OA.Framework.Localization;
using System.Web.Routing;

namespace System.Web.Mvc
{
    public static class RouteCollectionExtensions
    {
        public static Route MapLocaleRoute(this RouteCollection routes, string name, string url)
        {
            return MapLocaleRoute(routes, name, url, null /* defaults */, (object)null /* constraints */);
        }

        public static Route MapLocaleRoute(this RouteCollection routes, string name, string url, object defaults)
        {
            return MapLocaleRoute(routes, name, url, defaults, (object)null /* constraints */);
        }

        public static Route MapLocaleRoute(this RouteCollection routes, string name, string url, object defaults, object constraints)
        {
            return MapLocaleRoute(routes, name, url, defaults, constraints, null /* namespaces */);
        }

        public static Route MapLocaleRoute(this RouteCollection routes, string name, string url, string[] namespaces)
        {
            return MapLocaleRoute(routes, name, url, null /* defaults */, null /* constraints */, namespaces);
        }

        public static Route MapLocaleRoute(this RouteCollection routes, string name, string url, object defaults, string[] namespaces)
        {
            return MapLocaleRoute(routes, name, url, defaults, null /* constraints */, namespaces);
        }

        public static Route MapLocaleRoute(this RouteCollection routes, string name, string url, object defaults, object constraints, string[] namespaces)
        {
            Route route = routes.MapRoute(name, url, defaults, constraints, namespaces);

            route.RouteHandler = new LocaleRouteHandler(route.RouteHandler);

            return route;
        }

        public static Route MapLocaleRedirectRoute(this RouteCollection routes, string name, string url)
        {
            return MapLocaleRedirectRoute(routes, name, url, null /* defaluts */, (object)null /* constraints */);
        }
        
        public static Route MapLocaleRedirectRoute(this RouteCollection routes, string name, string url, object defaults)
        {
            return MapLocaleRedirectRoute(routes, name, url, defaults, (object)null /* constraints */);
        }

        public static Route MapLocaleRedirectRoute(this RouteCollection routes, string name, string url, object defaults, object constraints)
        {
            return MapLocaleRedirectRoute(routes, name, url, defaults, constraints, null /* namespaces */);
        }

        public static Route MapLocaleRedirectRoute(this RouteCollection routes, string name, string url, string[] namespaces)
        {
            return MapLocaleRedirectRoute(routes, name, url, null /* defaults */, null /* constraints */, namespaces);
        }

        public static Route MapLocaleRedirectRoute(this RouteCollection routes, string name, string url, object defaults, string[] namespaces)
        {
            return MapLocaleRedirectRoute(routes, name, url, defaults, null /* constraints */, namespaces);
        }

        public static Route MapLocaleRedirectRoute(this RouteCollection routes, string name, string url, object defaults, object constraints, string[] namespaces)
        {
            Route route = routes.MapRoute(name, url, defaults, constraints, namespaces);

            route.RouteHandler = new LocaleRedirectRouteHandler();

            return route;
        }

        public static Route MapLocaleRoute(this AreaRegistrationContext context, string name, string url)
        {
            return MapLocaleRoute(context, name, url, null /* defaults */, (object)null /* constraints */);
        }

        public static Route MapLocaleRoute(this AreaRegistrationContext context, string name, string url, object defaults)
        {
            return MapLocaleRoute(context, name, url, defaults, (object)null /* constraints */);
        }

        public static Route MapLocaleRoute(this AreaRegistrationContext context, string name, string url, object defaults, object constraints)
        {
            return MapLocaleRoute(context, name, url, defaults, constraints, null /* namespaces */);
        }

        public static Route MapLocaleRoute(this AreaRegistrationContext context, string name, string url, string[] namespaces)
        {
            return MapLocaleRoute(context, name, url, null /* defaults */, null /* constraints */, namespaces);
        }

        public static Route MapLocaleRoute(this AreaRegistrationContext context, string name, string url, object defaults, string[] namespaces)
        {
            return MapLocaleRoute(context, name, url, defaults, null /* constraints */, namespaces);
        }

        public static Route MapLocaleRoute(this AreaRegistrationContext context, string name, string url, object defaults, object constraints, string[] namespaces)
        {
            Route route = context.MapRoute(name, url, defaults, constraints, namespaces);

            route.RouteHandler = new LocaleRouteHandler(route.RouteHandler);

            return route;
        }

        public static Route MapLocaleRedirectRoute(this AreaRegistrationContext context, string name, string url)
        {
            return MapLocaleRedirectRoute(context, name, url, null /* defaults */, (object)null /* constraints */);
        }

        public static Route MapLocaleRedirectRoute(this AreaRegistrationContext context, string name, string url, object defaults)
        {
            return MapLocaleRedirectRoute(context, name, url, defaults, (object)null /* constraints */);
        }

        public static Route MapLocaleRedirectRoute(this AreaRegistrationContext context, string name, string url, object defaults, object constraints)
        {
            return MapLocaleRedirectRoute(context, name, url, defaults, constraints, null /* namespaces */);
        }

        public static Route MapLocaleRedirectRoute(this AreaRegistrationContext context, string name, string url, string[] namespaces)
        {
            return MapLocaleRedirectRoute(context, name, url, null /* defaults */, null /* constraints */, namespaces);
        }

        public static Route MapLocaleRedirectRoute(this AreaRegistrationContext context, string name, string url, object defaults, string[] namespaces)
        {
            return MapLocaleRedirectRoute(context, name, url, defaults, null /* constraints */, namespaces);
        }

        public static Route MapLocaleRedirectRoute(this AreaRegistrationContext context, string name, string url, object defaults, object constraints, string[] namespaces)
        {
            Route route = context.MapRoute(name, url, defaults, constraints, namespaces);

            route.RouteHandler = new LocaleRedirectRouteHandler();

            return route;
        }
    }
}
