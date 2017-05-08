using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMode
{
    public interface IFactory
    {
        IUser CreateUser();
    }
}
