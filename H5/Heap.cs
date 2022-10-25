using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAf_5
{
    public abstract class Heap
    {
        //Kalıtımla devir alma söz konusu ise protected tipi kullanılmalıdır.
        protected SortedSet<int> heap;

        public Heap()
        {
            heap = new SortedSet<int>();
        }

        public void Insert(int item)
        {
            heap.Add(item);
        }

        //Abstract metod

        public abstract int Extract();
    }
}


