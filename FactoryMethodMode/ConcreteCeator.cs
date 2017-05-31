using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMode
{
    public class ConcreteCeator : Creator
    {
        public ConcreteProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
