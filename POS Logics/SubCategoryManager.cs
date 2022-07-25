using PointOfSale;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Logics
{
    public class SubCategoryManager
    {
        public List<SubCategory> GetSubCategories(int id)
        {
            List<SubCategory> Subcategories = new List<SubCategory>();
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_SubCategory", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 6;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = id;
            SqlDataReader rdr = sql_cmnd.ExecuteReader();
            while (rdr.Read())
            {
                SubCategory subcategory = new SubCategory();
                subcategory.ID = Convert.ToInt32(rdr[0]);
                subcategory.Name = Convert.ToString(rdr[1]);
                Subcategories.Add(subcategory);

            }
            DBconnection.conn.Close();
            return Subcategories;

        }
    }
}
