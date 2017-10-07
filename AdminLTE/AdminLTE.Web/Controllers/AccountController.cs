using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AdminLTE.DAL.User;
using AdminLTE.Web.Models;

namespace AdminLTE.Web.Controllers
{
    [AllowAnonymous]
    public class AccountController : BaseController
    {
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (loginViewModel == null) throw new ArgumentNullException(nameof(loginViewModel));

            if (ModelState.IsValid == false) return ValidError();

            UserService userService = new UserService();

            var user = userService.GetUser(t => t.LoginName == loginViewModel.Email);

            if (user == null)
                return FailResult("用户不存在。");

            if (string.Equals(user.PassWord, loginViewModel.Password) == false)
                return FailResult("密码错误。");

            FormsAuthentication.SetAuthCookie(user.LoginName, false);



            return Redirect("~/Home/Index");
        }
    }
}