using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PedoPM01.Classes
{
    public class ManageSubTask
    {
        public int SubTaskID { get; set; }
        public string SubTaskName { get; set; }
        public int Task_ID { get; set; }
        public string Remarks { get; set; }
        public double Percantage { get; set; }
        public int User_ID { get; set; }
        public DateTime EntryDate { get; set; }
        public int Project_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadlineDate { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedoDB"].ConnectionString);

        public int InsertSubTask()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertSubTask";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@SubTaskName", SubTaskName);
                cmd.Parameters.AddWithValue("@DefineTask_ID ", Task_ID);
                cmd.Parameters.AddWithValue("@Remarks ", Remarks);
                cmd.Parameters.AddWithValue("@Percentage", Percantage);
                cmd.Parameters.AddWithValue("@User_ID", User_ID);
                cmd.Parameters.AddWithValue("@EntryDate ", EntryDate);
                cmd.Parameters.AddWithValue("@Project_ID ", Project_ID);
                //cmd.Parameters.AddWithValue("@StartDate", StartDate);
                //cmd.Parameters.AddWithValue("@CompletionDate", DeadlineDate);

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
        public int UpdateSubTask()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_UpdateSubTask";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@SubTaskID", SubTaskID);
                cmd.Parameters.AddWithValue("@TaskProgress", SubTaskName);
                cmd.Parameters.AddWithValue("@Remarks ", Remarks);
                cmd.Parameters.AddWithValue("@Percentage", Percantage);

                int RowsAffected = (int)cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                    return 1;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable getAllMainTask()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectAllFromMainTask";
            cmd.Connection = con;

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }

        public DataTable getDefineTaskbyProject(int project_ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getDefineTasktbyProject";
            cmd.Parameters.AddWithValue("@Project_ID", project_ID);
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
        public DataTable GetSubTaskByMainTask(int mainTask_ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetSubTaskByMainTask";
            cmd.Parameters.AddWithValue("@MainTaskID", mainTask_ID);
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public DataTable GetAllSubTask()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectFromSubTask";
            cmd.Connection = con;

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }
        

    }
}