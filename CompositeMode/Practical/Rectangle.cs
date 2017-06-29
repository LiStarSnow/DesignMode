using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMode.Practical
{
    /// <summary>
    /// 矩形
    /// </summary>
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public Rectangle(string name, double width, double height)
            : base(name)
        {
            this._width = width;
            this._height = height;
        }

        public override double Area()
        {
            return _width * _height;
        }

        public override void Display()
        {
            Console.WriteLine("{0} 长：{1}，宽：{2}，面积：{3}", _name, _width, _height, this.Area());
        }
    }
}
