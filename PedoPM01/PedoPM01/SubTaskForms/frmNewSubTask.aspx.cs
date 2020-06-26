using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.SubTaskForms
{
    public partial class frmNewSubTask : System.Web.UI.Page
    {
        ManageSubTask mngSubTask = new ManageSubTask();
        ManageMainTask defineTask = new ManageMainTask();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ddlProject.DataSource = defineTask.getAllProjectsByUser(Session["UserName"].ToString());
                ddlProject.DataValueField = "ProjectID";
                ddlProject.DataTextField = "Title";
                ddlProject.DataBind();


            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            mngSubTask.Project_ID = Convert.ToInt32(ddlProject.SelectedValue);
            mngSubTask.SubTaskName = tbSubTaskName.Text;
            mngSubTask.Task_ID = Convert.ToInt32(ddlDefineTask.SelectedValue);
            mngSubTask.Remarks = tbRemarks.Text;
            mngSubTask.Percantage = Convert.ToDouble(tbPercantage.Text);
            //mngSubTask.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            //mngSubTask.DeadlineDate = Convert.ToDateTime(DateTime.ParseExact(tbDeadline.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            mngSubTask.User_ID = Convert.ToInt32(Session["UserID"]);
            mngSubTask.EntryDate = DateTime.Now.Date;
            mngSubTask.InsertSubTask();
            Response.Write("<script language=javascript>alert('Record added successfully')</script>");
            GridViewSubTask.DataSource = mngSubTask.GetSubTaskByMainTask(Convert.ToInt32(ddlDefineTask.SelectedValue));
            GridViewSubTask.DataBind();

            tbSubTaskName.Text = "";
            tbRemarks.Text = "";
            tbPercantage.Text = "";
            //tbStartDate.Text = "";
            //tbDeadline.Text = "";

        }

        protected void ddlProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlDefineTask.DataSource = mngSubTask.getDefineTaskbyProject(Convert.ToInt32(ddlProject.SelectedValue));
            ddlDefineTask.Items.Clear();
            ddlDefineTask.DataValueField = "DefineTaskID";
            ddlDefineTask.DataTextField = "TaskName";
            ddlDefineTask.DataBind();
        }

        protected void ddlDefineTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //DataTable dt = new DataTable();
            //dt = defineTask.GetStartAndFinishDateByMainTask(Convert.ToInt32(ddlDefineTask.SelectedValue));

            //DataRow dr = dt.Rows[0];

            //tbMainTaskStartDate.Text = dr["StartDate"].ToString();
            //tbMainTaskFinishDate.Text = dr["FinishDate"].ToString();

            GridViewSubTask.DataSource = mngSubTask.GetSubTaskByMainTask(Convert.ToInt32(ddlDefineTask.SelectedValue));
            GridViewSubTask.DataBind();
        }

    
    }
}