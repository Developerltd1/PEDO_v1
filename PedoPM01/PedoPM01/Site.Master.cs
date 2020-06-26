using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01
{
    public partial class SiteMaster : MasterPage
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedoDB"].ConnectionString);
       
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            MngUser obj = new MngUser();
            String n = Session["UserName"].ToString();//"zahid";//  
            String p = Session["Password"].ToString();//"123";//    
            int checkrole = obj.CompareUsernameandPassowrdSingleRole(n, p);
            int UserID = obj.GetUserID(n, p);
            Session["UserID"] = UserID;
            lblUserName.Text = Session["UserName"].ToString();//"zahid";//

            Block_User.Visible = false;
            Block_Dashbboard.Visible = true;
            Block_Project.Visible = false;
            Block_Hydro.Visible = false;
            Sub_HydroMainTask.Visible = false;
            Sub_Hydrosubtask.Visible = false;
            Sub_NewDefinetask.Visible = false;
            Block_Solar.Visible = false;
            Sub_SolarMainsubtask.Visible = false;
            Sub_Solarsubtask.Visible = false;
            Update_Sub_Hydrosubtask.Visible=false;
            //Block_Edit.Visible = false;
            Block_Report.Visible = false;
            Block_GMapproval.Visible = false;
            Update_HydroWorkPlan.Visible = false;
            Block_Finance.Visible = false;
            Block_AssociatedTask.Visible = false;

            switch (checkrole)
            {
                case 0:
                    Response.Redirect("~/UserEntryForms/UserLogin.aspx");
                    break;
                //General Manager
                case 1:
                    
                    Block_GMapproval.Visible = true;
                    Block_Report.Visible = true;
                    break;
                //Admin IT
                case 2:
                    Block_User.Visible = true;
                    Block_Dashbboard.Visible = true;
                    Block_Project.Visible = true;
                    Block_Hydro.Visible = true;
                    Sub_HydroMainTask.Visible = true;
                    Update_HydroWorkPlan.Visible = true;
                    Sub_Hydrosubtask.Visible = true;
                    Sub_NewDefinetask.Visible = true;
                    Block_Solar.Visible = true;
                    Sub_SolarMainsubtask.Visible = true;
                    Sub_Solarsubtask.Visible = true;
                   // Block_Edit.Visible = true;
                    Block_Report.Visible = true;
                    break;
                //Hydro Full
                case 3:
                    Block_Dashbboard.Visible = true;
                    Block_Hydro.Visible = true;
                    Sub_HydroMainTask.Visible = true;
                    Sub_NewDefinetask.Visible = true;
                    Update_HydroWorkPlan.Visible = true;
                    Block_Finance.Visible = true;
                    Block_AssociatedTask.Visible = true;
                    // Block_Edit.Visible = false;
                    break;
                //Solar Full
                case 4:
                    Block_Dashbboard.Visible = true;
                    Block_Solar.Visible = true;
                    Sub_Solarsubtask.Visible = true;
                    // Block_Edit.Visible = false;
                    break;
                //Hydro Task only
                case 5:
                    Block_Dashbboard.Visible = true;
                    Block_Hydro.Visible = true;
                    Sub_Hydrosubtask.Visible = true;
                    Update_Sub_Hydrosubtask.Visible = true;
                    // Block_Edit.Visible = false;
                    break;
                //Solar Task only
                case 6:
                    Block_Dashbboard.Visible = true;
                    Block_Solar.Visible = true;
                    Sub_Solarsubtask.Visible = true;
                   // Block_Edit.Visible = false;
                    break;
                //default:
                //    Response.Redirect("~/UserEntryForms/UserLogin.aspx");
                //    break;

            }
        }
    }
}