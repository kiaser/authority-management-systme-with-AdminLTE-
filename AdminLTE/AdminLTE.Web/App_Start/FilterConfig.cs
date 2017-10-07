using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminLTE.Web.Filters;

namespace AdminLTE.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {

            filters.Add(new WebAuthorizeAttribute());
        }
    }
}