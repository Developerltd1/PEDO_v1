using Microsoft.Reporting.WebForms;
using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PedoPM01.Reports
{
    public partial class frmMainTaskReport : System.Web.UI.Page
    {
        ManageMainTask defineTask = new ManageMainTask();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MngReports obj = new MngReports();
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/RDLCs/RepMainTask.rdlc");
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource datasource = new ReportDataSource("DataSet1", obj.GetAllMainTask());
                ReportViewer1.LocalReport.DataSources.Add(datasource);
                ReportViewer1.LocalReport.Refresh();
            }
        }

        

    }
}