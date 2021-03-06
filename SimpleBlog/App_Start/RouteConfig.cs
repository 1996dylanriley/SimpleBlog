﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Controllers;

namespace SimpleBlog
{
    public class RouteConfig
    {
       
        public static void RegisterRoutes(RouteCollection routes)

        {
            string[] namespaces = new[] { typeof(PostsController).Namespace };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Login", "login", new { Controller = "Auth", Action = "login" }, namespaces);
            routes.MapRoute("Logout", "logout", new { Controller = "Auth", Action = "Logout" }, namespaces);

            routes.MapRoute("Home", "", new {Controller = "Posts", Action = "Index"}, namespaces );
        }
    }
}
