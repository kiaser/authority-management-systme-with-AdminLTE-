using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AdminLTE.UnitTest.Core;
using NUnit.Framework;

namespace AdminLTE.UnitTest.Other
{
    [TestFixture]
    public class ExpressionTreeTest : BaseTest
    {

        /// <summary>
        /// Expression<Func<int, bool>> lambda = num => num < 5
        ///https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/concepts/expression-trees/
        /// </summary>
        [Test]
        public void Test1()
        {
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            ConstantExpression five = Expression.Constant(5, typeof(int));

            BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);

            Expression<Func<int, bool>> lambda1 =
                Expression.Lambda<Func<int, bool>>(numLessThanFive, numParam);

            Console.WriteLine(lambda1);



        }

        [Test]
        public void Test2()
        {
            ParameterExpression value = Expression.Parameter(typeof(int), "value");

            ParameterExpression result = Expression.Parameter(typeof(int), "result");

            LabelTarget label = Expression.Label(typeof(int));

            BlockExpression block = Expression.Block(new[] {result}, Expression.Assign(result, Expression.Constant(1)),
                Expression.Loop(
                    Expression.IfThenElse(
                        Expression.GreaterThan(value, Expression.Constant(1)),
                        Expression.MultiplyAssign(result, Expression.PostDecrementAssign(value)),
                        Expression.Break(label, result)
                    ),
                    label
                ));

            int factorial = Expression.Lambda<Func<int, int>>(block, value).Compile()(5);

            Console.WriteLine(factorial);
        }

        [Test]
        public void Test3()
        {
            Expression<Func<int, bool>> exprTree = num => num < 5;

            ParameterExpression param = (ParameterExpression)exprTree.Parameters[0];
            BinaryExpression operation = (BinaryExpression) exprTree.Body;

            ParameterExpression left = (ParameterExpression) operation.Left;
            ConstantExpression right = (ConstantExpression) operation.Right;

            Console.WriteLine("Decomposed expression: {0} => {1} {2} {3}",param.Name, left.Name,operation.NodeType,right.Value);

            //Expression.Invoke()

        }


    }
}
