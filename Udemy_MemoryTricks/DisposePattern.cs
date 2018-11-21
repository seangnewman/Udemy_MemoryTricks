using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_MemoryTricks
{
    public class DisposePattern
    {
        public static long FinalisedObjects = 0;
        public static long TotalTime = 0;

        public static void Demo()
        {
            for (int i = 0; i < 500000; i++)
            {
                //var obj = new WithoutDispose();
                using (var obj = new WithDispose())
                {
                    obj.DowWork();
                } ;
               
            }

            double avgLifeTime = 1.0 * TotalTime / FinalisedObjects;
            Console.WriteLine($"Number of disposed/finalized objects: {FinalisedObjects}k");
            Console.WriteLine($"Average resource lifetime {avgLifeTime}ms");
        }
    }
}
