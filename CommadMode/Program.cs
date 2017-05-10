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
            Receiver receiver = new Receiver();
            Command comm = new ConcreteCommand(receiver);

            Invoker invoker = new Invoker();
            invoker.SetCommand(comm);

            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
