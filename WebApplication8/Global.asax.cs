using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication8.Models;

namespace WebApplication8
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Dr
            Database.SetInitializer(new VeritabaniBesle());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
