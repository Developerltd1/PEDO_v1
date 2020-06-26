using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.UserEntryForms
{
    public partial class frmTopManagement : System.Web.UI.Page
    {
        MngUser user = new MngUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            cbRoles.DataSource = user.getAllRolesofType(1); // O means non-executive 
            cbRoles.DataValueField = "RoleID";
            cbRoles.DataTextField = "RoleName";
            cbRoles.DataBind();

            GridView1.DataSource = user.TopManagementGrid(1);
            GridView1.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            user.UserName = tbUserName.Text;
            user.Password = tbPassword.Text;
            user.RoleID = Convert.ToInt32(cbRoles.SelectedValue);
            user.ProjectID = 0;
            if (user.InsertUser() == 0)
            {
                Response.Write("<script language=javascript>alert('User already exists!')</script>");

            }
            else
                Response.Write("<script language=javascript>alert('Record added successfully')</script>");

            tbUserName.Text = "";
            tbPassword.Text = "";
        }
    }
}