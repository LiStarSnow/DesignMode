using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMode.Practical
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Singleton
    {
        private Singleton()
        {
        }

        #region 饿汉式单例模式，加载时就实例化

        private static readonly Singleton instance = new Singleton();

        public static Singleton GetInstance()
        {
            return instance;
        }

        #endregion 饿汉式单例模式，加载时就实例化

        #region 懒汉式单例模式，第一次引用实例化

        private static Singleton _instance;

        private static readonly object _syncLock = new object();

        // 将构造函数设为private，防止通过new实例化对象

        /// <summary>
        /// 获取实例，并加入判断逻辑，保证实例只被创建一次
        /// </summary>
        /// <returns></returns>
        public static Singleton Instance()
        {

            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }

        #endregion 懒汉式单例模式，第一次引用实例化
    }
}
