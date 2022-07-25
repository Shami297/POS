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
    public class CustomerManager
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_SaleInvoice", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 8;
            SqlDataReader rdr = sql_cmnd.ExecuteReader();
            while (rdr.Read())
            {
                Customer customer = new Customer();
                customer.ID = Convert.ToInt32(rdr[0]);
                customer.Name = Convert.ToString(rdr[1]);
                customers.Add(customer);

            }
            DBconnection.conn.Close();
            return customers;

        }
    }
}
