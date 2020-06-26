using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.Finance
{
    public partial class frmProjectCost : System.Web.UI.Page
    {
        ManageMainTask defineTask = new ManageMainTask();
        ManageFinance fin = new ManageFinance();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProject.DataSource = defineTask.getAllProjectsByUser(Session["UserName"].ToString());
                ddlProject.Items.Clear();
                ddlProject.DataValueField = "ProjectID";
                ddlProject.DataTextField = "Title";
                ddlProject.DataBind();

                ddlFinType.DataSource = fin.getAllFinType();
                ddlFinType.Items.Clear();
                ddlFinType.DataValueField = "FinType";
                ddlFinType.DataTextField = "FintypeName";
                ddlFinType.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ManageFinance fin = new ManageFinance();
            
            fin.Project_ID = Convert.ToInt32(ddlProject.SelectedValue);
            fin.Fintype_ID = Convert.ToInt32(ddlFinType.SelectedValue);
            fin.Cost = Convert.ToDouble(tbCost.Text);
            fin.Remarks = tbRemarks.Text;
            fin.User_ID = Convert.ToInt32(Session["UserID"]);

            fin.InsertProjectFinance();
            Response.Write("<script language=javascript>alert('Record added successfully')</script>");
            tbCost.Text = "";
            tbRemarks.Text = "";
        }
    }
}