using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 형식 매개변수 제약시키기 page 416
// 형식 매개변수의 데이터 형식을 제한할수 있다.

namespace C_Study.chapter_11
{
    class StructArray<T> where T : struct // T는 값형식이어야 한다.
    {
        public T[] Array {get;set;}
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }
    class RefArray<T> where T :class // T는 참조 형식이어야 한다.
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }


    class Base { }
    class Derived : Base { }
    class BaseArray<U> : Base 
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }
        public void CopyArray<T>(T[] Source) where T : U // T는 또다른 형식 매개변수 U로부터 상속받은 클래스여야 합니다.
        {
            Source.CopyTo(Array, 0);
        }
    }

    class ConstraintsOnTypeParameters
    {
        public static T CreateInstance<T>() where T : new() // T는 반드시 매개변수가 없는 생성자가 있어야 합니다.
        {
            return new T();
        }

        public static void PrintValue<T>(T[] array)
        {
            for(int i=0; i<array.Length;i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
       
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3); // 형식 매개변수는 값형식
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            PrintValue<int>(a.Array);

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[0] = new StructArray<double>(10);
            b.Array[0] = new StructArray<double>(1005);

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            // d.Array[0] = new Base(); 대입 불가
            d.Array[0] = new Derived();
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);

        }
    }
}
