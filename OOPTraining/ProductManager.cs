using System;
using Model;

namespace OOPTraining
{
    class ProductManager : IProductService
    {
        private ICustomer _customer;
        private IBankService _bankService;
        public ProductManager(ICustomer customer,IBankService bankService)
        {
            _customer = customer;
            _bankService = bankService;
        }

        public void Sell(Product product, Currency currency)
        {
            decimal price = _customer.Discount * product.Price;
            price = _bankService.CovertRate(new CurrencyRate() { Currency = currency, Price = price });

            Console.WriteLine(product.Name + ": " + price + " ");
            Console.ReadLine();
        }
    }
}
