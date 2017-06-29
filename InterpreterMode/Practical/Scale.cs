using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMode.Practical
{
    public class Scale : Expression
    {
        public override void Execute(string key, double value)
        {
            string scale = string.Empty;
            switch (Convert.ToInt16(value))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
            }
            Console.WriteLine("{0} ", scale);
        }
    }
}
