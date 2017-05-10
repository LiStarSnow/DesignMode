using System;

namespace CommadMode.Structural
{
    /// <summary>
    /// 命令的接收者
    /// <para>知道如何实施与执行一个请求相关的操作</para>
    /// </summary>
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
}
