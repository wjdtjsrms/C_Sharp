using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 544

namespace C_Study.chapter_15
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }

    class _15_1
    {
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car(){Cost = 56, MaxSpeed = 120},
                new Car(){Cost = 70, MaxSpeed = 150},
                new Car(){Cost = 45, MaxSpeed = 180},
                new Car(){Cost = 35, MaxSpeed = 200},
                new Car(){Cost = 82, MaxSpeed = 280}
            };


            var selected = from car in cars
                           where car.Cost > 50 // Cost가 50 이상이고
                           where car.MaxSpeed > 150 // MaxSpeed가 150 이상인 자동차만
                           select new
                           {
                               Cost = car.Cost,
                               MaxSpeed = car.MaxSpeed
                           };

            foreach (var car in selected)
            {
                Console.WriteLine($"Cost : {car.Cost} MaxSpeed : {car.MaxSpeed}");
            }
        }
    }
}
