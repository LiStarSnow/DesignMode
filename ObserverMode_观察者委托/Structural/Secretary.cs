using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode_观察者委托.Structural
{
    public class Secretary : Subject
    {
        /// <summary>
        /// 观察者更新方法
        /// </summary>
        public Action u;

        public string SubjectState
        {
            get;
            set;
        }

        public void Notify()
        {
            u();
        }
    }
}
