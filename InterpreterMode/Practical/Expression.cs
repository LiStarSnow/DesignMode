using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMode.Practical
{
    /// <summary>
    /// 抽象表达式
    /// <para>声明一个抽象的解释器操作，这个接口为抽象语法树中所有的节点所共享</para>
    /// </summary>
    public abstract class Expression
    {
        public void Interpret(PlayContext context)
        {
            if (context.PlayText.Length == 0)
            {
                return;
            }
            else
            {
                string PlayKey = context.PlayText.Substring(0, 1);
                context.PlayText = context.PlayText.Substring(2);

                double PlayValue = Convert.ToDouble(context.PlayText.Substring(0, context.PlayText.IndexOf(" ")));

                context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(" ") + 1);

                Execute(PlayKey, PlayValue);
            }
        }

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public abstract void Execute(string key, double value);
    }
}
