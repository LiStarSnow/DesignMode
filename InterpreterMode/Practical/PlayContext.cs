using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMode.Practical
{
    /// <summary>
    /// 演奏内容
    /// </summary>
    public class PlayContext
    {
        private string text;

        /// <summary>
        /// 演奏文本
        /// </summary>
        public string PlayText
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }
    }
}
