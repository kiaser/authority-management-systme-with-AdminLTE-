using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model;
using AdminLTE.UnitTest.Core;
using NUnit.Framework;

namespace AdminLTE.UnitTest.Base
{
    [TestFixture]
   public class DataBaseConnectTest:BaseTest
    {
        /// <summary>
        /// 测试数据库是否连上了(目前只有一个用户)
        /// </summary>
        [Test]
        [Ignore("老旧的测试")]
        public void GetUsers_has_one_user()
        {
            //var users = BaseContext.Users.ToList();

            //Assert.IsTrue(users != null && users.Count > 0);

            //WrileList(users.Select(t => t.UserId.ToString()),users.Select(t => t.LoginName),users.Select(t=>t.PassWord));

            //Console.WriteLine(string.Join(",",users.Select(t=>t.LoginName)));
            //Console.WriteLine(string.Join(",",users.Select(t=>t.PassWord)));
        }
        [Test]
        public void GetMenus_return_true()
        {
            var menus = AdminLteContext.Menus.ToList();

            Assert.IsTrue(menus != null && menus.Count > 0);
            WrileList(menus.Select(t => t.Id.ToString()), menus.Select(t => t.MenuCode.ToString()), menus.Select(t => t.ParentMenuCode.ToString()));

        }

        [Test]
        public void GetUsers_return_true()
        {
            var users = AdminLteContext.Users.ToList();
            Assert.IsTrue(users != null && users.Count > 0);
            WrileList(users.Select(t=>t.Id.ToString()),users.Select(t=>t.LoginName),users.Select(t=>t.PassWord));

        }

    }
}
