﻿using System.Web;
using System.Web.Mvc;

namespace Application_to_Manage_Data_for_School_Application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
