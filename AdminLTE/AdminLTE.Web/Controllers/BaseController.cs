using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AdminLTE.Core.Web;
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

        /// <summary>
        /// 重写 MVC 中 JsonResult的功能。
        /// </summary>
        /// <param name="data"></param>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="behavior"></param>
        /// <returns></returns>
        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonNetResult(data)
            {
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior
            };
        }


  

        /// <summary>
        /// 向客户端返回一个错误结果。
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        protected virtual JsonResult FailResult(string error)
        {
            if (error == null)
                throw new ArgumentNullException(nameof(error));

            return Json(new AjaxResult
            {
                Success = false,
                Message = error
            });
        }

        /// <summary>
        /// 向客户端返回一个正确的返回结果。
        /// </summary>
        /// <param name="data">要序列化的 JavaScript 对象图。</param>
        /// <param name="contentType">  内容类型（MIME 类型）。</param>
        /// <returns></returns>
        protected virtual JsonResult SuccessResult(object data = null, string contentType = null)
        {
            return Json(new AjaxResult
            {
                Success = true,
                Data = data
            }, contentType);
        }

        protected ActionResult ValidError()
        {
            System.Text.StringBuilder sbError = new System.Text.StringBuilder();

            foreach (ModelState modelState in this.ModelState.Values)
            {
                if (modelState.Errors.Count > 0)
                {
                    foreach (ModelError modelError in modelState.Errors)
                    {
                        if (sbError.Length > 0)
                            sbError.Append("<br />");
                        sbError.AppendFormat("{0}", modelError.ErrorMessage);
                    }
                }
            }

            return Json(new
            {
                success = false,
                message = sbError.ToString()
            });
        }
    }
}