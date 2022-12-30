using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace UserSecretManagementAspNetMVC5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var values = ReadFromSecretFile();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private (string identityServer4ClientId, string identityServer4ClientSecret) ReadFromSecretFile()
        {
            var clientId = ConfigurationSettings.AppSettings.Get("IdentityServer4ClientId");
            var clientSecret = ConfigurationSettings.AppSettings.Get("IdentityServer4ClientSecret");

            return (clientId, clientSecret);
        }
    }
}
