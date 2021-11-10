using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using System.Data.Entity;
using SistemaWebVuelos.Data;

namespace SistemaWebVuelos
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            Database.SetInitializer<DbVueloContext>(new DbVueloInitializer());

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
