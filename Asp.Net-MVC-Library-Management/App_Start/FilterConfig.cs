﻿using System.Web;
using System.Web.Mvc;

namespace Asp.Net_MVC_Library_Management
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
