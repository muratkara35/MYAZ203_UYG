using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6_lab
{
    public class Product : IProduct,IComparable<Product>
    {
        private int _productId;
        private string _productName;
        private decimal _unitPrice;
        private Int16 _unitsInStock;

        List<Product> _products;

        public Product(List<Product> products)
        {
            _products = products;
        }

        public Product(int productId, string productName, decimal unitPrice, Int16 unitInStock)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitsInStock = unitInStock;
        }

        public int ProductId { get => _productId; set => _productId = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public decimal UnitPrice { get => _unitPrice; set => _unitPrice = value; }
        public Int16 UnitsInStock { get => _unitsInStock; set => _unitsInStock = value; }

        public int CompareTo(Product other)
        {
            return ProductId.CompareTo(other.ProductId);    
        }

        public void GetProduct()
        {
            _products.Sort();
            for (int i = 0; i < _products.Count; i++)
            {
                Console.WriteLine($"{_products[i].ProductId} {_products[i].ProductName} {_products[i].UnitPrice} {_products[i].UnitsInStock}");
            }
        }

        public decimal GetUnitPrice(int id)
        {
            throw new NotImplementedException();
        }
    }
}
