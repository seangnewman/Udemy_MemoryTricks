using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_MemoryTricks
{
    class StringBuilder_Test
    {

        private const int REPETITIONS = 10_000;

        public static void StringTest()
        {
            string result = string.Empty;

            for (int i = 0; i < REPETITIONS; i++)
            {
                result += "#";
            }

           
        }

        public static void Demo()
        {
            StringBuilderTest();
        }

        public static void StringBuilderTest()
        {
            StringBuilder result = new StringBuilder(REPETITIONS);

            for (int i = 0; i < REPETITIONS; i++)
            {
                result.Append("#");
            }
        }
    }
}
