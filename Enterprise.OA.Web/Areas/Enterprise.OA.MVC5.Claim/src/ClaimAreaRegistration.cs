using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enterprise.OA.MVC5.Claim
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
            //RouteConfig.RegisterRoutes(context);
            //WebApiConfig.Register();
        }
    }
}