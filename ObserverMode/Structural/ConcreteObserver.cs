using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode.Structural
{
    /// <summary>
    /// 具体观察者
    /// <para>维持一个对ConcreteSubject对象的引用。保存subjects状态。实现当Observer接口发生变动时，subjects状态同步更新。</para>
    /// </summary>
    public class ConcreteObserver : Observer
    {
        private string name;
        /// <summary>
        /// 被观察者状态
        /// </summary>
        private string observerState;

        /// <summary>
        /// 具体通知者
        /// </summary>
        private ConcreteSubject concreteSubject;

        public ConcreteObserver(ConcreteSubject concreteSubject, string name)
        {
            this.concreteSubject = concreteSubject;
            this.name = name;
        }

        /// <summary>
        /// 更新方法
        /// </summary>
        public void Update()
        {
            observerState = concreteSubject.SubjectState;
            Console.WriteLine("观察者{0}的新状态：{1}", name, observerState);
        }

        public ConcreteSubject Subject
        {
            get { return this.concreteSubject; }
            set { this.concreteSubject = value; }
        }
    }
}
