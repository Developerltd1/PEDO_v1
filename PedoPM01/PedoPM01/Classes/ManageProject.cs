using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PedoPM01.Classes
{
    public class ManageProject
    {
        public string Title { get; set; }
        public string PedoPMU { get; set; }
        public string Consultant { get; set; }
        public string Contractor { get; set; }
        public int Category_ID { get; set; }
        public int Nature_ID { get; set; }
        public bool IsChild { get; set; }
        public int ParentProject_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int User_ID { get; set; }
        public DateTime EntryDate { get; set; }
        public int District_ID { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DisableDate { get; set; }
        public int ProjectID { get; set; }
        public string Capicity { get; set; }



        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedoDB"].ConnectionString);
        public int InsertProject()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertProject";
                cmd.Connection = con;
                con.Open();
                 cmd.Parameters.AddWithValue("@Title", Title);
                 //cmd.Parameters.AddWithValue("@PedoPMU", PedoPMU);
                 cmd.Parameters.AddWithValue("@Consultant", Consultant);
                 cmd.Parameters.AddWithValue("@Contractor", Contractor);
                 cmd.Parameters.AddWithValue("@Category_ID ", Category_ID);
                 cmd.Parameters.AddWithValue("@Nature_ID", Nature_ID);
                 cmd.Parameters.AddWithValue("@IsUmbrella",IsChild );
                 cmd.Parameters.AddWithValue("@ParentProject_ID", ParentProject_ID);
                 cmd.Parameters.AddWithValue("@Commencement_Date", StartDate);
                 cmd.Parameters.AddWithValue("@Proposal_Deadline", FinishDate);
                 cmd.Parameters.AddWithValue("@User_No", User_ID);
                 cmd.Parameters.AddWithValue("@Entry_Date",EntryDate );
                 cmd.Parameters.AddWithValue("@District_ID", District_ID);
                 cmd.Parameters.AddWithValue("@Latitude ", Latitude);
                 cmd.Parameters.AddWithValue("@Longitude",Longitude );
                 cmd.Parameters.AddWithValue("@Capicity", Capicity);
                
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
        public int UpdateProject()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_UpdateProject";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Consultant", Consultant);
                cmd.Parameters.AddWithValue("@Contractor", Contractor);
                cmd.Parameters.AddWithValue("@Commencement_Date", StartDate);
                cmd.Parameters.AddWithValue("@Proposal_Deadline", FinishDate);
                cmd.Parameters.AddWithValue("@District_ID", District_ID);
                cmd.Parameters.AddWithValue("@Capicity", Capicity);
                
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
        public DataTable SelectFromProject()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectFromProject";
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
        public DataTable getAllCategory()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectAllFromCategory";
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public DataTable getAllNature()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectAllfromNature";
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public DataTable getAllDistrict()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectAllFromDistrict";
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public DataTable getProject_IDandName()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_getProject_IDandName";
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }

        public DataTable GetStartAndFinishDateByProject(int pid)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetStartAndFinishDateByProject";
            cmd.Parameters.AddWithValue("@Project_ID", pid);
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }
    }
}