using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode
{
    /// <summary>
    /// 中锋
    /// </summary>
    public class Center : Player
    {
        public Center(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("中锋 {0} 进攻！", name);
        }

        public override void Defense()
        {
            Console.WriteLine("中锋 {0} 防守！", name);
        }
    }
}
