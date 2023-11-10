using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
     class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperations = new FourOperations();
            fourOperations.Sum(8, 2);
            fourOperations.Sum(3, 4);

            Console.ReadKey();
        }

    }
}
