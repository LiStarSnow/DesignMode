using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    public class Persion
    {
        public Persion()
        {

        }
        private string name { get; set; }
        public Persion(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的:{0}", name);
        }
    }
}
