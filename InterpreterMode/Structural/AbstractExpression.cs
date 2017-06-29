using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMode.Structural
{
    /// <summary>
    /// 抽象表达式
    /// <para>声明一个抽象的解释器操作，这个接口为抽象语法树中所有的节点所共享</para>
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
