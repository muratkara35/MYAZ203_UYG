using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAf_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var act01=ResultSets.Action01();
            //Console.WriteLine($"{act01.Statu,-5}" +
            //    $"{act01.Message,5}");
            //var act02 = ResultSets.Action02();
            //Console.WriteLine($"{act02.Statu,-5}" +
            //    $"{act02.Message,5}");
            //var act03 = ResultSets.Action03();
            //Console.WriteLine($"{act03.Statu,-5}," +
            //    $"{act03.Message,5}");
            //var act04 = ResultSets.Action04();
            //Console.WriteLine($"{act04.Statu,-5}" +
            //    $"{act04.Message,5}");

            //ABSTRACT

            var arr = new int[] { 4, 8, 1, 3, 9 };

            var minheap = new MinHeap();
            var maxheap = new MaxHeap();


            foreach (var item in arr)
            {
                minheap.Insert(item);
                maxheap.Insert(item);
            }

            Console.WriteLine(minheap.Extract());
            Console.WriteLine(maxheap.Extract());



            Console.ReadLine();
        }
    }
}
