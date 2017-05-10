using StateMode.Practical;
using StateMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 状态模式

            /*
             * 当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变其类。
             * 
             * 状态模式主要解决的是当控制一个对象状态转换的条件表达式过于复杂的情况。
             * 把状态的判断逻辑转移到表示不同的状态的一系列类中，可以把复杂的判断逻辑简化。
             * 
             * 把特定的状态相关的行为都放入一个对象中，由于所有与状态相关的代码都存在于某个ConcreteState中，
             * 所以通过定义新的子类可以很容易地增加新的状态和装换
             */
            Console.WriteLine("*******************************状态模式*******************************");

            Context context = new Context(new ConcreteStateA());

            context.Request();
            context.Request();


            #endregion 状态模式


            Task task = new Task();
            task.State = new PendingState();

            task.Start();

            //task.Start();

            task.Cancel();

            Console.ReadKey();

        }
    }
}
