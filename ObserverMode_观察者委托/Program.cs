using System;
using ObserverMode_观察者委托.Structural;

namespace ObserverMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************观察者委托模式*******************************");

            Boss boss = new Boss();
            boss.SubjectState = "老板回来了。";
            StockObserver stockObserver1 = new StockObserver(boss, "周杰伦");
            boss.u += stockObserver1.CloseStockMarket;
            NBAObserver stockObserver2 = new NBAObserver(boss, "chenxi");
            boss.u += stockObserver2.CloseNBAMarket;

            boss.Notify();

            Secretary secretary = new Secretary();
            secretary.SubjectState = "回来啦。";
            StockObserver stockObserver3 = new StockObserver(secretary, "周杰伦");
            secretary.u += stockObserver3.CloseStockMarket;
            NBAObserver stockObserver4 = new NBAObserver(secretary, "周杰伦");
            secretary.u += stockObserver4.CloseNBAMarket;

            secretary.Notify();

            Console.ReadKey();
        }
    }
}
