﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace MvcApplication2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.EnableCors(new EnableCorsAttribute("http://localhost:4200", "*", "*"));
        }
    }
}
