using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PedoPM01.Classes
{
    public class ManageDistricts
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedoDB"].ConnectionString);
        public string DistrictsName { get; set; }

        public int InsertDistrict()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertDistrict";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@District", DistrictsName);
                
                int RowsAffected = (int)cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                    return 1;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public DataTable getDistrict()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectAllFromDistrict";
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            return dt;
        }
    }
}