using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PedoPM01.Classes
{
    public class ManageFinance
    {
        public int Project_ID { get; set; }
        public int Fintype_ID { get; set; }
        public double Cost { get; set; }
        public string Remarks { get; set; }
        public int User_ID { get; set; }
        public int ProjectFin_ID { get; set; }
        public double PaidAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMode { get; set; }
        public string Particulars { get; set; }
        public int EnterByUser_No { get; set; }


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedoDB"].ConnectionString);
        public DataTable getAllFinType()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectAllFromFinType";
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public DataTable getFinTypeByProject(int Project_ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetFintypeByProject";
            cmd.Parameters.AddWithValue("@Project_ID", Project_ID);
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public double getCostByFinType(int fid,int pid, out int oparam)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "usp_GetCostByFinType";
                cmd.Connection = con;
                con.Open();
                da.SelectCommand = cmd;
                cmd.Parameters.AddWithValue("@Fintype_ID", fid);
                cmd.Parameters.AddWithValue("@Project_ID", pid);
                SqlParameter parameter = new SqlParameter("@projectFinID", SqlDbType.Int);
                parameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parameter);
                
                double result = Convert.ToDouble(cmd.ExecuteScalar());

                oparam = Convert.ToInt32(parameter.Value);
                return result;
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

        public int InsertProjectFinance()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertProjectFin";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@Project_ID", Project_ID);
                cmd.Parameters.AddWithValue("@Fintype_ID ", Fintype_ID);
                cmd.Parameters.AddWithValue("@Cost", Cost);
                cmd.Parameters.AddWithValue("@Remarks ", Remarks);
                cmd.Parameters.AddWithValue("@User_No", User_ID);

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

        public int InsertProjectPayment()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertProjectPayment";
                cmd.Connection = con;
                con.Open();
                
                cmd.Parameters.AddWithValue("@ProjectFin_ID", ProjectFin_ID);
                cmd.Parameters.AddWithValue("@PaidAmount ", PaidAmount);
                cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                cmd.Parameters.AddWithValue("@PaymentMode ", PaymentMode);
                cmd.Parameters.AddWithValue("@Particulars", Particulars);
                cmd.Parameters.AddWithValue("@User_ID", EnterByUser_No);


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
    }
}