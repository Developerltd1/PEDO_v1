using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.UserEntryForms
{
    public partial class UserLogin : System.Web.UI.Page
    {
          
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            
            Session["UserName"] = tbUserName.Text;
            Session["Password"] =  tbPassword.Text;
            if (tbUserName.Text == null || tbPassword.Text == null)
            {
                tbUserName.Text = "Please Fill";
                tbPassword.Text = "Please Fill";
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }
               
              //Response.Redirect("~/UserEntryForms/UserLogin.aspx");
        }
        

    }
