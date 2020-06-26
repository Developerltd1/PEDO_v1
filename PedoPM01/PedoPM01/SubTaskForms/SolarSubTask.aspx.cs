using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.SubTaskForms
{
    public partial class SolarSubTask : System.Web.UI.Page
    {
        ManageSubTask mngSubTask = new ManageSubTask();
        ManageMainTask defineTask = new ManageMainTask();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProject.DataSource = defineTask.getAllProjectsByCategory(2);
                ddlProject.DataValueField = "ProjectID";
                ddlProject.DataTextField = "Title";
                ddlProject.DataBind();


            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            mngSubTask.SubTaskName = tbSubTaskName.Text;
            mngSubTask.Task_ID = Convert.ToInt32(ddlDefineTask.SelectedValue);
            mngSubTask.Project_ID = Convert.ToInt32(ddlProject.SelectedValue);
            mngSubTask.Remarks = tbRemarks.Text;
            mngSubTask.Percantage = Convert.ToDouble(tbPercantage.Text);
            mngSubTask.User_ID = 5;
            mngSubTask.EntryDate = DateTime.Now.Date;

            mngSubTask.InsertSubTask();

            Response.Write("<script language=javascript>alert('Data Saved Successfully')</script>");
            tbSubTaskName.Text = "";
            tbRemarks.Text = "";
            tbPercantage.Text = "";

        }

        protected void ddlProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlDefineTask.DataSource = mngSubTask.getDefineTaskbyProject(Convert.ToInt32(ddlProject.SelectedValue));
            ddlDefineTask.Items.Clear();
            ddlDefineTask.DataValueField = "DefineTaskID";
            ddlDefineTask.DataTextField = "TaskName";
            ddlDefineTask.DataBind();
        }


    }
}