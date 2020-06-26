using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.Finance
{
    public partial class frmProjectPayment : System.Web.UI.Page
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

                
            }
        }

        protected void ddlProject_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                ddlFinType.DataSource = fin.getFinTypeByProject(Convert.ToInt32(ddlProject.SelectedValue));
                ddlFinType.Items.Clear();
                ddlFinType.DataValueField = "FinType";
                ddlFinType.DataTextField = "FintypeName";
                ddlFinType.DataBind();

                
          }

        int projectfinid;
        protected void ddlFinType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbProjectCost.Text = fin.getCostByFinType(Convert.ToInt32(ddlFinType.SelectedValue), Convert.ToInt32(ddlProject.SelectedValue),out projectfinid).ToString();
            tbProjectFinID.Text = projectfinid.ToString();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            fin.ProjectFin_ID = Convert.ToInt32(tbProjectFinID.Text);
            fin.PaidAmount = Convert.ToDouble(tbPaidAmount.Text);
            fin.PaymentDate = Convert.ToDateTime(DateTime.ParseExact(tbPaymentDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            fin.PaymentMode = tbPaymentMode.Text;
            fin.Particulars = tbParticulars.Text;
            fin.EnterByUser_No = Convert.ToInt32(Session["UserID"]);

            fin.InsertProjectPayment();
            Response.Write("<script language=javascript>alert('Record added successfully')</script>");
            tbPaidAmount.Text = "";
            tbPaymentDate.Text = "";
            tbPaymentMode.Text = "";
            tbParticulars.Text = "";
            tbProjectCost.Text = "";

        }
    }
}