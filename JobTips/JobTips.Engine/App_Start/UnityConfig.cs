using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using JobTips.Engine.Controllers;
using JobTips.Engine.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity.Configuration;
using Unity.WebApi;


namespace JobTips.Engine
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer().LoadConfiguration();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}