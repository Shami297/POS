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
    public class VendorManager
    {
        public List<Vendor> GetVendors()
        {
            List<Vendor> vendors = new List<Vendor>();
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Vendor", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 7;
            SqlDataReader rdr = sql_cmnd.ExecuteReader();
            while (rdr.Read())
            {
                Vendor vendor = new Vendor();
                vendor.ID = Convert.ToInt32(rdr[0]);
                vendor.Name = Convert.ToString(rdr[1]);
                vendors.Add(vendor);

            }
            DBconnection.conn.Close();
            return vendors;

        }
    }
}
