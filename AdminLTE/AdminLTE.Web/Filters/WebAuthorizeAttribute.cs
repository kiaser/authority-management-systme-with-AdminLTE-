using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminLTE.Core.Web;

namespace AdminLTE.Web.Filters
{
    public  class WebAuthorizeAttribute:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var aa = httpContext.Request.IsAuthenticated;
            var name = httpContext.User.Identity.Name;
            return httpContext.Request.IsAuthenticated;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                filterContext.Result = new JsonNetResult(new AjaxResult { Success = false, Message = "您未登录，请重新登录。" });
            }
            else
            {
                filterContext.Result=new RedirectResult("~/Account/Login");
            }
        }
    }
}