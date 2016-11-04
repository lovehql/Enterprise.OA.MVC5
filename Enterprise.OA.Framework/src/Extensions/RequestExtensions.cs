using Enterprise.OA.Framework.Localization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Enterprise.OA.Framework.Extensions
{
    public static class RequestExtensions
    {
        public static string LocaleUrl(this HttpRequestBase request, string culture)
        {
            Locale.SetCulture(culture);

            return OverrideUrl(request, new { culture = culture });
        }

        public static string OverrideUrl(this HttpRequestBase request, object routeValues)
        {
            return OverrideUrl(request, new RouteValueDictionary(routeValues));
        }

        public static string OverrideUrl(this HttpRequestBase request, RouteValueDictionary routeValues)
        {
            var existingRouteValues = new RouteValueDictionary(request.RequestContext.RouteData.Values);

            var queryString = request.QueryString;

            foreach (var key in queryString.AllKeys.Where(key => !string.IsNullOrWhiteSpace(key)))
            {
                existingRouteValues[key] = queryString[key];
            }

            if (routeValues != null)
            {
                foreach (KeyValuePair<string, object> routeValue in routeValues)
                {
                    existingRouteValues[routeValue.Key] = routeValue.Value;
                }
            }

            return UrlHelper.GenerateUrl(null /* routeName */, null /* actionName */, null /* controllerName */, null /* protocol */, null /* hostName */, null /* fragment */, existingRouteValues, RouteTable.Routes, request.RequestContext, false /* includeImplicitMvcValues */);
        }
    }
}
