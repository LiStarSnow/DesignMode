using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode
{
    /// <summary>
    /// 抽象通知者
    /// </summary>
    public abstract class Subject
    {
        /// <summary>
        /// 通知者观察列表
        /// </summary>
        private IList<Observer> observers = new List<Observer>();

        /// <summary>
        /// 增加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 通知观察者
        /// </summary>
        public void Notify()
        {
            foreach(Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
