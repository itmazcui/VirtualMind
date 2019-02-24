using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VirtualMindAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "CotizacionMoneda",
                routeTemplate: "api/{controller}/{id}/{moneda}",
                defaults: new { id = RouteParameter.Optional, moneda = string.Empty }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            
        }
    }
}
