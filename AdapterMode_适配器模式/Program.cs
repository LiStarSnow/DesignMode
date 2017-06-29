using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdapterMode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 将一个类的接口转换成客户希望的另一个接口。Adapter 模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。
             * 
             */
            Console.WriteLine("*******************************适配器模式*******************************");

            Player forwards = new Forwards("麦迪");
            forwards.Attack();

            Player guards = new Guards("买买提");
            guards.Defense();

            Translator foreignCenter = new Translator("姚明");
            foreignCenter.Attack();
            foreignCenter.Defense();
        }
    }
}
