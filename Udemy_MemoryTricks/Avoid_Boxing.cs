using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_MemoryTricks
{
    class Avoid_Boxing
    {
        public const int ITERATIONS = 1_000_000;
        public static void TestMethod(object value){

        }

        public static void Demo()
        {
            for (int i = 0; i < ITERATIONS; i++)
            {
                TestMethod(i);
            }
        }
    }
}
