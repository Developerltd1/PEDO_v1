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
    public partial class frm_GetProjectFinTransByPaymentDate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MngReports obj = new MngReports();
                ReportViewer2.ProcessingMode = ProcessingMode.Local;
                ReportViewer2.LocalReport.ReportPath = Server.MapPath("~/RDLCs/Repo_GetProjectFinTransBy_PaymentDate.rdlc");
                ReportViewer2.LocalReport.DataSources.Clear();
                ReportDataSource datasource = new ReportDataSource("DataSet1", obj.GetProjectFinTransBy_PaymentDate());
                ReportViewer2.LocalReport.DataSources.Add(datasource);
                ReportViewer2.LocalReport.Refresh();
            }
        }
    }
}