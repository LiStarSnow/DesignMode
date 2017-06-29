using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode.Structural
{
    /// <summary>
    /// 代理类，实现共用接口Subject
    /// 隐藏concreteSubject
    /// </summary>
    public class Proxy : Subject
    {
        private ConcreteSubject concreteSubject;

        public override void Request()
        {
            if(concreteSubject == null)
            {
                concreteSubject = new ConcreteSubject();
            }

            concreteSubject.Request();
        }
    }
}
