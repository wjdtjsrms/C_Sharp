using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스의 프로퍼티 page 348
// 컴파일러가 인터페이스의 프로퍼티에 대해서는 자동으로 구현해주지 않는다.
// 인터페이스의 자식은 무조건 프로퍼티와 인덱서를 구현해야 한다.

namespace C_Study.chapter_9
{
    interface InameValue
    {
        string Name // 자동으로 구현되지 않는다.
        {
            get;
            set;
        }

        string Value
        {
            get;
            set;
        }
    }
    class NamedValue : InameValue
    {
        public string Name
        {
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }
    }

    class PropertiesInterface
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", Value = "박성현" };

            NamedValue height = new NamedValue()
            { Name = "키", Value = "177cm" };

            NamedValue weight = new NamedValue()
            { Name = "몸무게", Value = "90kg" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}
