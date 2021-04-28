using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 추상 클래스의 인터페이스 page 350
// abstract 한정자를 붙이면 자식에게 구현을 강제한다.
// 안 붙이면 그냥 컴파일러가 완성해준다.

namespace C_Study.chapter_9
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format($"{serial++:d5}"); }
        }

        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate { get; set; }
    }


    class PropertiesInAbstractClass
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            { ProductDate = new DateTime(2018, 1, 10) };

            Console.WriteLine($"{product_1.SerialID} {product_1.ProductDate}");

            Product product_2 = new MyProduct()
            { ProductDate = new DateTime(2018, 2, 3) };

            Console.WriteLine($"{product_2.SerialID} {product_2.ProductDate}");
        }

    }
}
