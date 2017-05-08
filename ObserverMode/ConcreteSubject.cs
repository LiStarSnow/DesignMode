using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode
{
    /// <summary>
    /// 具体通知者
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
