using CompositeMode.Practical;
using CompositeMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMode
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Create a tree structure
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);


            Graphics graphics = new Graphics("全部图形");

            Circle circle = new Circle("圆形", 5);
            graphics.Add(circle);

            Rectangle rectangle = new Rectangle("矩形", 4, 5);
            graphics.Add(rectangle);

            Triangle triangle = new Triangle("三角形", 3, 4, 5);
            graphics.Add(triangle);

            graphics.Display();

            Console.ReadKey();
        }
    }
}
