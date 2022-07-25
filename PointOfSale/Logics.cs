using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public class Logics
    {
        public void addCategory(string Name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Category", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 1;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void viewCategory(DataGridView dataGrid)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Category", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void SearchCategory(DataGridView dataGrid, string Name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Category", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 3;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void deleteCategory(int id)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Category", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 4;
            sql_cmnd.Parameters.AddWithValue("@CategoryID", SqlDbType.BigInt).Value = id;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void UpdateCategory(string Name, int catID)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Category", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 5;
            sql_cmnd.Parameters.AddWithValue("@CategoryID", SqlDbType.BigInt).Value = catID;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public bool checkCategoryDuplication(string name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Category", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 6;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.Int).Value = name;
            SqlDataAdapter sda = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DBconnection.conn.Close();
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void addSubCategory(string Name, int catID)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_SubCategory", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 1;
            sql_cmnd.Parameters.AddWithValue("@CategoryID", SqlDbType.BigInt).Value = catID;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void viewSubCategory(DataGridView dataGrid)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_SubCategory", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void SearchSubCategory(DataGridView dataGrid, string Name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_SubCategory", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 3;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void deleteSubCategory(int id)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_SubCategory", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 4;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = id;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void UpdateSubCategory(string Name, int subCatID, int catID)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_SubCategory", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 5;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = subCatID;
            sql_cmnd.Parameters.AddWithValue("@CategoryID", SqlDbType.BigInt).Value = catID;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public bool checkSubCategoryDuplication(string name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_SubCategory", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 7;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.Int).Value = name;
            SqlDataAdapter sda = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DBconnection.conn.Close();
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void addProduct(string Name, string Barcode, int catID, int mnfID, int subCat, string description, int Cost, int ListPrice, int SalePrice, int CreatedBy, int MinimumQty, int TargetQty, string Location)
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "dbo.SPR_Products";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 1;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            sql_cmnd.Parameters.AddWithValue("@Barcode", SqlDbType.VarChar).Value = Barcode;
            sql_cmnd.Parameters.AddWithValue("@Cat_ID", SqlDbType.Int).Value = catID;
            sql_cmnd.Parameters.AddWithValue("@Mnf_ID", SqlDbType.Int).Value = mnfID;
            sql_cmnd.Parameters.AddWithValue("@SubCat_ID", SqlDbType.Int).Value = subCat;
            sql_cmnd.Parameters.AddWithValue("@Cost", SqlDbType.BigInt).Value = Cost;
            sql_cmnd.Parameters.AddWithValue("@ListPrice", SqlDbType.BigInt).Value = ListPrice;
            sql_cmnd.Parameters.AddWithValue("@SalePrice", SqlDbType.BigInt).Value = SalePrice;
            sql_cmnd.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = description;
            sql_cmnd.Parameters.AddWithValue("@CreatedBy", SqlDbType.BigInt).Value = CreatedBy;
            sql_cmnd.Parameters.AddWithValue("@MinimumQty", SqlDbType.Int).Value = MinimumQty;
            sql_cmnd.Parameters.AddWithValue("@TargetQty", SqlDbType.BigInt).Value = TargetQty;
            sql_cmnd.Parameters.AddWithValue("@Location", SqlDbType.VarChar).Value = Location;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void viewProduct(DataGridView dataGrid)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Products", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void SearchProduct(DataGridView dataGrid, string Name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Products", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 3;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void deleteProduct(int id)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Products", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 4;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = id;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void updateProduct(string Name, string Barcode, int proID, int catID, int mnfID, int subCat, string description, int Cost, int ListPrice, int SalePrice, int MinimumQty, int TargetQty, string Location)
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "dbo.SPR_Products";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 5;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = proID;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            sql_cmnd.Parameters.AddWithValue("@Barcode", SqlDbType.VarChar).Value = Barcode;
            sql_cmnd.Parameters.AddWithValue("@Cat_ID", SqlDbType.Int).Value = catID;
            sql_cmnd.Parameters.AddWithValue("@Mnf_ID", SqlDbType.Int).Value = mnfID;
            sql_cmnd.Parameters.AddWithValue("@SubCat_ID", SqlDbType.Int).Value = subCat;
            sql_cmnd.Parameters.AddWithValue("@Cost", SqlDbType.BigInt).Value = Cost;
            sql_cmnd.Parameters.AddWithValue("@ListPrice", SqlDbType.BigInt).Value = ListPrice;
            sql_cmnd.Parameters.AddWithValue("@SalePrice", SqlDbType.BigInt).Value = SalePrice;
            sql_cmnd.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = description;
            sql_cmnd.Parameters.AddWithValue("@MinimumQty", SqlDbType.Int).Value = MinimumQty;
            sql_cmnd.Parameters.AddWithValue("@TargetQty", SqlDbType.BigInt).Value = TargetQty;
            sql_cmnd.Parameters.AddWithValue("@Location", SqlDbType.VarChar).Value = Location;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public bool checkProductDuplication(string name, int proID, int mnfID)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Products", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 6;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.Int).Value = name;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = proID;
            sql_cmnd.Parameters.AddWithValue("@Mnf_ID", SqlDbType.Int).Value = mnfID;
            SqlDataAdapter sda = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DBconnection.conn.Close();
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool checkProductName(string name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Products", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 9;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.Int).Value = name;
            SqlDataAdapter sda = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DBconnection.conn.Close();
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool checkBarcodeDuplication(string barcode, int proID)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Products", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 8;
            sql_cmnd.Parameters.AddWithValue("@Barcode", SqlDbType.VarChar).Value = barcode;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = proID;
            SqlDataAdapter sda = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DBconnection.conn.Close();
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void addManufacture(string Name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Manufacture", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 1;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void viewManufacture(DataGridView dataGrid)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Manufacture", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void SearchManufacture(DataGridView dataGrid, string Name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Manufacture", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 3;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void deleteManufacture(int id)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Manufacture", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 4;
            sql_cmnd.Parameters.AddWithValue("@ManufactureID", SqlDbType.BigInt).Value = id;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void UpdateManufacture(string Name, int ID)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Manufacture", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 5;
            sql_cmnd.Parameters.AddWithValue("@ManufactureID", SqlDbType.BigInt).Value = ID;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = Name;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public bool checkManufacturerDuplication(string name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Manufacture", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 6;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.Int).Value = name;
            SqlDataAdapter sda = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DBconnection.conn.Close();
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public void addCustomer(string Name, string address, string contactno, string accountno, string email)
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "dbo.SPR_Customer";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 1;
            sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Name;
            sql_cmnd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = address;
            sql_cmnd.Parameters.AddWithValue("@ContactNo", SqlDbType.BigInt).Value = contactno;
            sql_cmnd.Parameters.AddWithValue("@AccountNo", SqlDbType.BigInt).Value = accountno;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }


        public void viewCustomer(DataGridView dataGrid)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Customer", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void SearchCustomer(DataGridView dataGrid, string Name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Customer", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 3;
            sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Name;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void deleteCustomer(int id)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Customer", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 4;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = id;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void updateCustomer(string Name, int ID, string address, string contactno, string accountno, string email)
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "dbo.SPR_Customer";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 5;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.VarChar).Value = ID;
            sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Name;
            sql_cmnd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = address;
            sql_cmnd.Parameters.AddWithValue("@ContactNo", SqlDbType.BigInt).Value = contactno;
            sql_cmnd.Parameters.AddWithValue("@AccountNo", SqlDbType.BigInt).Value = accountno;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public bool checkCustomerDuplication(string name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Customer", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 6;
            sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.Int).Value = name;
            SqlDataAdapter sda = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DBconnection.conn.Close();
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void addVender(string Name, string address, string no, string person, string email)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Vendor", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 1;
            sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Name;
            sql_cmnd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = address;
            sql_cmnd.Parameters.AddWithValue("@ContactNo", SqlDbType.BigInt).Value = no;
            sql_cmnd.Parameters.AddWithValue("@ContactPerson", SqlDbType.VarChar).Value = person;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void showVender(DataGridView DV)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Vendor", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            DV.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void SearchVendor(DataGridView dataGrid, string Name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Vendor", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 3;
            sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Name;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGrid.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void deleteVendor(int id)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Vendor", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 4;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = id;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void updateVendor(string Name, int ID, string address, string contactno, string person, string email)
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "SPR_Vendor";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 5;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.VarChar).Value = ID;
            sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Name;
            sql_cmnd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = address;
            sql_cmnd.Parameters.AddWithValue("@ContactNo", SqlDbType.BigInt).Value = contactno;
            sql_cmnd.Parameters.AddWithValue("@ContactPerson", SqlDbType.VarChar).Value = person;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public bool checkVendorDuplication(string name)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Vendor", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 6;
            sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.Int).Value = name;
            SqlDataAdapter sda = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DBconnection.conn.Close();
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public void productTextbox(ref TextBox box)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Purchase", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            SqlDataReader dataReader = sql_cmnd.ExecuteReader();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            while (dataReader.Read())
            {
                autotext.Add(dataReader.GetString(0));
            }
            box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //box.AutoCompleteMode = AutoCompleteMode.Suggest;
            box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            box.AutoCompleteCustomSource = autotext;
            DBconnection.conn.Close();
        }

        public void addPurchase(string Notes, int purchaseNO, int vendorID, int CreatedBy, float DiscountPercentage, float DiscountAmnt, float TotalAmount, float GSTAmount, float GstPercentage)
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "dbo.SPR_Purchase";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 1;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = vendorID;
            sql_cmnd.Parameters.AddWithValue("@purNO", SqlDbType.Int).Value = purchaseNO;
            sql_cmnd.Parameters.AddWithValue("@CreatedBy", SqlDbType.Int).Value = CreatedBy;
            sql_cmnd.Parameters.AddWithValue("@Notes", SqlDbType.VarChar).Value = Notes;
            sql_cmnd.Parameters.AddWithValue("@DiscountPercentage", SqlDbType.Float).Value = DiscountPercentage;
            sql_cmnd.Parameters.AddWithValue("@DiscountAmnt", SqlDbType.Float).Value = DiscountAmnt;
            sql_cmnd.Parameters.AddWithValue("@GSTAmount", SqlDbType.Float).Value = GSTAmount;
            sql_cmnd.Parameters.AddWithValue("@GstPercentage", SqlDbType.Float).Value = GstPercentage;
            sql_cmnd.Parameters.AddWithValue("@TotalAmnt", SqlDbType.Float).Value = TotalAmount;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void addPurchaseDetail(int ID, int proID, float quantity, float Cost, float TotalAmount)
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "SPR_Purchase";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 5;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID;
            sql_cmnd.Parameters.AddWithValue("@Mnf_ID", SqlDbType.Int).Value = proID;
            sql_cmnd.Parameters.AddWithValue("@Amnt", SqlDbType.BigInt).Value = quantity;
            sql_cmnd.Parameters.AddWithValue("@Cost", SqlDbType.BigInt).Value = Cost;
            sql_cmnd.Parameters.AddWithValue("@TotalAmnt", SqlDbType.BigInt).Value = TotalAmount;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void viewPurchase(int ID, DataGridView DV)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Purchase", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@OpCode", SqlDbType.VarChar).Value = 4;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            DV.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void viewAllPurchases(DataGridView DV)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Purchase", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@OpCode", SqlDbType.VarChar).Value = 9;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            DV.DataSource = dt;
            DBconnection.conn.Close();
        }

        public void viewPurchaseDetail(int ID ,DataGridView DV)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Purchase", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@OpCode", SqlDbType.VarChar).Value = 10;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            DV.DataSource = dt;
            DBconnection.conn.Close();
        }

        public int getAvailQty(int ID)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Purchase", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@OpCode", SqlDbType.VarChar).Value = 11;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID;
            int id = Convert.ToInt32(sql_cmnd.ExecuteScalar());
            DBconnection.conn.Close();
            return id;
        }

        public int getPurchaseID()
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "SPR_Purchase";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 7;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            int id = Convert.ToInt32(sql_cmnd.ExecuteScalar());
            DBconnection.conn.Close();
            return id;
        }

        public int getPurchaseNO()
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "SPR_Purchase";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 8;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            int no = Convert.ToInt32(sql_cmnd.ExecuteScalar());
            DBconnection.conn.Close();
            return no;
        }

        public void addInventory(int ID, float Quantity, float Cost, string Batch, string AutoBatch)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Inventory", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 1;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID;
            sql_cmnd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = Quantity;
            sql_cmnd.Parameters.AddWithValue("@AvailQty", SqlDbType.Decimal).Value = Quantity;
            sql_cmnd.Parameters.AddWithValue("@Cost", SqlDbType.Decimal).Value = Cost;
            sql_cmnd.Parameters.AddWithValue("@Batch", SqlDbType.VarChar).Value = Batch;
            sql_cmnd.Parameters.AddWithValue("@AutoBatch", SqlDbType.VarChar).Value = AutoBatch;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void viewInventory(DataGridView DV)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Inventory", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_cmnd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            DV.DataSource = dt;
            DBconnection.conn.Close();
        }

        public string getBatchNO(int PID)
        {
            string BatchNo = "";
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "SPR_Inventory";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.Int).Value = 3;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = PID;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            var reader = sql_cmnd.ExecuteReader();
            while (reader.Read())
            {
                BatchNo = reader.GetString(0);
            }
            DBconnection.conn.Close();
            return BatchNo;
        }

        public void addSale(int invoiceNO, int customerID,float GstPercentage, float GSTAmount, float DiscountPercentage, float DiscountAmnt, float FlatAmt, float TotalAmount, int CreatedBy,string Notes)
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "SPR_SaleInvoice";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 1;
            sql_cmnd.Parameters.AddWithValue("@No", SqlDbType.Int).Value = invoiceNO;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = customerID;
            sql_cmnd.Parameters.AddWithValue("@GstPercentage", SqlDbType.Float).Value = GstPercentage;
            sql_cmnd.Parameters.AddWithValue("@GstAmt", SqlDbType.Float).Value = GSTAmount;
            sql_cmnd.Parameters.AddWithValue("@DiscountPercentage", SqlDbType.Float).Value = DiscountPercentage;
            sql_cmnd.Parameters.AddWithValue("@DiscountAmnt", SqlDbType.Float).Value = DiscountAmnt;
            sql_cmnd.Parameters.AddWithValue("@DiscountFlatAmt", SqlDbType.Float).Value = FlatAmt;
            sql_cmnd.Parameters.AddWithValue("@TotalAmnt", SqlDbType.Float).Value = TotalAmount;
            sql_cmnd.Parameters.AddWithValue("@CreatedBy", SqlDbType.Int).Value = CreatedBy;
            sql_cmnd.Parameters.AddWithValue("@Notes", SqlDbType.VarChar).Value = Notes;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public void addSaleDetail(int ID, int proID, float quantity, float Cost, float TotalAmount)
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "SPR_SaleInvoice";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 2;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID;
            sql_cmnd.Parameters.AddWithValue("@pID", SqlDbType.Int).Value = proID;
            sql_cmnd.Parameters.AddWithValue("@quantity", SqlDbType.BigInt).Value = quantity;
            sql_cmnd.Parameters.AddWithValue("@amount", SqlDbType.BigInt).Value = Cost;
            sql_cmnd.Parameters.AddWithValue("@TotalAmnt", SqlDbType.BigInt).Value = TotalAmount;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }

        public int getInvoiceNO()
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "SPR_SaleInvoice";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 7;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            int no = Convert.ToInt32(sql_cmnd.ExecuteScalar());
            DBconnection.conn.Close();
            return no;
        }

        public void saleTextbox(ref TextBox box)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_SaleInvoice", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 3;
            SqlDataReader dataReader = sql_cmnd.ExecuteReader();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            while (dataReader.Read())
            {
                autotext.Add(dataReader.GetString(0));
            }
            box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            box.AutoCompleteCustomSource = autotext;
            DBconnection.conn.Close();
        }


        public int getSaleInvoiceID()
        {
            SqlCommand sql_cmnd = new SqlCommand();
            sql_cmnd.Connection = DBconnection.conn;
            sql_cmnd.CommandText = "SPR_SaleInvoice";
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 6;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DBconnection.conn.Open();
            int id = Convert.ToInt32(sql_cmnd.ExecuteScalar());
            DBconnection.conn.Close();
            return id;
        }

        public int getMnfID(string mnfName)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Purchase", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@OpCode", SqlDbType.Int).Value = 6;
            sql_cmnd.Parameters.AddWithValue("@mnfName", SqlDbType.VarChar).Value = mnfName;
            int mnfID = Convert.ToInt32(sql_cmnd.ExecuteScalar());
            DBconnection.conn.Close();
            return mnfID;
        }

        public void UpdateInventory(int productID, float quantity)
        {
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Inventory", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 4;
            sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = productID;
            sql_cmnd.Parameters.AddWithValue("@Quantity", SqlDbType.Float).Value = quantity;
            sql_cmnd.ExecuteNonQuery();
            DBconnection.conn.Close();
        }
    }
}
