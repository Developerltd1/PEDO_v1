using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.DefineTaskForms
{
    public partial class frmNewSolarMainTask : System.Web.UI.Page
    {
        ManageMainTask defineTask = new ManageMainTask();
        ManageProject project = new ManageProject();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlType.DataSource = defineTask.getAllTaskType();
            ddlType.DataValueField = "TaskTypeID";
            ddlType.DataTextField = "TaskType";
            ddlType.DataBind();

            ddlProject.DataSource = defineTask.getAllProjectsByCategory(2);
            ddlProject.DataValueField = "ProjectID";
            ddlProject.DataTextField = "Title";
            ddlProject.DataBind();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            defineTask.TaskName = tbTaskName.Text;
            defineTask.TaskType_ID = Convert.ToInt32(ddlType.SelectedValue);
            defineTask.Project_ID = Convert.ToInt32(ddlProject.SelectedValue);
            defineTask.Category_ID = 2;
            defineTask.StartDate = Convert.ToDateTime(tbStartDate.Text);
            defineTask.DeadlineDate = Convert.ToDateTime(tbDeadlineDate.Text);
            defineTask.Remarks = tbRemarks.Text;
            defineTask.Entry_date = DateTime.Now.Date;
            defineTask.Users_id = 5;
            defineTask.InsertMainTask();


            Response.Write("<script language=javascript>alert('Record added successfully')</script>");
            tbTaskName.Text = "";
            tbStartDate.Text = "";
            tbDeadlineDate.Text = "";
            tbRemarks.Text = "";
            
        }
    }
}