using CodoPolygon.AppConfig;
using System;
using System.Web;
using System.Web.Routing;

namespace CodoPolygon
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}