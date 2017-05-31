using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode.Structural
{
    /// <summary>
    /// 建造抽象类，确定产品建造需要两个部件。
    /// <para>为创建一个Product对象的各个部件指定抽象接口</para>
    /// </summary>
    public abstract class Builder
    {


        public abstract void BuilderPartA();

        public abstract void BuilderPartB();

        public abstract Product GetResult();
    }
}
