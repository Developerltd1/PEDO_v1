using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PedoPM01.Classes
{
    public class ManageAssociatedTask
    {
        public string AssociatedTaskName { get; set; }
        public string SubmissionProgress { get; set; }
        public string ApprovedProgress { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int Project_ID { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedoDB"].ConnectionString);

        public int InsertAssociatedTask()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertAssociatedTask";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@Project_ID", Project_ID);
                cmd.Parameters.AddWithValue("@AssociatedTaskName", AssociatedTaskName);
                cmd.Parameters.AddWithValue("@SubmissionProgress", SubmissionProgress);
                cmd.Parameters.AddWithValue("@ApprovedProgress ", ApprovedProgress);
                if (SubmissionDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@SubmissionDate", SubmissionDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SubmissionDate", null);
                }
                if (ApprovedDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ApprovedDate", ApprovedDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ApprovedDate", null);
                }
                
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

        public DataTable SelectAllAssociatedTask()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectFromAssociatedTask";
            cmd.Connection = con;

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }
    }
}