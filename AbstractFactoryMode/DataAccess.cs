using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace AbstractFactoryMode
{
    public class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactoryMode";
        private static readonly string db = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public static IUser CreateUser()
        {
            IUser iu = null;
            //switch (db)
            //{
            //    case "SQL Server":
            //        iu = new SqlServerUser();
            //        break;
            //    case "Access":
            //        iu = new AccessUser();
            //        break;
            //}
            string typeName = AssemblyName + "." + db + "User";
            iu = Assembly.Load(AssemblyName).CreateInstance(typeName) as IUser;

            return iu;
        }
    }
}
