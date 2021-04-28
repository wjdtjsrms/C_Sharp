using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 실무에서 많이 씀 한번 짜두면 두구두구 씀

namespace C_Study.chapter_11
{
    class Dictionary
    {
        static void Main(string[] args)
        {
           
            var dictionary = new Dictionary<string, int>(5);
            dictionary.Add("cat", 1);
            dictionary.Add("dog", 0);
            dictionary.Add("mouse", 5);
            dictionary.Add("eel", 3);
            dictionary.Add("programmer", 2);

            var list = dictionary.Keys.ToList();
            list.Sort();
            

            // Order by values.
            // ... Use LINQ to specify sorting by value.
            // sql 에서 따온거라 조금 낯설수 있다.
            var items = from pair in dictionary // dictionary 안에 있는 각 데이터로부터
                        orderby pair.Value ascending // value 값으로 정렬하여
                        select pair; // pair 객체를 추출

            // Display results.
            foreach (KeyValuePair<string, int> pair in items)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            // Reverse sort.
            // ... Can be looped over in the same way as above.
            items = from pair in dictionary
                    orderby pair.Value descending
                    select pair;

        }
    }
}
