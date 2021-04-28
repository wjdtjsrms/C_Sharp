using System;
using System.Collections.Generic;
using System.Text;

// page 255
// 기반 클래스와 파생 클래스 사이의 형식 변환

namespace C_Study.chapter_7
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat:Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }
    class TypeCasting
    {
        static void Main(string[] args)
        {
            // Dog 대입
            Mammal mammal = new Dog();
            Dog dog;

            if(mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            // Cat 대입
            Mammal mammal2 = new Cat();
            Cat cat = mammal2 as Cat;
            if(cat != null)
            {
                cat.Meow();
            }

            // mammal은 Dog 가 대입되었다.
            Cat cat2 = mammal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                Console.WriteLine("Cat2 is not a cat");
        }
    }
}
