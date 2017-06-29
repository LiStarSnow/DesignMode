using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode.Structural
{
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 concreteColleague1;

        private ConcreteColleague2 concreteColleague2;

        public ConcreteColleague1 Colleague1
        {
            set { concreteColleague1 = value; }
        }
        public ConcreteColleague2 Colleague2
        {
            set { concreteColleague2 = value; }
        }

        /// <summary>
        /// 中介者发送消息
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="colleague">发送者</param>
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == concreteColleague1)
            {
                //同事 接收消息
                concreteColleague2.Notify(message);
            }
            else
            {
                concreteColleague1.Notify(message);
            }
        }
    }
}
