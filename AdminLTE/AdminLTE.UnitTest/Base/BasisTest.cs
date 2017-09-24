using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.UnitTest.Core;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace AdminLTE.UnitTest.Base
{
    [TestFixture]
   public class BasisTest:BaseTest
    {
        //app.config错误  resharper会报错
        [Test]
        public void WriteList_return_true()
        {
            
            WrileList(new List<string> {"1","2","3" }, new List<string> {"4","5","6" });
        }
    }
}
