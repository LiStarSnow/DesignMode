using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMode
{
    public class ConcreteProduct : Product
    {
        public override void Display()
        {
            Console.Write("产品A");
        }
    }
}
