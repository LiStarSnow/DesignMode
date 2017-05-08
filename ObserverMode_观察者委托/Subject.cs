using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode_观察者委托
{
    /// <summary>
    /// 通知者接口
    /// </summary>
    public interface Subject
    {

        string SubjectState
        {
            get;
            set;
        }

        /// <summary>
        /// 通知观察者
        /// </summary>
        void Notify();
    }
}
