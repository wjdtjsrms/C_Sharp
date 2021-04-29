using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 542
// 53개의 표준 LINQ 연산 메소드 중에 C# 퀴리식에서 지원하는 것은 11개가 전부이다. 
// C# 퀴리식의 결과값인 IEnumerable<Profile> 에다가 profile.Average() 같이 표준 LINQ 연산 메소드를 적용할수 있다. 

namespace C_Study.chapter_15
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class MinMax
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
{
                new Profile(){Name="정우성",Height=186},
                new Profile(){Name="김태희",Height=158},
                new Profile(){Name="고현정",Height=172},
                new Profile(){Name="이문세",Height=178},
                new Profile(){Name="하하",Height=171}
            };

            var heightStat = from profile in arrProfile
                         group profile by profile.Height < 175 into g
                         select new
                         {
                             Group = g.Key == true ? "175 미만" : "175 이상",
                             Count = g.Count(),
                             Max = g.Max(profile => profile.Height),
                             Min = g.Min(profile => profile.Height),
                             Average = g.Average(profile => profile.Height)
                         };

            foreach (var stat in heightStat)
            {
                Console.WriteLine($"{stat.Group} - Count : {stat.Count}, Max : {stat.Max}");
                Console.WriteLine($"Min : {stat.Min}, Average : {stat.Average}");
            }
        }
    }
}
