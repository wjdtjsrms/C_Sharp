using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Study.chapter_11
{
    class MyList<T,U>
    {
        // 그냥 딕셔너리 만드는 것보다 조금 빠름
        public IDictionary<T, U> dictionary = new Dictionary<T, U>(5);   
        
        public void HasKey(T findKey)
        {
            foreach (KeyValuePair<T, U> pair in dictionary)
            {
                if(pair.Key.Equals(findKey))
                {
                    Console.WriteLine($"Find KEY : {findKey}!!\nKEY : {pair.Key,-10} VALUE : {pair.Value,-30}");
                    Console.WriteLine();
                    break;
                }
            }
        }

        public void HasValue(U findValue)
        {
            foreach (KeyValuePair<T, U> pair in dictionary)
            {
                if (pair.Value.Equals(findValue))
                {
                    Console.WriteLine($"Find VALUE : {findValue}!!\nKEY : {pair.Key,-10} VALUE : {pair.Value,-30}");
                    Console.WriteLine();
                    break;
                }
            }

        }
    }

    class Generic2
    {
        static void Main(string[] args)
        {
            MyList<string, int> myList = new();
            myList.dictionary.Add("cat", 1);
            myList.dictionary.Add("dog", 0);
            myList.dictionary.Add("mouse", 5);
            myList.dictionary.Add("eel", 3);
            myList.dictionary.Add("programmer", 2);

            myList.HasKey("cat");
            myList.HasValue(0);

            foreach (KeyValuePair<string, int> pair in myList.dictionary)
            {
                Console.WriteLine($"KEY : {pair.Key,-10} VALUE : {pair.Value,-30}");
            }

            Console.WriteLine();

            MyList<float, int> myList2 = new();
            myList2.dictionary.Add(32.02f, 1);
            myList2.dictionary.Add(5.05f, 0);
            myList2.dictionary.Add(3.6f, 5);
            myList2.dictionary.Add(9.4f, 3);
            myList2.dictionary.Add(888.888f, 2);

            myList2.HasKey(3.6f);
            myList2.HasValue(2);

            foreach (KeyValuePair<float, int> pair in myList2.dictionary)
            {
                Console.WriteLine($"KEY : {pair.Key,-10} VALUE : {pair.Value,-30}");
            }


        }
       
    }
}
