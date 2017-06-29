using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode.Structural
{
    /// <summary>
    /// 定义抽象类的接口，它维护了一个指向Implementor类型对象的指针
    /// </summary>
    public class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set
            {
                implementor = value;
            }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
