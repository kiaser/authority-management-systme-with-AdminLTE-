using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void GetUsers_has_one_user()
        {
            var users = BaseContext.Users.ToList();

            Assert.IsTrue(users != null && users.Count > 0);

            WrileList(users.Select(t => t.UserId.ToString()),users.Select(t => t.LoginName),users.Select(t=>t.PassWord));

            //Console.WriteLine(string.Join(",",users.Select(t=>t.LoginName)));
            //Console.WriteLine(string.Join(",",users.Select(t=>t.PassWord)));
        }

    }
}
