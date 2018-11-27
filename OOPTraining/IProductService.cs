using Model;

namespace OOPTraining
{
    internal interface IProductService
    {
        void Sell(Product product,Currency currency);
    }
}