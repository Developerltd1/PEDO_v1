using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.SubTaskForms
{
    public partial class frmEditSubTask : System.Web.UI.Page
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


        protected void ddlProject_SelectedIndexChanged1(object sender, EventArgs e)
        {
            ddlDefineTask.DataSource = mngSubTask.getDefineTaskbyProject(Convert.ToInt32(ddlProject.SelectedValue));
            ddlDefineTask.Items.Clear();
            ddlDefineTask.DataValueField = "DefineTaskID";
            ddlDefineTask.DataTextField = "TaskName";
            ddlDefineTask.DataBind();
        }

        protected void ddlDefineTask_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewSubTask.DataSource = mngSubTask.GetSubTaskByMainTask(Convert.ToInt32(ddlDefineTask.SelectedValue));
            GridViewSubTask.DataBind();
        }

        protected void GridViewSubTask_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewSubTask.EditIndex = -1;
            GridViewSubTask.DataSource = mngSubTask.GetSubTaskByMainTask(Convert.ToInt32(ddlDefineTask.SelectedValue));
            GridViewSubTask.DataBind();
            e.Cancel = true;
        }

        protected void GridViewSubTask_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewSubTask.EditIndex = e.NewEditIndex;
            GridViewSubTask.DataSource = mngSubTask.GetSubTaskByMainTask(Convert.ToInt32(ddlDefineTask.SelectedValue));
            GridViewSubTask.DataBind();
        }

        protected void GridViewSubTask_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridViewSubTask.Rows[e.RowIndex];

            TextBox tbTaskProgress = (TextBox)row.FindControl("tbTaskProgress");
            TextBox tbPercentage = (TextBox)row.FindControl("tbPercentage");
            TextBox tbRemarks = (TextBox)row.FindControl("tbRemarks");

            mngSubTask.SubTaskID = Convert.ToInt32(GridViewSubTask.DataKeys[e.RowIndex].Value.ToString());
            mngSubTask.SubTaskName = tbTaskProgress.Text;
            mngSubTask.Percantage = Convert.ToDouble(tbPercentage.Text);
            mngSubTask.Remarks = tbRemarks.Text;

            mngSubTask.UpdateSubTask();
            Response.Write("<script language=javascript>alert('Record Edited successfully')</script>");
            GridViewSubTask.DataSource = mngSubTask.GetSubTaskByMainTask(Convert.ToInt32(ddlDefineTask.SelectedValue));
            GridViewSubTask.DataBind();
        }


    }
}