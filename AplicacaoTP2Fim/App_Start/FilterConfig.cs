﻿using System.Web;
using System.Web.Mvc;

namespace AplicacaoTP2Fim
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
