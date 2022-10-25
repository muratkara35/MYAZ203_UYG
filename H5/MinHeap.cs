using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAf_5
{
    public class MinHeap : Heap
    {
        public override int Extract()
        {
            var item = heap.Min;
            heap.Remove(item);
            return item;
        }
    }
}
