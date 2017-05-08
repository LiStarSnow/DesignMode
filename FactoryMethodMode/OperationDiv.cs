using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMode
{
    internal class OperationDiv : Operation
    {
        public override double GetResult()
        {
            return NumberA / NumberB;
        }
    }
}
