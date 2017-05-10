using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMode.Practical.ExtrinsicIterator
{
    /// <summary>
    /// 定义一个具体的聚合类，实现相应迭代器的接口，返回具体迭代器的一个适当的实例。
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        /// <summary>
        /// 存储元素的集合
        /// </summary>
        private object[] objs = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        /// <summary>
        /// 创建该聚合类的迭代器
        /// </summary>
        /// <returns></returns>
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Size()
        {
            return objs.Length;
        }

        /// <summary>
        /// 获取指定序号的元素
        /// </summary>
        /// <param name="index">指定的序号</param>
        /// <returns></returns>
        public object GetElement(int index)
        {
            if (index < 0 || index > objs.Length)
            {
                return null;
            }

            return objs[index];
        }

    }
}
