using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Enterprise.OA.Framework.Localization
{
    public class LocaleRedirectRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            HttpCookie cookieLocale = requestContext.HttpContext.Request.Cookies["lang"];

            if (cookieLocale == null)
            {
                if (requestContext.HttpContext.Request.UserLanguages == null)
                {
                    return new LocaleRedirectHttpHandler(requestContext);
                }
                else
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
            }
            else
            {
                string cultureName = cookieLocale.Value;

                if (Locale.Contains(cultureName))
                {
                    return new LocaleRedirectHttpHandler(requestContext, cultureName);
                }
                else
                {
                    return new LocaleRedirectHttpHandler(requestContext);
                }
            }
        }
    }
}
