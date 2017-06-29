using FacadeMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 外观模式：为子系统中的一组接口提供一个一致的界面。此模式定义了一个高层接口。
             * 这个接口使得这一子系统更加容易使用
             * 
             */

            Facade facade = new Facade();

            facade.MedthodA();
            facade.MedthodB();

            Console.ReadKey();
        }
    }
}
