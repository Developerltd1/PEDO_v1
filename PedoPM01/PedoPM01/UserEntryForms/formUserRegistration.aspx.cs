using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PedoPM01.Classes;

namespace PedoPM01.UserEntryForms
{
    public partial class formUserRegistration : System.Web.UI.Page
    {
        MngUser user = new MngUser();
        ManageProject project = new ManageProject();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {

                /*  For Project COMBO  */
                listProject.DataSource = project.getProject_IDandName();
                // cbProject.Items.Clear();
                listProject.DataTextField = "Title";
                listProject.DataValueField = "ProjectID";
                listProject.DataBind();
                /*  For Roles COMBO  */
              cbRoles.DataSource = user.getAllRolesofType(0); // O means non-executive 
              cbRoles.DataValueField = "RoleID";
              cbRoles.DataTextField = "RoleName";
              cbRoles.DataBind();

              GridViewUser.DataSource = user.GetUsers();
              GridViewUser.DataBind();
              
            }
         }

       
        protected void btnSave_Click(object sender, EventArgs e)
        {
            foreach (ListItem listItem in listProject.Items) { 
            user.UserName = tbUserName.Text;
            user.Password = tbPassword.Text;
            user.RoleID = Convert.ToInt32(cbRoles.SelectedValue);
            user.ProjectID = Convert.ToInt32(listProject.SelectedValue);
            }

            if (user.InsertUser() == 0)
            {
                Response.Write("<script language=javascript>alert('User already exists!')</script>");

            }
            else
                Response.Write("<script language=javascript>alert('Record added successfully')</script>");
     
            tbUserName.Text = "";
            tbPassword.Text = "";
            //cbRoles.Text = "";
            //cbProject.Text = "";
            GridViewUser.DataSource = user.GetUsers();
            GridViewUser.DataBind();
        }

       
    }
}