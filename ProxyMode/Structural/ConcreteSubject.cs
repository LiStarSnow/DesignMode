using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode.Structural
{
    /// <summary>
    /// 真实实现Subject
    /// </summary>
    internal class ConcreteSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实请求");
        }
    }
}
