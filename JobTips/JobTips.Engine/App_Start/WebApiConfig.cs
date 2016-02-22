using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Owin.Security.OAuth;


namespace JobTips.Engine
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            
            //Enable CORS
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "webapi/api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
