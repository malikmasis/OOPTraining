using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    class Customer: ICustomer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Price { get; set; }
    }
}
