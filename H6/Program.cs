using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(1,"Product A",15,4),
                new Product(2,"Product B",34,9),
                new Product(12,"Product C",54,8),
                new Product(4,"Product D",32,5),
                new Product(9,"Product E",26,11),
            };


            Product product = new Product(products);
            product.GetProduct();


            Console.ReadLine();
        }
    }
}
