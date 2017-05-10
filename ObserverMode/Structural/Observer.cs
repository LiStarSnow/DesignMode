using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode.Structural
{
    /// <summary>
    /// 抽象观察者
    /// <para>定义一个发送变化通知更新的接口。</para>
    /// </summary>
    public interface Observer
    {
        /// <summary>
        /// 更新方法
        /// </summary>
        void Update();
    }
}
