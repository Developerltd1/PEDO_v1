using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.DefineTaskForms
{
    public partial class frmAddDefinedTaks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ManageMainTask defineTask = new ManageMainTask();
          //  defineTask.TaskName = tbTaskName.Text;
            defineTask.insertDefinedTask(tbTaskName.Text);
            Response.Write("<script language=javascript>alert('Record added successfully')</script>");
            tbTaskName.Text = "";
          
        }
    }
}