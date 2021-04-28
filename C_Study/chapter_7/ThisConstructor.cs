﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study.chapter_7
{
    // Page 244
    // this 생성자
    class MyClass
    {
        int a, b, c;
        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }
        public MyClass(int b) :this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }
        public MyClass(int b, int c) :this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b},{c})");
        }
        public void PrintFields()
        {
            Console.WriteLine($"a:{a},b:{b},c:{c}");

        }
    }


    class ThisConstructor
    {
        static void Main(String[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10,20);
            c.PrintFields();
            Console.WriteLine();
        }
    }
}
