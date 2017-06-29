using ProxyMode.Practical;
using ProxyMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();

            #region 代理模式实践应用
            // Create math proxy
            MathProxy proxy1 = new MathProxy();

            // Do the math
            Console.WriteLine("4 + 2 = " + proxy1.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy1.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy1.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy1.Div(4, 2));

            #endregion 代理模式实践应用

            Console.ReadKey();
        }
    }
}
