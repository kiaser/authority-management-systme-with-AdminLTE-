using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.UnitTest.Base.DataBase;
using NUnit.Framework;

namespace AdminLTE.UnitTest.Core
{
    /// <summary>
    /// 测试的基类
    /// </summary>
    public class BaseTest
    {
        //数据库基类
        public BaseContext BaseContext;

        [SetUp]
        public virtual void SetUp()
        {
            BaseContext = new BaseContext();
        }

        [TearDown]
        public virtual void TearDown()
        {
            BaseContext = null;
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
    }
}
