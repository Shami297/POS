using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
   public class DBconnection
    {
        public static readonly SqlConnection conn = new SqlConnection("Data Source=Yoanserver;Initial Catalog=YOANPOS;Persist Security Info=True;User ID=pos;Password=pospass");
    }
}
