using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.ProjectForms
{
    public partial class frmEditProject : System.Web.UI.Page
    {
        ManageProject pro = new ManageProject();
        public string selectedDistrict;
        protected void Page_Load(object sender, EventArgs e)
        {
            pro = new ManageProject();
            if(!IsPostBack)
            {
                
                GridView1.DataSource = pro.SelectFromProject();
                GridView1.DataBind();
            }

        }



        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
                if (e.Row.RowType == DataControlRowType.DataRow && GridView1.EditIndex == e.Row.RowIndex)
                {
                    DropDownList ddlDistrict = (DropDownList)e.Row.FindControl("cbDistrict");
                    ddlDistrict.DataSource = pro.getAllDistrict();
                    ddlDistrict.DataTextField = "District";
                    ddlDistrict.DataValueField = "DistrictID";
                    ddlDistrict.DataBind();
                    
                    ViewState["district"] = ddlDistrict.SelectedValue;
               
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = pro.SelectFromProject();
            this.GridView1.DataBind();

        }


        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = pro.SelectFromProject();
            GridView1.DataBind();
            e.Cancel = true;


        }

       
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];


            TextBox tbTitle = (TextBox)row.FindControl("tbTitle");
            TextBox tbConsultant = (TextBox)row.FindControl("tbConsultant");
            TextBox tbContractor = (TextBox)row.FindControl("tbContractor");
            TextBox tbStartDate = (TextBox)row.FindControl("tbStartDate");
            TextBox tbFinishDate = (TextBox)row.FindControl("tbFinishDate");
            TextBox tbCapicity = (TextBox)row.FindControl("tbCapicity");

            
            pro.ProjectID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            pro.Title = tbTitle.Text;
            pro.Consultant = tbConsultant.Text;
            pro.Contractor = tbContractor.Text;
            pro.Capicity = tbCapicity.Text;
            pro.District_ID = Convert.ToInt32(ViewState["district"]); //Convert.ToInt32(selectedDistrict);
            pro.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            pro.FinishDate = Convert.ToDateTime(DateTime.ParseExact(tbFinishDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));

            pro.UpdateProject();
            Response.Write("<script language=javascript>alert('Record Edited successfully')</script>");
            GridView1.DataSource = pro.SelectFromProject();
            GridView1.DataBind();
            
    
          
            

        }
        

    }
}