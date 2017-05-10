using IteratorMode.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMode
{
    class Program
    {

        private Practical.ExtrinsicIterator.Iterator _iterator;
        private Practical.ExtrinsicIterator.Aggregate _aggregate = new Practical.ExtrinsicIterator.ConcreteAggregate();

        public void Operation()
        {
            // 获得迭代器
            _iterator = _aggregate.CreateIterator();

            while (!_iterator.IsDone())
            {
                Console.WriteLine(_iterator.GetElement());
                _iterator.Next();
            }
        }

        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            ConcreteIterator i = new ConcreteIterator(a);

            Console.WriteLine("Iterating over collection:");
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Program p = new Program();
            p.Operation();

            Console.ReadKey();
        }
    }
}
