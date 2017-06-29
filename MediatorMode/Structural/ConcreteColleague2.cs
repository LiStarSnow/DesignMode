using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode.Structural
{
    /// <summary>
    /// 同事2
    /// </summary>
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(string name, Mediator mediator) : base(name, mediator)
        {

        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        /// <summary>
        /// 接受消息
        /// </summary>
        /// <param name="message"></param>
        public void Notify(string message)
        {
            Console.WriteLine("{0} 得到消息 ：{1} ", Name, message);
        }
    }
}
