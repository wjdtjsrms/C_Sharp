using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 545

namespace C_Study.chapter_15
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }

    class _15_2
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

            // cost가 60 이하인 자동차만 찾는다
            var selected = cars.Where(c => c.Cost < 60).OrderBy(c => c.Cost); 

            foreach (var car in selected)
            {
                Console.WriteLine($"Cost : {car.Cost} MaxSpeed : {car.MaxSpeed}");
            }

            Console.WriteLine();

            var select = from car in cars
                         where car.Cost < 60
                         orderby car.Cost
                         select new
                         {
                             Cost = car.Cost,
                             MaxSpeed = car.MaxSpeed
                         };
            foreach (var car in select)
            {
                Console.WriteLine($"Cost : {car.Cost} MaxSpeed : {car.MaxSpeed}");
            }

        }
    }
}
