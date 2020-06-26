using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PedoPM01.Classes
{
    public class MngCharts
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedoDB"].ConnectionString);


        public DataTable displayCHART_ProjectCOUNT(int byProjectID)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter();
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_displayChart_Project_COUNT";
                cmd.Parameters.AddWithValue("@ProjectID", byProjectID);

                sda.SelectCommand = cmd;
                sda.Fill(dt);
                return dt;
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
        public DataTable displayCHART_HydroProjectProgress_byProjectID(int byProjectID)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter();
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_displayChart_HydroProjectProgress_byProjectID";
                cmd.Parameters.AddWithValue("@ProjectID", byProjectID);

                sda.SelectCommand = cmd;
                sda.Fill(dt);
                return dt;
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
        public DataTable displayCHART_HydroProjectProgress_byProjectID_SDATEtoEDATE(int byProjectID)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter();
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_displayChart_HydroProjectProgress_byProjectID_SDATEtoEDATE";
                cmd.Parameters.AddWithValue("@ProjectID", byProjectID);

                sda.SelectCommand = cmd;
                sda.Fill(dt);
                return dt;
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
        public DataTable displayCHART_allHydroProjects()
        {
            try
            {
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter();
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_displayChart_AllHydroProjects";

                sda.SelectCommand = cmd;
                sda.Fill(dt);
                return dt;
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