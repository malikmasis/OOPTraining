using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new Student {Price = 4, Name = "malo" } );
            productService.Sell(new Product { Price = 1000 });
        }
    }
}
