using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Udemy_MemoryTricks
{
    public class WithDispose:IDisposable
    {
        private Stopwatch stopWatch = null;
        private bool disposed = false;

        public WithDispose()
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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                stopWatch.Stop();
                Interlocked.Increment(ref DisposePattern.FinalisedObjects);
                Interlocked.Add(ref DisposePattern.TotalTime, stopWatch.ElapsedMilliseconds);

                if (disposing)
                {

                }
                else
                {
                    // Called from finalizer
                    //CANNNOT ACCESS REFERENCES
                }
                disposed = true;
            }
        }

        ~WithDispose()
        {
            Dispose(false);
        }
    }
}
