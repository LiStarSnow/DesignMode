using InterpreterMode.Practical;
using InterpreterMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMode
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * 给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言中的句子。
             * 
             * */


            Context context = new Context();

            IList<AbstractExpression> list = new List<AbstractExpression>();

            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression item in list)
            {
                item.Interpret(context);
            }


            #region 音乐解释器

            PlayContext playContext = new PlayContext();

            Console.Write("上海滩：");
            playContext.PlayText = "O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3";

            Expression expression = null;
            try
            {
                while (playContext.PlayText.Length > 0)
                {
                    string str = playContext.PlayText.Substring(0, 1);
                    switch (str)
                    {
                        //首字符为O时，则表达式实例化为音阶。
                        case "O":
                            expression = new Scale();
                            break;
                         //首字母是CDEFGAB，以及休止符P时，则实例化音符。
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                        case "P":
                            expression = new Note();
                            break;

                    }

                    expression.Interpret(playContext);
                }

            }
            catch (Exception ex)
            {

            }


            #endregion


            Console.Read();

        }
    }
}
