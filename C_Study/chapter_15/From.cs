using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Study.chapter_15
{
    // page 516
    // 모든 LINQ(Language INtegrated Query) 데이터 질의(Query) 기능 

    // From 어떤 데이터 집합에서 찾을 것인가?
    // From의 원본 데이터는 IEnumerable<T>를 상속받아야 한다.
    // 데이터 원본과 각 요소 데이터를 나타내는 범위 변수(Range Variable)를 지정한다.
    // foreach 문의 반복 변수는 데이터의 원본으로 부터 데이터를 담아내지만
    // 범위 변수는 실제로 데이터를 담지는 않는다.

    // where 어떤 값의 데이터를 찾을 것인가?
    // 한마디로 필터 역활을 하는 연산자
    // From절이 데이터 원본으로 부터 뽑아낸 범위 변수가 가져야 할 조건을 입력하면 부합하는 데이터만을 거른다.

    // orderby 데이터의 정렬을 수행하는 연산자
    // ascending (오름차순) , descending (내림차순)

    // Select 어떤 항목을 추출할 것인가?
    // LINQ 질의 결과는 IEnumerable<T> 로 반환되는데 T가 이 select 구문으로 결정
    // 무명 형식을 이용해서 새로운 형태를 즉석에서 만들어낼수 있다.

    class From
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };
                         // from으로  데이터 원본으로 부터 범위 변수를 뽑는다.
            var result = from n in numbers // numbers 안에 있는 각 데이터로부터
                         where n % 2 == 0 // 짝수를
                         orderby n // 정렬하지 말고
                         select n; // n 객체로 추출한다.
            foreach(int n in result)
            {
                Console.WriteLine($"짝수 : {n}");
            }
        }
    }
}
