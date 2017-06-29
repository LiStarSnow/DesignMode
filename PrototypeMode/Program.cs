using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************原型模式*******************************");
            /**
             * 一般在初始化信息不发生变化的情况下，克隆是最好的办法。
             * 这既隐藏了对象的创建细节，又对性能是大大的提高。
             * 需要注意的是引用类型的克隆，只克隆引用不克隆对象本身。
             * 
             */

            Resume resume = new Resume("LJS");
            resume.SetPersonalInfo("男", 11);
            resume.SetWorkExperience("海虹", "2011~2022");

            Resume resumeb = resume.Clone() as Resume;
            resume.SetWorkExperience("中公网", "2011~2024");

            resume.Display();
            resumeb.Display();

            Console.ReadKey();
        }
    }
}
