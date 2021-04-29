using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 531 두 데이터의 원본을 연결하는 join
// 각 데이터 원본에서 특정 필드의 값을 비교하여 일치하는 데이터 끼리 연결을 수행

// Inner Join , 내부 조인 : 연결할 데이터 원본에 존재하지 않는 데이터는 조인 결과에 포함되지 않는다. 
// Outer Join , 외부 조인 : 없어도 모든 데이터를 결과에 포함시킨다. 대신 없는 부분은 빈칸으로 결과를 채운다.

// from a in A
// join b in B on a.xxxx equals b.yyyy
// on 키워드는 조건을 수반한다. 조건은 동등만 허용, ~보다 작음 ~보다 큼은 허락되지 않는다.

namespace C_Study.chapter_15
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }

    class Join
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

            Product[] arrProduct =
            {
                new Product(){Title="비트",Star="정우성"},
                new Product(){Title="CF 다수",Star="김태희"},
                new Product(){Title="아이리스",Star="김태희"},
                new Product(){Title="모래시계",Star="고현정"},
                new Product(){Title="Solo 예찬",Star="이문세"}
            };

            var listProfile =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star
                select new
                {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height
                };
            Console.WriteLine("----- 내부 조인 결과 -----");
            foreach(var profile in listProfile)
            {
                Console.WriteLine($"이름 : {profile.Name}, 작품 : {profile.Work}, 키 : {profile.Height} ");
            }

            listProfile =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star into ps // into ps 추가
                from product in ps.DefaultIfEmpty(new Product() {Title = "그런거 없음"})
                select new
                {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height
                };

            Console.WriteLine("----- 외부 조인 결과 -----");
            foreach (var profile in listProfile)
            {
                Console.WriteLine($"이름 : {profile.Name}, 작품 : {profile.Work}, 키 : {profile.Height} ");
            }
        }
    }
}
