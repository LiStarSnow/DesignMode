using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    //服饰
    public class Finery : Persion
    {
        protected Persion component { get; set; }

        //打扮
        public void Decorate(Persion persion)
        {
            this.component = persion;
        }


        public override void Show()
        {
            if (this.component != null)
            {
                component.Show();
            }
        }

    }
}
