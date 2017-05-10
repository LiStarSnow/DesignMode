using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode
{
    /// <summary>
    /// 球员
    /// </summary>
    public abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 进攻
        /// </summary>
        public abstract void Attack();

        /// <summary>
        /// 防守
        /// </summary>
        public abstract void Defense();
    }
}
