using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode.Structural
{
    /// <summary>
    /// 定义实现类的接口，该接口不一定要与Abstraction的接口完全一致，事实上两个接口可以完全不同。
    /// <para>一般情况，Implementor接口仅为提供基本操作，而Abstraction则定义了基于基本操作的较高层次操作</para>
    /// </summary>
    public abstract  class Implementor
    {
        public abstract void Operation();
    }
}
