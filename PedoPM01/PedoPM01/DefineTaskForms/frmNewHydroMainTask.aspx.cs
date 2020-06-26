using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.DefineTaskForms
{
    public partial class frmNewHydroMainTask : System.Web.UI.Page
    {
        ManageMainTask defineTask = new ManageMainTask();
        ManageProject project = new ManageProject();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ddlProject.DataSource = defineTask.getAllProjectsByUser(Session["UserName"].ToString());
                ddlProject.Items.Clear();
                ddlProject.DataValueField = "ProjectID";
                ddlProject.DataTextField = "Title";
                ddlProject.DataBind();

                ddlHydro.DataSource = defineTask.getAllDefineTask();
                ddlHydro.Items.Clear();
                ddlHydro.DataTextField = "TaskName";
                ddlHydro.DataBind();

                divStartDate.Visible = false;
                divFinishDate.Visible = false;
                divDesignDate.Visible = false;
                divDesignFinishDate.Visible = false;
                divConstructDate.Visible = false;
                divConstructFinsihDate.Visible = false;
                //divShipmentDate.Visible = false;
                //divShipmentFinishDate.Visible = false;
                //divOrderDate.Visible = false;
                //divOrderFinishDate.Visible = false;
                divInstallationDate.Visible = false;
                divInstallationFinishDate.Visible = false;
                divRemarks.Visible = false;

                ddlHydro.Items.Insert(0, new ListItem("--Select--", ""));


            }
            
        }

       

        protected void ddlHydro_SelectedIndexChanged(object sender, EventArgs e)
        {
                divStartDate.Visible = false;
                divFinishDate.Visible = false;
                divDesignDate.Visible = false;
                divDesignFinishDate.Visible = false;
                divConstructDate.Visible = false;
                divConstructFinsihDate.Visible = false;
                //divShipmentDate.Visible = false;
                //divShipmentFinishDate.Visible = false;
                //divOrderDate.Visible = false;
                //divOrderFinishDate.Visible = false;
                divInstallationDate.Visible = false;
                divInstallationFinishDate.Visible = false;
                divRemarks.Visible = false;


                switch (ddlHydro.SelectedIndex)
                {
                    case 1:
                        divStartDate.Visible = true;
                        divFinishDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 2:
                        divStartDate.Visible = true;
                        divFinishDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 3:
                        divStartDate.Visible = true;
                        divFinishDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 4:
                        divStartDate.Visible = true;
                        divFinishDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 5:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        divConstructDate.Visible = true;
                        divConstructFinsihDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 6:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        divConstructDate.Visible = true;
                        divConstructFinsihDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 7:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        divConstructDate.Visible = true;
                        divConstructFinsihDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 8:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        divConstructDate.Visible = true;
                        divConstructFinsihDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 9:
                        divStartDate.Visible = true;
                        divFinishDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 10:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        divConstructDate.Visible = true;
                        divConstructFinsihDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 11:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        divConstructDate.Visible = true;
                        divConstructFinsihDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 12:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        divConstructDate.Visible = true;
                        divConstructFinsihDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 13:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        //divShipmentDate.Visible = true;
                        //divShipmentFinishDate.Visible = true;
                        //divOrderDate.Visible = true;
                        //divOrderFinishDate.Visible = true;
                        divInstallationDate.Visible = true;
                        divInstallationFinishDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 14:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        //divShipmentDate.Visible = true;
                        //divShipmentFinishDate.Visible = true;
                        //divOrderDate.Visible = true;
                        //divOrderFinishDate.Visible = true;
                        divInstallationDate.Visible = true;
                        divInstallationFinishDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 15:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        //divShipmentDate.Visible = true;
                        //divShipmentFinishDate.Visible = true;
                        //divOrderDate.Visible = true;
                        //divOrderFinishDate.Visible = true;
                        divInstallationDate.Visible = true;
                        divInstallationFinishDate.Visible = true;
                        divRemarks.Visible = true;
                        break;
                    case 16:
                        divDesignDate.Visible = true;
                        divDesignFinishDate.Visible = true;
                        divConstructDate.Visible = true;
                        divConstructFinsihDate.Visible = true;
                        divRemarks.Visible = true;
                        break;

            }

                CalendarExtender_StartDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_StartDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_DeadlineDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_DeadlineDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_ContructDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_ContructDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_ContructFinsihDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_ContructFinsihDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_DesignDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_DesignDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_DesignFinishDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_DesignFinishDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                //CalendarExtender_OrderDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                //CalendarExtender_OrderDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                //CalendarExtender_OrderFinishDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                //CalendarExtender_OrderFinishDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                //CalendarExtender_ShipmentDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                //CalendarExtender_ShipmentDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                //CalendarExtender_ShipmentFinishDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                //CalendarExtender_ShipmentFinishDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_InstallationDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_InstallationDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_InstallationFinishDate.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                CalendarExtender_InstallationFinishDate.EndDate = Convert.ToDateTime(DateTime.ParseExact(tbProjectEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
        
        
        
        
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            defineTask.Category_ID = 1;
            defineTask.Project_ID = Convert.ToInt32((ddlProject.SelectedValue));
            defineTask.TaskName = ddlHydro.Text;
            defineTask.TaskType_ID = 1;
            if (tbStartDate.Text != string.Empty)
            {
                defineTask.StartDate = Convert.ToDateTime(DateTime.ParseExact(tbStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbDeadline.Text != string.Empty)
            {
                defineTask.DeadlineDate = Convert.ToDateTime(DateTime.ParseExact(tbDeadline.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbConstructDate.Text != string.Empty)
            {
                defineTask.ConstructDate = Convert.ToDateTime(DateTime.ParseExact(tbConstructDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbConstructFinsihDate.Text != string.Empty)
            {
                defineTask.ConstructFinishDate = Convert.ToDateTime(DateTime.ParseExact(tbConstructFinsihDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbDesignDate.Text != string.Empty)
            {
                defineTask.DesignDate = Convert.ToDateTime(DateTime.ParseExact(tbDesignDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbDesignFinishDate.Text != string.Empty)
            {
                defineTask.DesignFinishDate = Convert.ToDateTime(DateTime.ParseExact(tbDesignFinishDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            //if (tbShipmentDate.Text != string.Empty)
            //{
            //    defineTask.ShipmentDate = Convert.ToDateTime(DateTime.ParseExact(tbShipmentDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            //}
            //if (tbShipmentFinishDate.Text != string.Empty)
            //{
            //    defineTask.ShipmentFinishDate = Convert.ToDateTime(DateTime.ParseExact(tbShipmentFinishDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            //}
            //if (tbOrderDate.Text != string.Empty)
            //{
            //    defineTask.OrderingDate = Convert.ToDateTime(DateTime.ParseExact(tbOrderDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            //}
            //if (tbOrderFinishDate.Text != string.Empty)
            //{
            //    defineTask.OrderingFinishDate = Convert.ToDateTime(DateTime.ParseExact(tbOrderFinishDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            //}
            if (tbInstallationDate.Text != string.Empty)
            {
                defineTask.InstallationDate = Convert.ToDateTime(DateTime.ParseExact(tbInstallationDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbInstallationFinishDate.Text != string.Empty)
            {
                defineTask.InstallationFinishDate = Convert.ToDateTime(DateTime.ParseExact(tbInstallationFinishDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            defineTask.Users_id = Convert.ToInt32(Session["UserID"]);
            
            defineTask.Remarks = tbRemarks.Text;
            
            if (defineTask.InsertMainTask() == 0)
            {
                Response.Write("<script language=javascript>alert('Record already exists!')</script>");

            }
            else
                Response.Write("<script language=javascript>alert('Record added successfully')</script>");

            GridView1.DataSource = defineTask.getDefineTasktbyProjectForHydroGrid(Convert.ToInt32(ddlProject.SelectedValue));
            GridView1.DataBind();

            tbStartDate.Text = "";
            tbDeadline.Text = "";
            tbDesignDate.Text = "";
            tbDesignFinishDate.Text = "";
            tbConstructDate.Text = "";
            tbConstructFinsihDate.Text = "";
            //tbShipmentDate.Text = "";
            //tbShipmentFinishDate.Text = "";
            //tbOrderDate.Text = "";
            //tbOrderFinishDate.Text = "";
            tbInstallationDate.Text = "";
            tbInstallationFinishDate.Text = "";
            tbRemarks.Text = "";
        }


        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = defineTask.getDefineTasktbyProjectForHydroGrid(Convert.ToInt32(ddlProject.SelectedValue));
            GridView1.DataBind();
            e.Cancel = true;
            
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];

            TextBox tbTaskName = (TextBox)row.FindControl("tbTaskName");
            TextBox StartDate = (TextBox)row.FindControl("StartDate");
            TextBox tbDeadline = (TextBox)row.FindControl("tbDeadline");
            TextBox tbDesignDate = (TextBox)row.FindControl("tbDesignDate");
            TextBox tbDesignFinishDate = (TextBox)row.FindControl("tbDesignFinishDate");
            TextBox tbConstructDate = (TextBox)row.FindControl("tbConstructDate");
            TextBox tbConstructFinishDate = (TextBox)row.FindControl("tbConstructFinishDate");
            //TextBox tbOrderingDate = (TextBox)row.FindControl("tbOrderingDate");
            //TextBox tbOrderingFinishDate = (TextBox)row.FindControl("tbOrderingFinishDate");
            //TextBox tbShipmentDate = (TextBox)row.FindControl("tbShipmentDate");
            //TextBox tbShipmentFinishDate = (TextBox)row.FindControl("tbShipmentFinishDate");
            TextBox tbInstallationDate = (TextBox)row.FindControl("tbInstallationDate");
            TextBox tbInstallationFinishDate = (TextBox)row.FindControl("tbInstallationFinishDate");
            
                       
            defineTask.defineTaskID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());

            if (StartDate.Text != string.Empty)
            {
                defineTask.StartDate = Convert.ToDateTime(DateTime.ParseExact(StartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbDeadline.Text != string.Empty)
            {
                defineTask.DeadlineDate = Convert.ToDateTime(DateTime.ParseExact(tbDeadline.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbConstructDate.Text != string.Empty)
            {
                defineTask.ConstructDate = Convert.ToDateTime(DateTime.ParseExact(tbConstructDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbConstructFinsihDate.Text != string.Empty)
            {
                defineTask.ConstructFinishDate = Convert.ToDateTime(DateTime.ParseExact(tbConstructFinsihDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbDesignDate.Text != string.Empty)
            {
                defineTask.DesignDate = Convert.ToDateTime(DateTime.ParseExact(tbDesignDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbDesignFinishDate.Text != string.Empty)
            {
                defineTask.DesignFinishDate = Convert.ToDateTime(DateTime.ParseExact(tbDesignFinishDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            //if (tbShipmentDate.Text != string.Empty)
            //{
            //    defineTask.ShipmentDate = Convert.ToDateTime(DateTime.ParseExact(tbShipmentDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            //}
            //if (tbShipmentFinishDate.Text != string.Empty)
            //{
            //    defineTask.ShipmentFinishDate = Convert.ToDateTime(DateTime.ParseExact(tbShipmentFinishDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            //}
            //if (tbOrderDate.Text != string.Empty)
            //{
            //    defineTask.OrderingDate = Convert.ToDateTime(DateTime.ParseExact(tbOrderDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            //}
            //if (tbOrderFinishDate.Text != string.Empty)
            //{
            //    defineTask.OrderingFinishDate = Convert.ToDateTime(DateTime.ParseExact(tbOrderFinishDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            //}
            if (tbInstallationDate.Text != string.Empty)
            {
                defineTask.InstallationDate = Convert.ToDateTime(DateTime.ParseExact(tbInstallationDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }
            if (tbInstallationFinishDate.Text != string.Empty)
            {
                defineTask.InstallationFinishDate = Convert.ToDateTime(DateTime.ParseExact(tbInstallationFinishDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            }

            defineTask.UpdateMainTask();
            Response.Write("<script language=javascript>alert('Record Edited successfully')</script>");
            GridView1.DataSource = defineTask.getDefineTasktbyProjectForHydroGrid(Convert.ToInt32(ddlProject.SelectedValue));
            GridView1.DataBind();
        }

       


        protected void ddlProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageProject mngPro = new ManageProject();
            DataTable dt = new DataTable();
            dt = mngPro.GetStartAndFinishDateByProject(Convert.ToInt32(ddlProject.SelectedValue));

            DataRow dr = dt.Rows[0];

            tbProjectStartDate.Text = dr["StartDate"].ToString();
            tbProjectEndDate.Text = dr["FinishDate"].ToString();
            
            GridView1.DataSource = defineTask.getDefineTasktbyProjectForHydroGrid(Convert.ToInt32(ddlProject.SelectedValue));
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = defineTask.getDefineTasktbyProjectForHydroGrid(Convert.ToInt32(ddlProject.SelectedValue));
          GridView1.DataBind();
        }



    }
}