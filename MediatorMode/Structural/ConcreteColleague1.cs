using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode.Structural
{
    /// <summary>
    /// 同事1
    /// </summary>
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(string name, Mediator mediator) : base(name, mediator)
        {

        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("{0} 得到消息 ：{1} ", Name, message);
        }
    }
}
