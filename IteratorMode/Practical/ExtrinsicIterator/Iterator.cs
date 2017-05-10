using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMode.Practical.ExtrinsicIterator
{
    /// <summary>
    /// 定义一个迭代器接口
    /// 迭代器定义访问和遍历元素的接口
    /// </summary>
    public interface Iterator
    {
        /// <summary>
        /// 迭代器定位到聚合的第一个元素
        /// </summary>
        /// <returns></returns>
        void First();
        /// <summary>
        /// 遍历下一个
        /// </summary>
        /// <returns></returns>
        void Next();
        /// <summary>
        /// 判断是否完成遍历
        /// </summary>
        /// <returns></returns>
        bool IsDone();
        /// <summary>
        /// 获得当前遍历的项
        /// </summary>
        /// <returns></returns>
        object GetElement();
    }
}
