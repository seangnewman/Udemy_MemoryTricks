using System;
using System.Threading;

namespace Udemy_MemoryTricks
{
    internal class MyObject
    {
        private int _index = 0;

        public MyObject(int index)
        {
            
            this._index = index;
            System.Console.WriteLine($"Constucted object {_index} in gen {GC.GetGeneration(this)}");
        }

        ~MyObject()
        {
            Thread.Sleep(500);
            System.Console.WriteLine($"Finalized object {_index} in gen {GC.GetGeneration(this)}" );
        }
    }
}