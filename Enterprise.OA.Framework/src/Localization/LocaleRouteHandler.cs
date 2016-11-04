using System;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Enterprise.OA.Framework.Localization
{
    public class LocaleRouteHandler : FacadeBase<IRouteHandler>, IRouteHandler
    {
        public LocaleRouteHandler(IRouteHandler routeHandler)
            : base(() => routeHandler)
        {
            if (routeHandler == null)
            {
                throw new ArgumentNullException(nameof(routeHandler));
            }
        }

        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            string cultureName = requestContext.RouteData.Values["culture"].ToString();

            HttpCookie cookieLocale = requestContext.HttpContext.Request.Cookies["lang"];

            if (string.IsNullOrWhiteSpace(cultureName))
            {
                if (cookieLocale != null)
                {
                    return new LocaleRedirectHttpHandler(requestContext, cookieLocale.Value);
                }
                else if (requestContext.HttpContext.Request.UserLanguages != null)
                {
                    foreach (string userLanguage in requestContext.HttpContext.Request.UserLanguages.Select(x => x.Split(';').First()))
                    {
                        if (Locale.Contains(userLanguage))
                        {
                            return new LocaleRedirectHttpHandler(requestContext, userLanguage);
                        }
                    }

                    return new LocaleRedirectHttpHandler(requestContext);
                }
                else
                {
                    return new LocaleRedirectHttpHandler(requestContext);
                }
            }

            try
            {
                Locale.SetCulture(cultureName);
            }
            catch (CultureNotFoundException)
            {
                return new LocaleRedirectHttpHandler(requestContext);
            }

            requestContext.HttpContext.Response.AppendCookie(new HttpCookie("lang", cultureName));

            return Kernel.GetHttpHandler(requestContext);
        }
    }
}
