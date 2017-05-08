using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode_适配器模式
{
    /// <summary>
    /// 翻译
    /// </summary>
    public class Translator : Player
    {
        ForeignCenter center = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            center.Name = name;
        }

        public override void Attack()
        {
            center.进攻();
        }

        public override void Defense()
        {
            center.防守();
        }
    }
}
