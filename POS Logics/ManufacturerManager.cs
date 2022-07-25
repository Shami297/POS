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
   public class ManufacturerManager
    {
        public List<Manufacturer> GetManufacturers()
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Manufacture", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            SqlDataReader rdr = sql_cmnd.ExecuteReader();
            while (rdr.Read())
            {
                Manufacturer manufacturer = new Manufacturer();
                manufacturer.ID = Convert.ToInt32(rdr[0]);
                manufacturer.Name = Convert.ToString(rdr[1]);
                manufacturers.Add(manufacturer);

            }
            DBconnection.conn.Close();
            return manufacturers;

        }
    }
}
