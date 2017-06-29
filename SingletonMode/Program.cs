using SingletonMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMode
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            // 创建一个实例s1
            Singleton s1 = Singleton.Instance();
            // 创建一个实例s2
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("对象为相同实例");
            }
        }
    }
}
