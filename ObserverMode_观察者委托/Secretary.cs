﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode_观察者委托
{
    public class Secretary : Subject
    {
        public Action u;

        public string SubjectState
        {
            get;
            set;
        }

        public void Notify()
        {
            u();
        }
    }
}
