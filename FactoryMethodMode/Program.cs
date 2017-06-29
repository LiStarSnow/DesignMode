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
            /**
             *
             工厂方法模式实现时，客户端需要决定实例化哪个工厂来实现运算，选择判断的问题还是存在，
             也就是说工厂方法把简单工厂的内部逻辑判断移到了客户端来进行。
             你想要添加功能，本来是改工厂类的，而现在是修改客户端的。
             */


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
