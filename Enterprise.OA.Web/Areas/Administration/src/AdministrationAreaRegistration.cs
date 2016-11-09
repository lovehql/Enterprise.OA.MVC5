using System.Web.Http;
using System.Web.Mvc;

namespace Enterprise.OA.Web.Administration
{
    public class AdministrationAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Administration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            RouteConfig.RegisterRoutes(context);
            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}