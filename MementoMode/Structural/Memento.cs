using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoMode.Structural
{
    /// <summary>
    /// 备忘录
    /// </summary>
    public class Memento
    {
        private string state;

        public string State
        {
            get { return this.state; }
        }

        public Memento(string state)
        {
            this.state = state;
        }
    }
}
