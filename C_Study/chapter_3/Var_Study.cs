using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    //page 89
    class Var_Study
    {
        static void Main(String[] args)
        {
            #region Var_설명
            // 약한 형식 검사를 위한 키워드 var
            // var 는 지역변수로만 사용할 수 있다
            // 선언과 동시에 초기화 되어야만 한다.
            // 컴파일 타임에서 적합한 타입으로 바꿔서 컴파일 한다.
            #endregion

            var a = 20;
            Console.WriteLine($"Type: {a.GetType()} Value: {a}");

            var b = 3.1414213;
            Console.WriteLine($"Type: {b.GetType()} Value: {b}");

            var c = "Hello, World!";
            Console.WriteLine($"Type: {c.GetType()} Value: {c}");

            var d = new int[] { 10, 20, 30 };
            Console.WriteLine($"Type: {d.GetType()} Value: {d}");

        }
    }
}
