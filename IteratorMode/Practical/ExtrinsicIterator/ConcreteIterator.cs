using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMode.Practical.ExtrinsicIterator
{
    /// <summary>
    /// 定义具体的迭代器类
    /// <para>具体迭代器实现迭代器接口
    /// 对该聚合遍历时跟踪当前位置</para>
    /// </summary>
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int index = 0;
        private int size = 0;

        /// <summary>
        /// 根据不同的聚合类进行初始化
        /// </summary>
        /// <param name="aggregate"></param>
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            size = aggregate.Size();
            index = 0;
        }

        /// <summary>
        /// 获取当前遍历的元素
        /// </summary>
        /// <returns></returns>
        public object GetElement()
        {
            return aggregate.GetElement(index);
        }

        public  void First()
        {
            index = 0;
        }

        /// <summary>
        /// 判断是否遍历完毕
        /// </summary>
        /// <returns></returns>
        public bool IsDone()
        {
            return index >= size;
        }

        public void Next()
        {
            if(index < size)
            {
                index++;
            }
        }
    }
}
