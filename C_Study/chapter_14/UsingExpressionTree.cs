using System;
using System.Linq.Expressions;

// page 502  식트리 뭔지 모르겠음
namespace C_Study.chapter_14
{
    class UsingExpressionTree
    {
        static void Main(string[] args)
        {
            Expression const1 = Expression.Constant(1);
            Expression const2 = Expression.Constant(2);

            Expression leftExp = Expression.Multiply(const1, const2); // 1 * 2

            Expression param1 = Expression.Parameter(typeof(int)); // x를 위한 변수
            Expression param2 = Expression.Parameter(typeof(int)); // y를 위한 변수

            Expression rightExp = Expression.Subtract(param1, param2); // x - y

            Expression exp = Expression.Add(leftExp, rightExp); // (1 * 2) + (x - y)

            Expression<Func<int, int, int>> expression = Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
                exp, new ParameterExpression[]
                {
                    (ParameterExpression)param1,
                    (ParameterExpression)param2
                });

            Func<int, int, int> func = expression.Compile();
            Console.WriteLine($"1 * 2 + (7) - (8) = {func(7, 8)}");
        }
    }
}
