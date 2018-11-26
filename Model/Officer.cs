using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Officer : Customer, IEntity
    {
        public override decimal Price { get; set; } = 2;
    }
}
