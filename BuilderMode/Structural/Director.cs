using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode.Structural
{
    /// <summary>
    /// 构造一个使用Builder接口的对象
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 使用Builder接口的对象按步骤和次序进行组装
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
        }

    }
}
