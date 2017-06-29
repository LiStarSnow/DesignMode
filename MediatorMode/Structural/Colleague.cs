using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode.Structural
{
    /// <summary>
    /// 抽象同事类
    /// </summary>
    public abstract class Colleague
    {
        public string Name { get; set; }

        public Mediator Mediator { get; set; }

        public Colleague(string name,Mediator mediator)
        {
            this.Name = name;
            this.Mediator = mediator;
        }
    }
}
