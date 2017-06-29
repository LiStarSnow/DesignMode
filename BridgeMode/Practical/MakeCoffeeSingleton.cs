using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode.Practical
{
    /// <summary>
    /// 单件模式类用来加载当前MakeCoffee
    /// </summary>
    public sealed class MakeCoffeeSingleton
    {
        private static MakeCoffee _instance;

        public MakeCoffeeSingleton(MakeCoffee instance)
        {
            _instance = instance;
        }

        public static MakeCoffee Instance()
        {
            return _instance;
        }

    }
}
