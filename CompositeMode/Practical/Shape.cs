using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMode.Practical
{
    public abstract class Shape
    {
        protected string _name;

        public Shape(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// 面积
        /// </summary>
        /// <returns></returns>
        public abstract double Area();

        /// <summary>
        /// 显示
        /// </summary>
        public abstract void Display();
    }
}
