using System;

namespace TemplateMethodMode.Structural
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体B类方法1的实现！");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体B类方法1的实现！");
        }
    }
}
