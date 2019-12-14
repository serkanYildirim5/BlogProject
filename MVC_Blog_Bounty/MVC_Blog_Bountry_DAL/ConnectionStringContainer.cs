using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_DAL
{
    public class ConnectionStringContainer
    {
        internal static string ConnectionString
        {
            get { return "Server=.;Database=MVC_Blog_BountryDB;User Id=SA;Password = 123;MultipleActiveResultSets=true;"; }
        }
    }
}
