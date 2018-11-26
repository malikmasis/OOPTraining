using System;
using Model;

namespace OOPTraining
{
    class ProductManager : IProductService
    {
        private ICustomer _customer;
        public ProductManager(ICustomer customer)
        {
            _customer = customer;
        }
        public void Sell(Product product)
        {
            decimal price = _customer.Price * product.Price;
            Console.WriteLine(price);
            Console.ReadLine();
        }
    }
}
