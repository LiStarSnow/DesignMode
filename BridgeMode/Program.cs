using BridgeMode.Practical;
using BridgeMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();

            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();

            #region 桥接模式实际应用

            MakeCoffeeSingleton whiteCoffeeSingleton = new MakeCoffeeSingleton(new WhiteCoffee());

            // 中杯牛奶咖啡
            MediumCupCoffee mediumWhiteCoffee = new MediumCupCoffee();
            mediumWhiteCoffee.Make();

            // 大杯牛奶咖啡
            LargeCupCoffee largeCupWhiteCoffee = new LargeCupCoffee();
            largeCupWhiteCoffee.Make();

            MakeCoffeeSingleton blackCoffeeSingleton = new MakeCoffeeSingleton(new BlackCoffee());
            // 中杯原味咖啡
            MediumCupCoffee mediumBlackCoffee = new MediumCupCoffee();
            mediumBlackCoffee.Make();

            // 大杯牛奶咖啡
            LargeCupCoffee largeCupBlackCoffee = new LargeCupCoffee();
            largeCupBlackCoffee.Make();

            #endregion 桥接模式实际应用

            Console.ReadKey();
        }
    }
}
