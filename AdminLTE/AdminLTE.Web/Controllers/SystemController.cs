using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE.Web.Controllers
{
    public class SystemController : BaseController
    {
        // GET: System
        public new ActionResult User()
        {
            return View();
        }
    }
}