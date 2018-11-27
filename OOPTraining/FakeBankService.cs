using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTraining
{
    public class FakeBankService : IBankService
    {
        public decimal CovertRate(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal)5.30;
        }
    }
}
