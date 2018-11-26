using Model;

namespace OOPTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new Student { Name = "malo" });
            productService.Sell(new Product { Name = "Laptop", Price = 1000 });
        }
    }
}
