using System;
using System.Collections.Generic;
using System.Text;

// 읽기 전용 구조체
// page 283
// 상태(state)의 변화를 허용하는 객체를 변경가능(Muable) 객체
// 상태의 변화를 허용하지 않는 객체를 변경불가능(Immutable)라고 한다.
// 멀티 쓰레드간의 동기화(Synchronization)를 할 필요가 없기 때문에 성능 향상이 가능하고
// 버그로 인한 상태, 데이터의 오염을 막을 수 있다.
namespace C_Study.chapter_7
{
    readonly struct RGBColor
    {
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public RGBColor(byte r, byte g,byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public override string ToString()
        {
            return string.Format($"{R}, {G}, {B}");
        }
    }

    class ReadonlyStruct
    {
        static void Main(string[] args)
        {
            RGBColor Red = new RGBColor(255, 0, 0);
            // Red.G = 100; 읽기 전용 필드에 할당 불가
            RGBColor myColor = new RGBColor(Red.R, 100, Red.B);

            Console.WriteLine(Red.ToString());
            Console.WriteLine(myColor.ToString()); // 그냥 새로 만들어라

        }
    }
}
