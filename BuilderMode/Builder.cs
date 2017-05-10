using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    /// <summary>
    /// 建造抽象类，确定产品建造需要两个部件。
    /// </summary>
    public abstract class Builder
    {


        public abstract void BuilderPartA();

        public abstract void BuilderPartB();

        public abstract Product GetResult();
    }
}
