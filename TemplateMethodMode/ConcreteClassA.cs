using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodMode
{
    /// <summary>
    /// 模板方法模式
    /// 
    /// 实现模板类A
    /// </summary>
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体A类方法1的实现！");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体A类方法2的实现！");
        }
    }
}
