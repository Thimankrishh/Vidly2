using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                "MoviesRoute",
                "Movies",
                new {Controller = "Home", Action = "MoviesList"}
            );

            routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new {Controller = "Movies", Action = "ByReleaseDate"},
                new { year = @"2015|2018",month = @"\d{2}"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
