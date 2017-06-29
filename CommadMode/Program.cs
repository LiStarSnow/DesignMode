using CommadMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadMode
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 命令模式适用情形：

　　1>、将用户界面和行为分离，使两者的开发可以并行不悖。

　　2>、在需要指定、排列和执行一系列请求的情况下，适用命令模式。

　　3>、支持修改日志。

　　命令模式优点：

　　1>、命令模式将调用操作对象和知道如何实现该操作对象的解耦。

　　2>、在Command要增加新的处理操作对象很容易，可以通过创建新的继承自Command的子类来实现。

　　3>、命令模式可以和Memento模式结合使用，支持取消的操作。

　　4>、支持日志、请求队列和复合命令。
             * */

            Receiver receiver = new Receiver();
            Command comm = new ConcreteCommand(receiver);

            Invoker invoker = new Invoker();
            invoker.SetCommand(comm);

            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
