using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
     class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Amasya apple.";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price=80;
            product2.Description = "Diyarbakir watermelon.";
            
            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("----------Methods----------");
            
            // instance 
            // encapsulation

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            basketManager.Add2("Pear", "Green pear", 12,10);
            basketManager.Add2("Apple", "Green apple", 12,24);
            basketManager.Add2("Watermelon", "Diyarbakir watermelon", 12,9);


            Console.ReadLine();
        }

       
    }
}


// Don't repeat yourself. - DRY - Clean Code - Best Practice