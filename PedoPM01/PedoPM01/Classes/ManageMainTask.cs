using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace PedoPM01.Classes
{
    public class ManageMainTask
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public int TaskType_ID { get; set; }
        public int Project_ID { get; set; }
        public int Category_ID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public DateTime? DesignDate { get; set; }
        public DateTime? DesignFinishDate { get; set; }
        public DateTime? ConstructDate { get; set; }
        public DateTime? ConstructFinishDate { get; set; }
        public DateTime? OrderingDate { get; set; }
        public DateTime? OrderingFinishDate { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? ShipmentFinishDate { get; set; }
        public DateTime? InstallationDate { get; set; }
        public DateTime? InstallationFinishDate { get; set; }
        public string Remarks { get; set; }
        public DateTime Entry_date { get; set; }
        public int Users_id { get; set; }
        public bool IsEnable { get; set; }
        public DateTime Disable_date { get; set; }
        public bool IsApprovedByGM { get; set; }
        public int defineTaskID { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedoDB"].ConnectionString);
        public int InsertMainTask()
        {
            bool prblmflag = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertMainTask";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@TaskName", TaskName);
                cmd.Parameters.AddWithValue("@TaskType_ID ", TaskType_ID);
                cmd.Parameters.AddWithValue("@Project_ID", Project_ID);
                cmd.Parameters.AddWithValue("@Category_ID", Category_ID);
                if (StartDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@StartDate", StartDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StartDate", null);
                }
                if (DeadlineDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@DeadlineDate", DeadlineDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DeadlineDate", null);
                }
                if (DesignDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@DesignDate", DesignDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DesignDate", null);
                }
                if (DesignFinishDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@DesignFinishDate", DesignFinishDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DesignFinishDate", null);
                }
                if (ConstructDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ConstructDate", ConstructDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ConstructDate", null);
                }
                if (ConstructFinishDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ConstructFinishDate", ConstructFinishDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ConstructFinishDate", null);
                }
                if (OrderingDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@OrderingDate", OrderingDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OrderingDate", null);
                }
                if (OrderingFinishDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@OrderingFinishDate", OrderingFinishDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OrderingFinishDate", null);
                }
                if (ShipmentDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ShipmentDate", ShipmentDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ShipmentDate", null);
                }
                if (ShipmentFinishDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ShipmentFinishDate", ShipmentFinishDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ShipmentFinishDate", null);
                }
                if (InstallationDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@InstallationDate", InstallationDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@InstallationDate", null);

                }
                if (InstallationFinishDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@InstallationFinishDate", InstallationFinishDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@InstallationFinishDate", null);

                }

                cmd.Parameters.AddWithValue("Remarks", Remarks);
                cmd.Parameters.AddWithValue("User_No", Users_id);

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

        public int UpdateMainTask()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_UpdateMainTask";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@DefineTaskID", defineTaskID);
                if (StartDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@StartDate", StartDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StartDate", null);
                }
                if (DeadlineDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@DeadlineDate", DeadlineDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DeadlineDate", null);
                }
                if (DesignDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@DesignDate", DesignDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DesignDate", null);
                }
                if (DesignFinishDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@DesignFinishDate", DesignFinishDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DesignFinishDate", null);
                }
                if (ConstructDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ConstructDate", ConstructDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ConstructDate", null);
                }
                if (ConstructFinishDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ConstructFinishDate", ConstructFinishDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ConstructFinishDate", null);
                }
                if (OrderingDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@OrderingDate", OrderingDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OrderingDate", null);
                }
                if (OrderingFinishDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@OrderingFinishDate", OrderingFinishDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OrderingFinishDate", null);
                }
                if (ShipmentDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ShipmentDate", ShipmentDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ShipmentDate", null);
                }
                if (ShipmentFinishDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ShipmentFinishDate", ShipmentFinishDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ShipmentFinishDate", null);
                }
                if (InstallationDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@InstallationDate", InstallationDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@InstallationDate", null);

                }
                if (InstallationFinishDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@InstallationFinishDate", InstallationFinishDate.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@InstallationFinishDate", null);

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

        //public int InsertMainTaskinBulk(List<ManageMainTask> list) 
        //{
        //    bool prblmflag = false;
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "usp_InsertMainTask";
        //        con.Open();
        //        cmd.Connection = con;
        //        foreach(ManageMainTask obj in list)
        //        {                    
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.AddWithValue("@TaskName", obj.TaskName);
        //            cmd.Parameters.AddWithValue("@TaskType_ID ", obj.TaskType_ID);
        //            cmd.Parameters.AddWithValue("@Project_ID", obj.Project_ID);
        //            cmd.Parameters.AddWithValue("@Category_ID", obj.Category_ID);
        //            if (obj.StartDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@StartDate", obj.StartDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@StartDate",null);
        //            }
        //            if (obj.DeadlineDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@DeadlineDate", obj.DeadlineDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@DeadlineDate", null);
        //            }
        //            if (obj.DesignDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@DesignDate", obj.DesignDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@DesignDate", null);
        //            }
        //            if (obj.DesignFinishDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@DesignFinishDate", obj.DesignFinishDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@DesignFinishDate", null);
        //            }
        //            if (obj.ConstructDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@ConstructDate", obj.ConstructDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@ConstructDate", null);
        //            }
        //            if (obj.ConstructFinishDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@ConstructFinishDate", obj.ConstructFinishDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@ConstructFinishDate", null);
        //            }
        //            if (obj.OrderingDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@OrderingDate", obj.OrderingDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@OrderingDate", null);
        //            }
        //            if (obj.OrderingFinishDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@OrderingFinishDate", obj.OrderingFinishDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@OrderingFinishDate", null);
        //            }
        //            if (obj.ShipmentDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@ShipmentDate", obj.ShipmentDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@ShipmentDate", null);
        //            }
        //            if (obj.ShipmentFinishDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@ShipmentFinishDate", obj.ShipmentFinishDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@ShipmentFinishDate", null);
        //            }
        //            if (obj.InstallationDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@InstallationDate", obj.InstallationDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@InstallationDate", null);

        //            }
        //            if (obj.InstallationFinishDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@InstallationFinishDate", obj.InstallationFinishDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@InstallationFinishDate", null);

        //            }
        //            cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
        //            cmd.Parameters.AddWithValue("@Entry_Date", obj.Entry_date);
        //            cmd.Parameters.AddWithValue("@User_No", obj.Users_id);

        //            SqlParameter oparam = new SqlParameter("@error", SqlDbType.Int);
        //            oparam.Direction = ParameterDirection.Output;
        //            cmd.Parameters.Add(oparam);


        //            int RowsAffected = (int)cmd.ExecuteNonQuery();
        //            if (RowsAffected == 0 || (int)oparam.Value == -1) // -1 means record already exists
        //            {
        //                prblmflag = true;
        //                break;
        //            }

        //      }

        //        if (!prblmflag)
        //            return 1;  // there is no problem
        //        else 
        //            return 0;  // there is problem


        //    }
        //    catch (Exception ex)
        //    {
        //            throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //        prblmflag = false;
        //    }
        //}
        //public int UpdateMainTaskinBulk(List<ManageMainTask> list)
        //{
        //    bool prblmflag = false;
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "usp_UpdateMainTask";
        //        con.Open();
        //        cmd.Connection = con;
        //        foreach (ManageMainTask obj in list)
        //        {
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.AddWithValue("@DefineTaskID", obj.defineTaskID);
        //            cmd.Parameters.AddWithValue("@TaskName", obj.TaskName);
        //            cmd.Parameters.AddWithValue("@TaskType_ID ", obj.TaskType_ID);
        //            cmd.Parameters.AddWithValue("@Project_ID", obj.Project_ID);
        //            cmd.Parameters.AddWithValue("@Category_ID", obj.Category_ID);
        //            if (obj.StartDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@StartDate", obj.StartDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@StartDate", null);
        //            }
        //            if (obj.DeadlineDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@DeadlineDate", obj.DeadlineDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@DeadlineDate", null);
        //            }
        //            if (obj.DesignDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@DesignDate", obj.DesignDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@DesignDate", null);
        //            }
        //            if (obj.DesignFinishDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@DesignFinishDate", obj.DesignFinishDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@DesignFinishDate", null);
        //            }
        //            if (obj.ConstructDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@ConstructDate", obj.ConstructDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@ConstructDate", null);
        //            }
        //            if (obj.ConstructFinishDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@ConstructFinishDate", obj.ConstructFinishDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@ConstructFinishDate", null);
        //            }
        //            if (obj.OrderingDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@OrderingDate", obj.OrderingDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@OrderingDate", null);
        //            }
        //            if (obj.OrderingFinishDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@OrderingFinishDate", obj.OrderingFinishDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@OrderingFinishDate", null);
        //            }
        //            if (obj.ShipmentDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@ShipmentDate", obj.ShipmentDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@ShipmentDate", null);
        //            }
        //            if (obj.ShipmentFinishDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@ShipmentFinishDate", obj.ShipmentFinishDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@ShipmentFinishDate", null);
        //            }
        //            if (obj.InstallationDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@InstallationDate", obj.InstallationDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@InstallationDate", null);

        //            }
        //            if (obj.InstallationFinishDate.HasValue)
        //            {
        //                cmd.Parameters.AddWithValue("@InstallationFinishDate", obj.InstallationFinishDate.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@InstallationFinishDate", null);

        //            }
        //            cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);


        //            int RowsAffected = (int)cmd.ExecuteNonQuery();
        //            if (RowsAffected == 0 )
        //            {
        //                prblmflag = true;
        //                break;
        //            }

        //        }

        //        if (!prblmflag)
        //            return 1;  // there is no problem
        //        else
        //            return 0;  // there is problem


        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //        prblmflag = false;
        //    }
        //}

        public DataTable getAllTaskType()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectAllFromTaskType";
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public DataTable getAllProjects()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectAllFromProject";
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public DataTable getAllProjectsByCategory(int Category_ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getProjectbyCategory";
            cmd.Parameters.AddWithValue("@Category_ID", Category_ID);
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public int insertDefinedTask(string task)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertDefinedTask";
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@TaskName", task);
                int i = cmd.ExecuteNonQuery();

                return i;


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

        public DataTable getAllDefineTask()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_selectAllFromSettings";
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
        public DataTable GetMainTaskByProject(int project_id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetMainTaskByProject";
            cmd.Parameters.AddWithValue("@Project_ID", project_id);
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
        public DataTable getDefineTasktbyProject(int project_id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getDefineTasktbyProject";
            cmd.Parameters.AddWithValue("@Project_ID", project_id);
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public DataTable getDefineTasktbyProjectForHydroGrid(int project_id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getDefineTasktbyProjectForHydroGrid";
            cmd.Parameters.AddWithValue("@Project_ID", project_id);
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
        public int SetTaskApprovedByGM(List<ManageMainTask> list)
        {

            bool prblmflag = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_SetTaskApprovedByGM";

                con.Open();
                cmd.Connection = con;
                foreach (ManageMainTask obj in list)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@TaskID", obj.TaskID);
                    cmd.Parameters.AddWithValue("@IsApprovedByGM", obj.IsApprovedByGM);

                    int RowsAffected = (int)cmd.ExecuteNonQuery();
                    if (RowsAffected == 0)
                    {
                        prblmflag = true;
                        break;
                    }

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
        public DataTable getAllProjectsByUser(string UserName)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetProjecyByUser";
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }

        public DataTable SelectAllMainTask()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SelectFromDefineTask";
            cmd.Connection = con;



            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }
        public DataTable GetStartAndFinishDateByMainTask(int mid)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetStartAndFinishDateByMainTask";
            cmd.Parameters.AddWithValue("@MainTask", mid);
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }

    }
}