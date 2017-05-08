using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
    public interface Observer
    {
        /// <summary>
        /// 更新方法
        /// </summary>
        void Update();
    }
}
