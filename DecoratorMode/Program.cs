using DecoratorMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();


            #region 装扮模式
            Console.WriteLine("*******************************装扮模式*******************************");
            /*   
             * Persion persion = new Persion("周杰伦");

                        TShirts ts = new TShirts();
                        BigTrouser bt = new BigTrouser();

                        Console.WriteLine("第一种装扮：");

                        ts.Decorate(persion);
                        bt.Decorate(ts);

                        bt.Show();

                        //TShirts ts2 = new TShirts();
                        BigTrouser bt2 = new BigTrouser();

                        Console.WriteLine("第二种装扮：");
                        //ts2.Decorate(persion);
                        bt2.Decorate(persion);

                        bt2.Show();

             **/
            #endregion 装扮模式

            Console.ReadKey();
        }
    }
}
