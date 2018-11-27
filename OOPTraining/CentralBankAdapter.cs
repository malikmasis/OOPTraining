using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace OOPTraining
{
    public class CentralBankAdapter : IBankService
    {
        public decimal CovertRate(CurrencyRate currencyRate)
        {
            //TODO IoC yapılabilir.
            CentralBankService centralBankService = new CentralBankService();
            return centralBankService.ConvertCurrency(currencyRate);
        }
    }
}
