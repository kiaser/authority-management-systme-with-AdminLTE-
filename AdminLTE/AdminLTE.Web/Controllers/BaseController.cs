using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminLTE.DAL.Menu;

namespace AdminLTE.Web.Controllers
{
    public class BaseController : Controller
    {
        private MenuService _menuService = new MenuService();
        // GET: Base
        public BaseController()
        {
            ViewBag.Menus = _menuService.GetMenuByUser();
        }
    }
}