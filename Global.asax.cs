﻿using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ContactFormApp2 // Burada doğru namespace olmalı
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
