using System.Web.Http;
using System.Web.Mvc;

namespace Enterprise.OA.Web.Claim
{
    public class ClaimAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Claim";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            RouteConfig.RegisterRoutes(context);
            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}