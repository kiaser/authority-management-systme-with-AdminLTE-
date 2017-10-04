using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE.Web.Controllers
{
    public class NovelController : BaseController
    {
        // GET: Novel
        public ActionResult Manager()
        {
            return View();
        }
    }
}