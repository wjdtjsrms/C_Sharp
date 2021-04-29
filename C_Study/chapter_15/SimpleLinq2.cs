using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 535 LINQ의 비밀과 LINQ 표준 연산자
// C# 컴파일러가 LINQ 퀴리식을 CLR이 이해할수있도록 번역해준다.
// from절의 매개변수는 IEnumerable<T>의 파생형식이어야 한다.
// 그렇다고 System.Collections.Generic만 using 해놓고 LINQ를 쓰면 오류난다.
// System.Linq 에서 IEnumerable<T> 확장 메소드에서 LINQ 퀴리식을 변환해주기 때문이다.
// 53개의 표준 LINQ 연산 메소드 중에 C# 퀴리식에서 지원하는 것은 11개가 전부이다. 
// C# 퀴리식의 결과값인 IEnumerable<Profile> 에다가 profile.Average() 같이 표준 LINQ 연산 메소드를 적용할수 있다. 


namespace C_Study.chapter_15
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class SimpleLinq2
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


            // LINQ 연산 메소드로 작성

            var profiles = arrProfile.
                Where(profile => profile.Height < 175).
                OrderBy(profile => profile.Height).
                Select(profile =>
                new
                {
                    Name = profile.Name,
                    InchHeight = profile.Height*0.393
                }); 

            foreach(var profile in profiles)
            {
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
            }
        }
    }
}
