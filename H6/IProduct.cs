using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6_lab
{
    public interface IProduct
    {
        int ProductId { get; set; }
        decimal UnitPrice { get; set; }
        string ProductName { get; set; }
        Int16 UnitsInStock { get; set; }


        void GetProduct();

        decimal GetUnitPrice(int id);

    }
}
