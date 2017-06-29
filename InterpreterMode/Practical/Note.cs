using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMode.Practical
{
    /// <summary>
    /// 音符类
    /// </summary>
    public class Note : Expression
    {
        public override void Execute(string key, double value)
        {
            String note = string.Empty;
            switch (key)
            {
                case "C":
                    note = "1";
                    break;
                case "D":
                    note = "2";
                    break;
                case "E":
                    note = "3";
                    break;
                case "F":
                    note = "4";
                    break;
                case "G":
                    note = "5";
                    break;
                case "A":
                    note = "6";
                    break;
                case "B":
                    note = "7";
                    break;
            }

            Console.WriteLine("{0} ", note);
        }
    }
}
