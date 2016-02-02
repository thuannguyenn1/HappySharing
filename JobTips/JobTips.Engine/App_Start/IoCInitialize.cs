using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Configuration;
using Autofac.Integration.WebApi;

namespace JobTips.Engine
{
    public class IoCInitialize
    {
        public static void RegisteIoC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.Register()
            var container = builder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}