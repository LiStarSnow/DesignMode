using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode
{
    /// <summary>
    /// 代理类，实现共用接口Subject
    /// 隐藏RealSubject
    /// </summary>
    public class Proxy : Subject
    {
        private RealSubject realSubject;

        public override void Request()
        {
            if(realSubject == null)
            {
                realSubject = new RealSubject();
            }

            realSubject.Request();
        }
    }
}
