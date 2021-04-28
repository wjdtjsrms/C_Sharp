using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 526 group by로 데이터 분류하기 
// group A by B into C 
// A에는 from 절에서 뽑아낸 범위 변수를, B에는 분류 기준 C에는 그룹 변수를 위치시킨다.
// 분류기준에 맞는거만 들어가는게 아니라 분류 기준으로 나누어서 담는다.

namespace C_Study.chapter_15
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class GroupBy
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

            var listProfile = from profile in arrProfile
                              orderby profile.Height // 키순으로 정렬
                              group profile by profile.Height < 175 into g // 175을 기준으로 분류한다
                              select new { GroupKey = g.Key, Profiles = g };

            foreach (var Group in listProfile) // Group은 IGrouping<T> 형식, 여기서는 <bool,Profile> 형식
            {
                Console.WriteLine($"-175cm 미만? : {Group.GroupKey}");
                foreach(var profile in Group.Profiles)
                {
                    Console.WriteLine($">>> {profile.Name}, {profile.Height}");
                }
            }
        }

    }
}
