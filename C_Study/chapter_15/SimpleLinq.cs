using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 520

namespace C_Study.chapter_15
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class SimpleLinq
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

            var profiles = from profile in arrProfile // arrProfile 안에 있는 각 데이터로부터
                           where profile.Height < 175 // Height가 175 미만인 객체만 골라
                           orderby profile.Height ascending // 키순으로 정렬하여 
                           select new // 무명 형식을 선언하여 담는다.
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };

            foreach (var profile in profiles)
            {
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
            }
        }

    }
}
