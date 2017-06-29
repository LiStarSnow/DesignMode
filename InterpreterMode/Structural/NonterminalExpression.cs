using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMode.Structural
{
    /// <summary>
    /// 非终结符表达式，为文法中的非终结符实现解释操作。
    /// </summary>
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}
