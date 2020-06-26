using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PedoPM01.Classes
{
    public class MngUser
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedoDB"].ConnectionString);
        public String UserName { get; set; }
        public String Password { get; set; }
        public int RoleID { get; set; }
        public int ProjectID { get; set; }

        public int InsertUser()
        {
            bool prblmflag = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertUser";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password ", Password);
                cmd.Parameters.AddWithValue("@RoleID", RoleID);
                cmd.Parameters.AddWithValue("@ProjectID", ProjectID);

                SqlParameter oparam = new SqlParameter("@error", SqlDbType.Int);
                oparam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(oparam);

                int RowsAffected = (int)cmd.ExecuteNonQuery();
                if (RowsAffected == 0 || (int)oparam.Value == -1) // -1 means record already exists
                {
                    prblmflag = true;

                }


                if (!prblmflag)
                    return 1;  // there is no problem
                else
                    return 0;  // there is problem


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                prblmflag = false;
            }
        }


        public int InsertPDUser(string uname, string pwd)
        {
            bool prblmflag = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertPDUser";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password ", Password);
                SqlParameter oparam = new SqlParameter("@error", SqlDbType.Int);
                oparam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(oparam);

                int RowsAffected = (int)cmd.ExecuteNonQuery();
                if (RowsAffected == 0 || (int)oparam.Value == -1) // -1 means record already exists
                {
                    prblmflag = true;

                }


                if (!prblmflag)
                    return 1;  // there is no problem
                else
                    return 0;  // there is problem


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                prblmflag = false;
            }
        }

        public int InsertPDProjects(int uid, int roleid, List<int> pids)
        {

            try
            {
                foreach(int pid in pids)
                {
                 SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertProjectsforPD";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@UserId", uid);                
                cmd.Parameters.AddWithValue("@RoleID",roleid);
                cmd.Parameters.AddWithValue("@ProjectID",pid);

                int RowsAffected = (int)cmd.ExecuteNonQuery();

                }

                return 1;

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

        public DataTable CompareUsernameandPassowrd(string uname, string pwd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "";
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }


        public int CompareUsernameandPassowrdSingleRole(string uname, string pwd)
        {
         try{
            int role = 0;
        
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_CheckUserPwdandRole";
            cmd.Parameters.AddWithValue("@Username", uname);
            cmd.Parameters.AddWithValue("@Password", pwd);

            SqlParameter rolepm= new SqlParameter();
            rolepm.Direction = ParameterDirection.Output;
            rolepm.DbType =DbType.Int32;
            rolepm.ParameterName = "Roleid";
          
            cmd.Parameters.Add(rolepm);

            cmd.ExecuteNonQuery();

            role = Convert.ToInt32(rolepm.Value.ToString());

            return role;
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

        public int GetUserID(string uname, string pwd)
        {
            try
            {
                int user = 0;


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_getUserID";
                cmd.Parameters.AddWithValue("@Username", uname);
                cmd.Parameters.AddWithValue("@Password", pwd);

                

                SqlParameter rolepm2 = new SqlParameter();
                rolepm2.Direction = ParameterDirection.Output;
                rolepm2.DbType = DbType.Int32;
                rolepm2.ParameterName = "UserID";
                cmd.Parameters.Add(rolepm2);

                cmd.ExecuteNonQuery();

                user = Convert.ToInt32(rolepm2.Value.ToString());

                return user;
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
        public DataTable getAllRolesofType(int t)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetExecutiveRolesfroDropdown";
            cmd.Parameters.AddWithValue("@tp",t);
            cmd.Connection = con;

            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable TopManagementGrid(int t)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_TopManagementGridView";
            cmd.Parameters.AddWithValue("@tp", t);
            cmd.Connection = con;

            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable GetUsers()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetUsers";
            cmd.Connection = con;

            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


    }
}