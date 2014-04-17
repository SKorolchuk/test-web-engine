using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Web.Optimization;
using TestWebEngine.Web;

namespace TestWebEngine.Web
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);   
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}