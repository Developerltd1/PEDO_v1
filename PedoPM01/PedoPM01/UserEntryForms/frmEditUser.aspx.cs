using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.UserEntryForms
{
    public partial class frmEditUser : System.Web.UI.Page
    {
        MngUser user = new MngUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewUser.DataSource = user.GetUsers();
            GridViewUser.DataBind();
        }
    }
}