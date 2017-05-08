using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMode
{
    public class WorkExperience : ICloneable
    {
        public string timeArea { get; set; }

        public string company { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
