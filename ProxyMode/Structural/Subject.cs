using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode.Structural
{
    /// <summary>
    /// 定义RealSubject和Proxy的共用接口
    /// 
    /// </summary>
    public abstract class Subject
    {
        public abstract void Request();
    }
}
