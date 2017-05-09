using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorandumMode_备忘录模式
{
    /// <summary>
    /// 管理备忘录类
    /// </summary>
    public class Caretaker
    {
        private Memento memento;

        public Memento Memento
        {
            get { return this.memento; }
            set { this.memento = value; }
        }

        public Caretaker()
        {
            this.memento = memento;
        }

    }
}
