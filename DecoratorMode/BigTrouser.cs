using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    public class BigTrouser : Finery
    {
        public override void Show()
        {
            
            Console.WriteLine("大垮裤");
            base.Show();
        }
    }
}
