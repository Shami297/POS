using PointOfSale;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Logics
{
    public class CategoryManager
    {
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Category", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            SqlDataReader rdr = sql_cmnd.ExecuteReader();
            while (rdr.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(rdr[0]);
                category.Name = Convert.ToString(rdr[1]);
                categories.Add(category);

            }
            DBconnection.conn.Close();
            return categories;

        }
    }
}
