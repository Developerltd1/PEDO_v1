using PedoPM01.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.DefineTaskForms
{
    public partial class frmGMapprovement : System.Web.UI.Page
    {
        ManageMainTask defineTask = new ManageMainTask();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ddlProject.DataSource = defineTask.getAllProjectsByCategory(1);
                ddlProject.Items.Clear();
                ddlProject.DataValueField = "ProjectID";
                ddlProject.DataTextField = "Title";
                ddlProject.DataBind();
            }
        }

        protected void ddlProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.DataSource = null;
            GridView1.DataSource = defineTask.GetMainTaskByProject(Convert.ToInt32(ddlProject.SelectedValue));
            GridView1.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            List<ManageMainTask> sc = new List<ManageMainTask>();
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                ManageMainTask task = new ManageMainTask();
                task.TaskID = Convert.ToInt32(((Label)GridView1.Rows[i].Cells[0].FindControl("lbTaskID")).Text);
                task.IsApprovedByGM = Convert.ToBoolean(((CheckBox)GridView1.Rows[i].Cells[6].FindControl("cbApproved")).Checked);
                sc.Add(task);
            }
            defineTask.SetTaskApprovedByGM(sc);
            Response.Write("<script language=javascript>alert('Record added successfully')</script>");
            GridView1.DataSource = defineTask.GetMainTaskByProject(Convert.ToInt32(ddlProject.SelectedValue));
            GridView1.DataBind();
        }

    }
}