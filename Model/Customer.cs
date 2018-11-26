using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer: ICustomer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        private decimal price;
        public virtual decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
