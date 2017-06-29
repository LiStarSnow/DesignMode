using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode.Structural
{
    /// <summary>
    /// 外观类
    /// 通过外观类把子系统的多个功能封装到一个或者多个函数。
    /// 使客户端能更简单的调用子系统功能。
    /// </summary>
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        /// <summary>
        /// 
        /// </summary>
        public void MedthodA()
        {
            one.MedthodOne();
            two.MedthodTwo();
        }

        public void MedthodB()
        {
            one.MedthodOne();
            two.MedthodTwo();
            three.MedthodThree();
            four.MedthodFour();
        }
    }
}
