﻿using System.Web;
using System.Web.Mvc;

namespace Prueba_MVC_Music_Store
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
