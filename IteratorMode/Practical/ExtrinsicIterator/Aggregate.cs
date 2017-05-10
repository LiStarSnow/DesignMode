using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMode.Practical.ExtrinsicIterator
{
    /// <summary>
    /// 聚合定义创建Iterator对象的接口
    /// </summary>
    public abstract    class Aggregate
    {
        public virtual Iterator CreateIterator()
        {
            return null;
        }
    }
}
