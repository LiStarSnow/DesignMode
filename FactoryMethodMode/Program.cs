using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMode
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory operFactory = new OperationAddFactory();
            var oper = operFactory.CreateOperation();

            oper.NumberA = 1;
            oper.NumberB = 2;

            Console.WriteLine("结果：{0}" ,oper.GetResult());


            Creator creator = new ConcreteCeator();
            var pro = creator.FactoryMethod();
            pro.Display();


            Console.ReadKey();
        }
    }
}
