using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.DefineTaskForms
{
    public partial class frmAssociatedTask : System.Web.UI.Page
    {
        ManageMainTask task = new ManageMainTask();
        ManageAssociatedTask associatedTask = new ManageAssociatedTask();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ddlProject.DataSource = task.getAllProjectsByUser(Session["UserName"].ToString());
                ddlProject.DataValueField = "ProjectID";
                ddlProject.DataTextField = "Title";
                ddlProject.DataBind();

                GridViewAssociatedTask.DataSource = associatedTask.SelectAllAssociatedTask();
                GridViewAssociatedTask.DataBind();
            }
        }

    }
}