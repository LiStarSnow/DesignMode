using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorandumMode_备忘录模式
{
    /// <summary>
    /// 发起人
    /// </summary>
    public class Originator
    {
        private string state;

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        /// <summary>
        /// 创建备忘录，将需要保存的信息导入并实例化出一个Memento对象。
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        /// <summary>
        /// 还原备份
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            this.state = memento.State;
        }

        public void Show()
        {
            Console.WriteLine("State = " + state);
        }

    }
}
