using System.Diagnostics;
using System.Threading;

namespace Udemy_MemoryTricks
{
    public class WithoutDispose
    {
        private Stopwatch stopWatch = null;
        public WithoutDispose()
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        internal void DowWork()
        {
            double j = 0;

            for (int i = 0; i < 1000; i++)
            {
                j += i * i;
            }
        }

        ~WithoutDispose()
        {
            stopWatch.Stop();
            Interlocked.Increment(ref DisposePattern.FinalisedObjects);
            Interlocked.Add(ref DisposePattern.TotalTime, stopWatch.ElapsedMilliseconds);
        }
    }
}