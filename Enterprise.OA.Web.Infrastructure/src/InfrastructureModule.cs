using Autofac;
using Autofac.Core;
using Enterprise.OA.Web.Infrastructure.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.OA.Web.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<AppUserManager>().As<IAppUserManager>();

            //builder.Register(c => new AppUserManager()).As<IAppUserManager>();
        }
    }
}
