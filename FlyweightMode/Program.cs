using FlyweightMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightMode
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             享元模式适用情形：

　　◊ 一个应用程序使用了大量的对象

　　◊ 完全由于使用大量的对象，造成很大的存储开销

　　◊ 对象的大多数状态都可变为外部状态

　　◊ 如果删除对象的外部状态，那么可以用相对较少的共享对象取代很多组对象

　　◊ 应用程序不依赖对象标识

　　享元模式特点：

　　◊ 享元模式的核心是把大量共享的对象收集在一起使用简单工厂模式进行管理，避免由于大量的小对象导致系统内存过度消耗。

　　◊ 享元当重复对象较多时有很好的空间复杂度，但在查找搜索上消耗了时间复杂度。
             */

            // Arbitrary extrinsic state
            int extrinsicstate = 22;
            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);


            Console.ReadKey();
        }
    }
}
