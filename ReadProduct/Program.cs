using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductRead productRead = new ProductRead();
            List<Product> products = productRead.GetProducts();
            foreach (var item in products)
            {
                Console.WriteLine($"ProductID: {item.ProductID} Name: {item.Name} ListPrice: {item.ListPrice}");
            }
        }
    }
}
