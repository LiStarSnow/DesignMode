using System.Collections.Generic;

namespace ObserverMode.Structural
{
    /// <summary>
    /// 抽象的主题，被观察的对象
    /// <para>提供Attach和Detach Observer对象的接口</para>
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
