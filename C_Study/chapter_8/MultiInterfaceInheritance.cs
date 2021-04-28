using System;
using System.Collections.Generic;
using System.Text;

// page 308 여러개의 인터페이스 한꺼번에 상속받기
// 클래스 다중 상속하면 최초의 클래스가 두개의 파생클래스를 상속하고 
// 이 두개의 파생 클래스가 다시 하나의 클래스가 상속 받는 죽음의 다이아몬드 문제가 생긴다.
namespace C_Study.chapter_8
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable,IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }
        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }
    class MultiInterfaceInheritance
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
