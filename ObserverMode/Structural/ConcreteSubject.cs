using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode.Structural
{
    /// <summary>
    /// 具体的被观察对象
    /// <para>维持ConcreteSubject状态。当状态发生变化时，发送消息通知它的观察者。</para>
    /// </summary>
    public class ConcreteSubject : Subject
    {
        private string subjectState;

        /// <summary>
        /// 具体被观察者状态
        /// </summary>
        public string SubjectState
        {
            get
            {
                return subjectState;
            }

            set
            {
                subjectState = value;
            }
        }
    }
}
