using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.Model;
using AdminLTE.UnitTest.Core;
using NUnit.Framework;

namespace AdminLTE.UnitTest.Services
{
    public class DemoTest : BaseTest
    {
        private AdminLteContext _adminLteContext;

        public override void SetUp()
        {
            base.SetUp();
            _adminLteContext = new AdminLteContext();

        }

        public override void TearDown()
        {
            base.TearDown();
            _adminLteContext = null;
        }

        [Test]
        public void User_has_one_person()
        {
            var users = _adminLteContext.Users.ToList();

            Assert.IsTrue(users != null && users.Count > 0);

            WrileList(users.Select(t=>t.LoginName),users.Select(t=>t.PassWord));
        }
    }
}
