using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study.chapter_7
{
    // page 270
    // 읽기 전용 필드
    class Configuration
    {
        private readonly int min; // 초기화를 미룰수 있다.
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1; // 생성자 안에서만 초기화 가능
            max = v2;
        }

    }

    class ReadOnlyFields
    {
        static void Main(String[] args)
        {
            Configuration c = new Configuration(100, 10);
        }
    }
}
