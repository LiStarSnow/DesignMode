using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BygherrerMode
{
    public class Product
    {
        private IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("产品 创建 -- ");

            foreach (string part in parts)
            {
                Console.WriteLine("部件： " + part);
            }
        }
    }
}
