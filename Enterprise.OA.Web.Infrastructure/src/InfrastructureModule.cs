using Autofac;
using Enterprise.OA.Web.Infrastructure.Services;

namespace Enterprise.OA.Web.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<AppUserManager>().As<IAppUserManager>();
        }
    }
}
