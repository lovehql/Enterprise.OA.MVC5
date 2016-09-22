using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Enterprise.OA.Web.Startup))]
namespace Enterprise.OA.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
