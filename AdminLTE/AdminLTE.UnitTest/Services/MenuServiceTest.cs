using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.DAL.Menu;
using AdminLTE.UnitTest.Core;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace AdminLTE.UnitTest.Services
{
    [TestFixture]
   public class MenuServiceTest:BaseTest
    {
        private  MenuService _menuService;
        public override void SetUp()
        {
            base.SetUp();
            _menuService = new MenuService();
        }
        public override void TearDown()
        {
            base.TearDown();
            _menuService = null;
        }

        /// <summary>
        /// 获取菜单
        /// </summary>
        [Test]
        public void GetMenuByUser_return_true()
        {
            Console.WriteLine(_menuService.GetMenuByUser());
        }
    }
}
