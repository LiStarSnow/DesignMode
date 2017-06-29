using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMode.Structural
{
    /// <summary>
    ///  声明组合中对象的接口
    ///  <para>实现全部类中公共接口的默认行为</para>
    ///  <para> 声明访问和管理子类的接口；</para>
    /// <para>（可选择）定义接口提供在递归结构中访问父类。</para>
    /// </summary>
    public abstract class Component
    {
        protected string _name;

        public Component(string name)
        {
            this._name = name;
        }

        public abstract void Add(Component c);

        public abstract void Remove(Component c);

        public abstract void Display(int depth);
    }
}
