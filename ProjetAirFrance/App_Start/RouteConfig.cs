using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetAirFrance
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );

            routes.MapRoute("Trajets", "{controller}/{action}/{id}",
               defaults: new { controller = "Trajets", action = "Trajets", id = UrlParameter.Optional });

            routes.MapRoute("About", "About/{id}",
               defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional });

            routes.MapRoute("Contact", "Contact/{id}",
               defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional });


        }
    }
}
