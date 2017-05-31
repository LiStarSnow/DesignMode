using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode.Structural
{
    /// <summary>
    ///  实现Builder的接口以构造和装配该产品的各个部件
    ///  <para>定义并明确它所创建的表示</para>
    ///  <para> 提供一个检索Product的接口 </para>
    /// </summary>
    public class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();

        /// <summary>
        /// 建造具体部件A的具体实现
        /// </summary>
        public override void BuilderPartA()
        {
            product.Add("建造部件A");
        }

        /// <summary>
        /// 建造具体部件B的具体实现
        /// </summary>
        public override void BuilderPartB()
        {
            product.Add("建造部件B");
        }

        /// <summary>
        /// 返回产品
        /// </summary>
        /// <returns></returns>
        public override Product GetResult()
        {
            return product;
        }
    }
}
