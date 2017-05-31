using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.ID = "1";
            user.Name = "Test";

            IUser userDao = DataAccess.CreateUser();

            userDao.InsertUser(user);

            Console.ReadKey();
        }
    }
}
