using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMode.Practical
{
    public class Graphics : Shape
    {
        private List<Shape> _children = new List<Shape>();

        public Graphics(string name)
            : base(name)
        { }

        public override double Area()
        {
            double sum = 0;
            foreach (Shape child in _children)
            {
                sum += child.Area();
            }
            return sum;
        }

        public override void Display()
        {
            foreach (Shape child in _children)
            {
                child.Display();
            }

            Console.WriteLine("{0} 总面积：{1}", _name, this.Area());
        }

        public void Add(Shape child)
        {
            _children.Add(child);
        }

        public void Remove(Shape child)
        {
            _children.Remove(child);
        }
    }
}
