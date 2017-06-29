using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMode.Practical
{
    /// <summary>
    /// 三角形
    /// </summary>
    public class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        /// 三角形构造函数
        /// 参数：三角形名称和三条边长
        /// </summary>
        /// <param name="name">三角形名称</param>
        /// <param name="a">第一条边长</param>
        /// <param name="b">第二条边长</param>
        /// <param name="c">第三条边长</param>
        public Triangle(string name, double a, double b, double c)
            : base(name)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double Area()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public override void Display()
        {
            Console.WriteLine("{0} 三条边长：{1}，{2}，{3},面积：{3}", _name, _a, _b, _c, this.Area());
        }
    }
}
