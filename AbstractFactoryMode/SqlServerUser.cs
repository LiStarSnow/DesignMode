using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMode
{
    public class SqlServerUser : IUser
    {
        public void InsertUser(User user)
        {
            Console.WriteLine("在SQL Server中给User表添加了一条记录");
        }

        public User GetUser(string Id)
        {
            Console.WriteLine("在SQL Server中根据Id获取User表一条记录");
            return null;
        }
    }
}
