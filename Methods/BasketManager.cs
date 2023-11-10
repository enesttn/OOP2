using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
     class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations! Added to cart:" + product.Name);
        }

        public void Add2(string productName, string description, double price, int stock)
        {
            Console.WriteLine("Congratulations! Added to cart:" + productName);
        }
    }
}
