using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Enterprise.OA.Framework.Localization
{
    public class LocaleRedirectHttpHandler : FacadeBase<string>, IHttpHandler
    {
        private LocaleRedirectHttpHandler(string url)
            : base(() => url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException(nameof(url));
        }

        public LocaleRedirectHttpHandler(RequestContext requestContext, string cultureName)
            : this(BuildUrl(requestContext, cultureName))
        { }

        public LocaleRedirectHttpHandler(RequestContext requestContext)
            : this(requestContext, Locale.DefaultCulture.Name)
        { }

        public bool IsReusable { get { return true; } }

        public void ProcessRequest(HttpContext httpContext)
        {
            httpContext.Response.Redirect(Kernel);
        }

        private static string BuildUrl(RequestContext requestContext, string cultureName)
        {
            if (requestContext == null)
                throw new ArgumentNullException(nameof(requestContext));

            if (string.IsNullOrWhiteSpace(cultureName))
                throw new ArgumentNullException(nameof(cultureName));

            RouteValueDictionary routeValues = requestContext.RouteData.Values;

            requestContext.RouteData.Values["culture"] = cultureName;

            return new UrlHelper(requestContext).RouteUrl(routeValues);
        }
    }
}
