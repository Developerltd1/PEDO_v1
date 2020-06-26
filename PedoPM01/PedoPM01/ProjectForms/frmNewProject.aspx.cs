using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.ProjectForms
{
    public partial class frmNewProject : System.Web.UI.Page
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

                ManageDistricts district = new ManageDistricts();
                cbDistrict.DataSource = district.getDistrict();
                cbDistrict.DataValueField = "DistrictID";
                cbDistrict.DataTextField = "District";
                cbDistrict.DataBind();

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
                mngProject.Title = tbTitle.Text;
                //mngProject.PedoPMU = tbPedoPMU.Text;
                mngProject.Consultant = tbConsultant.Text;
                mngProject.Contractor = tbContractor.Text;
                mngProject.Category_ID = Convert.ToInt32(cbCategory.SelectedValue);
                mngProject.Nature_ID = 1; // it will show project is Individual / umbrella
                mngProject.IsChild = false; // basically it will show project is parent or child 
                mngProject.ParentProject_ID = 0;
                mngProject.StartDate = Convert.ToDateTime(DateTime.ParseExact(tb_CommencementDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                mngProject.FinishDate = Convert.ToDateTime(DateTime.ParseExact(tb_ProposalDeadline.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                mngProject.EntryDate = DateTime.Now.Date;
                mngProject.District_ID = Convert.ToInt32(cbDistrict.SelectedValue);
                mngProject.Latitude = 0;
                mngProject.Longitude = 0;
                mngProject.Capicity = tbCapicity.Text;
                mngProject.User_ID = Convert.ToInt32(Session["UserID"]);
                mngProject.InsertProject();


                Response.Write("<script language=javascript>alert('Record added successfully')</script>");

                tbTitle.Text = "";
                tb_CommencementDate.Text = "";
                tb_ProposalDeadline.Text = "";
                //tbPedoPMU.Text = "";
                tbConsultant.Text = "";
                tbContractor.Text = "";
                tbCapicity.Text = "";
               
        }

        protected void tb_CommencementDate_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSavenewDistrtct_Click(object sender, EventArgs e)
        {

            ManageDistricts district = new ManageDistricts();
            district.DistrictsName = tbNewDistrict.Text;
            district.InsertDistrict();
            cbDistrict.DataSource = district.getDistrict();
            cbDistrict.DataValueField = "DistrictID";
            cbDistrict.DataTextField = "District";
            cbDistrict.DataBind();

            tbNewDistrict.Text = "";


        }
    }
}