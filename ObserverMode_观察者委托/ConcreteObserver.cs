using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode_观察者委托
{
    /// <summary>
    /// 具体观察者 -- 看股票的同事
    /// </summary>
    public class StockObserver// : Observer
    {
        private string name;
        /// <summary>
        /// 被观察者状态
        /// </summary>
        private Subject subject;

        public StockObserver(Subject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        /// <summary>
        /// 关闭股票行情
        /// </summary>
        public void CloseStockMarket()
        {
            Console.WriteLine("观察者 {0} {1} , 关闭股票行情继续工作！", name, subject.SubjectState);
        }

    }
}
