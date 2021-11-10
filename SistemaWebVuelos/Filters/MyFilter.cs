using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Diagnostics;

namespace SistemaWebVuelos.Filters
{
    public class MyFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var vueloController = filterContext.RouteData.Values["Controller"];
            var vueloAction = filterContext.RouteData.Values["Values"];
            Debug.WriteLine($"Controller: {vueloController}\nAction: {vueloAction}\n Paso por OnActionExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var vueloController = filterContext.RouteData.Values["Controller"];
            var vueloAction = filterContext.RouteData.Values["Values"];
            Debug.WriteLine($"Controller: {vueloController}\nAction: {vueloAction}\n Paso por OnActionExecuted");
        }
    }
}