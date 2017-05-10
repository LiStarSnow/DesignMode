using System;

namespace TemplateMethodMode.Structural
{
    /// <summary>
    /// 模板方法模式
    /// 抽象模板类
    /// </summary>
    public  abstract class AbstractClass
    {
        /// <summary>
        /// 抽象行为1
        /// </summary>
        public abstract void PrimitiveOperation1();

        /// <summary>
        /// 抽象行为2
        /// </summary>
        public abstract void PrimitiveOperation2();

        /// <summary>
        /// 实现一个模板方法，定义算法的骨架，
        /// 具体子类重新定义PrimitiveOperation1，PrimitiveOperation2抽象方法的实现
        /// </summary>
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}
