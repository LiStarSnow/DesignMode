using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMode
{
    public class Resume : ICloneable
    {
        private string name;
        private string sex;
        private int age;
        private WorkExperience workExperience;
        private string timeArea;
        private string company;

        public Resume(string name)
        {
            this.name = name;
            workExperience = new WorkExperience();
        }

        private Resume(WorkExperience workExperience)
        {
            this.workExperience = (WorkExperience)workExperience.Clone();
        }

        public void SetPersonalInfo(string sex, int age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            workExperience.timeArea = timeArea;
            workExperience.company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历：{0} {1}", workExperience.company, workExperience.timeArea);
        }

        public object Clone()
        {
            Resume obj = new Resume(this.workExperience);
            obj.name = name;
            obj.sex = sex;
            obj.age = age;
            return obj;
        }

    }
}
