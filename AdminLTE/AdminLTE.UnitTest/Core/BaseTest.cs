using System;
using System.Collections.Generic;
using System.Linq;
using AdminLTE.DAL;
using NUnit.Framework;
using System.Reflection;
using System.Text;

namespace AdminLTE.UnitTest.Core
{
    /// <summary>
    /// 测试的基类
    /// </summary>
    public class BaseTest
    {
        public AdminLteContext AdminLteContext;

        [SetUp]
        public virtual void SetUp()
        {
            AdminLteContext = new AdminLteContext();
        }

        [TearDown]
        public virtual void TearDown()
        {
            AdminLteContext = null;
        }

        /// <summary>
        /// 打印需要显示的参数集合数组
        /// </summary>
        /// <typeparam name="T">参数</typeparam>
        /// <param name="paramListArray">参数集合数组</param>
        public void WrileList<T>(params IEnumerable<T>[] paramListArray)
        {
            foreach (var paramList in paramListArray)
            {
                Console.WriteLine(string.Join(",", paramList));
            }
        }

        public void WriteMessages<T>(IEnumerable<T> listParams) where T:class ,new()
        {
            foreach (var param in listParams)
            {
                WriteMessageCore(param);
            }
        }


        private void WriteMessageCore<T>(T model) where T : class, new()
        {
            StringBuilder stringBuilder=new StringBuilder();

            foreach (var propertyInfo in model.GetType().GetProperties())
            {
                stringBuilder.Append(propertyInfo.Name + " : " + propertyInfo.GetValue(model,null)+" , ");
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
