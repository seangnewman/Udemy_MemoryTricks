using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_MemoryTricks
{
    class Structs_vs_Classes
    {
        private const int LISTSIZE = 1_000_000;

        private static void TestClass()
        {
            List<PointClass> list = new List<PointClass>(LISTSIZE);

            for (int i = 0; i < LISTSIZE; i++)
            {
                list.Add(new PointClass(i, i));
            }
        }

        private static void TestStruct()
        {
            List<PointStruct> list = new List<PointStruct>(LISTSIZE);

            for (int i = 0; i < LISTSIZE; i++)
            {
                list.Add(new PointStruct(i, i));
            }
        }

        public static void Demo()
        {
            TestStruct();
        }
       
    }
}
