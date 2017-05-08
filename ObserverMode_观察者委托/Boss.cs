using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode_观察者委托
{
    /// <summary>
    /// 通知者 Boss
    /// </summary>
    public class Boss : Subject
    {
        /// <summary>
        /// Update 类型的委托
        /// </summary>
        public delegate void Update();

        /// <summary>
        /// Update 委托的实例
        /// </summary>
        public Update u;

        private string action;

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }

        public void Notify()
        {
            u();
        }
    }
}
