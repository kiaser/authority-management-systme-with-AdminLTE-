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

        [Test]
        public void WriteMessages_return_true()
        {
            List<MyTestClass> list = new List<MyTestClass>
            {
                new MyTestClass {Id = "1", Name = "1"},
                new MyTestClass {Id = "2", Name = "2"},
                new MyTestClass {Id = "3", Name = "3"},
                new MyTestClass {Id = "4", Name = "4"},
                new MyTestClass {Id = "5", Name = "5"},
            };

            WriteMessages(list);
        }

        [Test]
        public void ReflectionTest_get_propery_value()
        {
            MyTestClass myTestClass = new MyTestClass
            {
                Id = "1",
                Name = "2"
            };

            Type t = myTestClass.GetType();

            foreach (var propertyInfo in t.GetProperties())
            {
                Console.WriteLine(propertyInfo.Name);
                //Console.WriteLine(propertyInfo.Name+" : "+ propertyInfo.GetValue(myTestClass,null));
            }
        }
    }

   public class MyTestClass
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
