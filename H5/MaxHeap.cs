using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAf_5
{
    public class MaxHeap : Heap
    {
        public override int Extract()
        {
            var item = heap.Max;
            heap.Remove(item);
            return item;
        }

    }
}
