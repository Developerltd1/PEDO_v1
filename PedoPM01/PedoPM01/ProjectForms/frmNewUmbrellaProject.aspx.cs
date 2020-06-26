using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.ProjectForms
{
    public partial class frmNewUmbrellaProject : System.Web.UI.Page
    {
        ManageProject mngProject = new ManageProject();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ManageProject project = new ManageProject();

                /*  For Department COMBO  */
                cbCategory.DataSource = project.getAllCategory();
                cbCategory.DataValueField = "CategoryID";
                cbCategory.DataTextField = "CategoryName";
                cbCategory.DataBind();


                cbDistrict.DataSource = project.getAllDistrict();
                cbDistrict.DataValueField = "DistrictID";
                cbDistrict.DataTextField = "District";
                cbDistrict.DataBind();
            }
            tb_Entry_Date.Text = DateTime.Now.ToString("dd-MMM-yyyy").ToString();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
           
            mngProject.Title = tbTitle.Text;
            mngProject.Category_ID = Convert.ToInt32(cbCategory.SelectedValue);
            mngProject.Nature_ID = 2; // it will show project is Individual / umbrella
            mngProject.IsChild = true; // basically it will show project is parent or child 
            mngProject.ParentProject_ID = 0;
            mngProject.StartDate = Convert.ToDateTime(tb_CommencementDate.Text);
            mngProject.FinishDate = Convert.ToDateTime(tb_ProposalDeadline.Text);
            mngProject.EntryDate = Convert.ToDateTime(tb_Entry_Date.Text);
            mngProject.District_ID = Convert.ToInt32(cbDistrict.SelectedValue);
            mngProject.Latitude = 0;
            mngProject.Longitude = 0;
            mngProject.User_ID = Convert.ToInt32(tbName.Text);
            mngProject.InsertProject();
            Response.Write("<script language=javascript>alert('Record added successfully')</script>");

            tbTitle.Text = "";
            tb_CommencementDate.Text = "";
            tb_ProposalDeadline.Text = "";
            tb_Entry_Date.Text = "";
            tbLatitute.Text = "";
            tbLongitude.Text = "";
            
        }
    }
}