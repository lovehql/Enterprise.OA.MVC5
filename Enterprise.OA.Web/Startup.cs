using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Enterprise.OA.Web.Infrastructure;
using Microsoft.Owin;
using Owin;
using System.Linq;
using System.Reflection;
using System.Web.Compilation;
using System.Web.Http;
using System.Web.Mvc;

[assembly: OwinStartupAttribute(typeof(Enterprise.OA.Web.Startup))]
namespace Enterprise.OA.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToArray();

            //builder.RegisterAssemblyTypes(assemblies);

            // STANDARD MVC SETUP:

            // Register your MVC controllers.

            builder.RegisterControllers(assemblies);

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            builder.RegisterModule<InfrastructureModule>();

            // STANDARD WEB API SETUP:

            // Get your HttpConfiguration. In OWIN, you'll create one
            // rather than using GlobalConfiguration.
            var config = new HttpConfiguration();

            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            // Run other optional steps, like registering model binders,
            // web abstractions, etc., then set the dependency resolver
            // to be Autofac.
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            // OWIN MVC SETUP:

            // Register the Autofac middleware FIRST, then the Autofac MVC middleware.
            app.UseAutofacMiddleware(container);

            app.UseAutofacMvc();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            // OWIN WEB API SETUP:
            app.UseAutofacWebApi(config);

            app.UseWebApi(config);

            ConfigureAuth(app);
        }
    }
}
