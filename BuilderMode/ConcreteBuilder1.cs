using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    public class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();
        public override void BuilderPartA()
        {
            product.Add("建造部件A");
        }

        public override void BuilderPartB()
        {
            product.Add("建造部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
