using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorMode.Structural;

namespace MediatorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            /****
             * 中介者模式：用一个中介对象来封装一系列的对象交互。中介者使各对象不需要显示的相互引用。
             * 从而使其耦合松散，而且可以独立的改变他们之间的交互。
             * 
             * */

            ConcreteMediator concreteMediator = new ConcreteMediator();


            ConcreteColleague1 colleague1 = new ConcreteColleague1("周杰伦", concreteMediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2("王祖贤", concreteMediator);
            concreteMediator.Colleague1 = colleague1;
            concreteMediator.Colleague2 = colleague2;

            concreteMediator.Send("你吃饭了吗？", colleague1);

            concreteMediator.Send("我吃过了。", colleague2);

            Console.ReadKey();

        }
    }
}
