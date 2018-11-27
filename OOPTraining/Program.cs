using Model;

namespace OOPTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productServiceStudent = new ProductManager(
                new Student() { Name = "Malo" },
                new CentralBankAdapter()
                );
            productServiceStudent.Sell(new Product { Name = "Laptop", Price = 1000 }, Currency.Dolar);

            IProductService productServiceOfficer = new ProductManager(
             new Officer() { Name = "Xalo" },
             new CentralBankAdapter()
             );
            productServiceOfficer.Sell(new Product { Name = "Laptop", Price = 1000 }, Currency.Dolar);
        }
    }
}
