using System;
using System.Collections.Generic;
using System.Text;


// 구조체
// page 281
// 구조체의 인스턴스는 스택에 클래스는 힙에 저장된다.
// 인스턴스의 사용이 끝나면 즉시 메모리에서 해제된다.
// 값 형식이기 때문에 할당 연산자 = 를 통해 모든 필드가 그대로 복사된다.
namespace C_Study.chapter_7
{
    struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int x,int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // system.object 형식의 ToString() 메소드를 오버라이딩
        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }
    }

    class Structure
    {
        static void Main(string[] args)
        {
            Point3D p3d1; // 선언만으로 인스턴스가 생성된다.
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300); // 생성자 이용 가능
            Point3D p3d3 = p3d2; // 깊은 복사가 이루어진다.
            p3d3.Z = 400;
        }
    }
}
