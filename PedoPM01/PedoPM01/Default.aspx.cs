using Microsoft.Reporting.WebForms;
using PedoPM01.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace PedoPM01
{
    public partial class _Default : Page
    {
        MngCharts objChart = new MngCharts();
        protected void Page_Load(object sender, EventArgs e)
        {
            //---------------------------------------------------------------//
            // CHART - AllHydroProjects
            DataTable DT_hydroProject = objChart.displayCHART_allHydroProjects();
            CHARTHydroProj.DataSource = DT_hydroProject;
            List<string> name_Hydro = new List<string>();
            List<int> progrss_Hydro = new List<int>();
            for (int i = 0; i < DT_hydroProject.Rows.Count; i++)
            {
                name_Hydro.Add(DT_hydroProject.Rows[i][0].ToString());
                progrss_Hydro.Add(Convert.ToInt32(DT_hydroProject.Rows[i][1]));
            }
            CHARTHydroProj.Legends[0].Enabled = true;
            CHARTHydroProj.Series[0].Points.DataBindXY(name_Hydro, progrss_Hydro);
            CHARTHydroProj.Series[0]["PixelPointWidth"] = "15";
            CHARTHydroProj.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            CHARTHydroProj.DataBind();
            //---------------------------------------------------------------//
            #region DEFAULT HTML CODE
       //     < !--***Hydro Work Plan Progress * **-->
      //   < div class="row-fluid">
      //      <div class="span12">
      //          <div class="head clearfix">
      //              <div class="isw-right_circle"></div>
      //              <h1>Hydro Work Plan Progress</h1>
      //          </div>
      //          <div class="block" >
      //            
      //            
      //             </div>
      //        </div>
      //    </div>
      //  <!--Second Row 2 Col-->
            #endregion
            //   if (!IsPostBack)
            //  { //DropDownList Finance
            //   ManageProject proj1 = new ManageProject();
            //   ddlHydroProject.DataSource = proj1.getProject_IDandName();
            //   ddlHydroProject.DataTextField = "Title";
            //   ddlHydroProject.DataValueField = "ProjectID";
            //   ddlHydroProject.DataBind();

            // }
            //---------------------------------------------------------------//
            //Default Chart Show by ProjectID
            showingDefaultChartbyProjectID();
           
        }

        private void showingDefaultChartbyProjectID()
        {
            MngCharts objChart1 = new MngCharts();

            //CHART BAR
            DT1 = objChart1.displayCHART_HydroProjectProgress_byProjectID(Convert.ToInt32(7025));
            Chart1.DataSource = DT1;
            DT2 = objChart1.displayCHART_HydroProjectProgress_byProjectID_SDATEtoEDATE(Convert.ToInt32(7025));
            Chart1.DataSource = DT2;

            List<string> name_Hydro_bar = new List<string>();
            List<int> progrss_Hydro_bar = new List<int>();
            List<DateTime> startDate = new List<DateTime>();
            List<DateTime> endDate = new List<DateTime>();
            DateTime a;

            for (int i = 0; i < DT1.Rows.Count; i++)
            {
                name_Hydro_bar.Add(DT1.Rows[i][0].ToString());
                progrss_Hydro_bar.Add(Convert.ToInt32(DT1.Rows[i][1]));
            }
          // for (int i = 0; i < DT2.Rows.Count; i++)
          // {
          //     startDate.Add(Convert.ToDateTime(DT2.Rows[i][2]));
          //     endDate.Add(Convert.ToDateTime(DT2.Rows[i][3]));
          // }

           // Chart1.Series[0].Points.DataBindXY(name_Hydro_bar, progrss_Hydro_bar);
           // Chart1.Series[1].Points.DataBindY(endDate);

            Chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            // Chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1;

            Chart1.DataBind();
        }

        DataTable DT1;
        DataTable DT2;

        protected void ddlHydroProject_SelectedIndexChanged(object sender, EventArgs e)
        {
             MngCharts objChart1 = new MngCharts();

            //CHART BAR
                DT1 = objChart1.displayCHART_HydroProjectProgress_byProjectID(Convert.ToInt32(ddlHydroProject.SelectedValue));
                Chart1.DataSource = DT1;
                DT2 = objChart1.displayCHART_HydroProjectProgress_byProjectID_SDATEtoEDATE(Convert.ToInt32(ddlHydroProject.SelectedValue));
                Chart1.DataSource = DT2;

                List<string> name_Hydro_bar = new List<string>();
                List<int> progrss_Hydro_bar = new List<int>();
                List<DateTime> startDate = new List<DateTime>();
                List<DateTime> endDate = new List<DateTime>();
              
                for (int i = 0; i < DT1.Rows.Count; i++)
                { name_Hydro_bar.Add(DT1.Rows[i][0].ToString());
                  progrss_Hydro_bar.Add(Convert.ToInt32(DT1.Rows[i][1]));
                }
                for (int i = 0; i < DT2.Rows.Count; i++)
                {
                      startDate.Add(Convert.ToDateTime(DT2.Rows[i][2]));
                      endDate.Add(Convert.ToDateTime(DT2.Rows[i][3]));
                }
                
                Chart1.Series[0].Points.DataBindXY(name_Hydro_bar, progrss_Hydro_bar);
                Chart1.Series[1].Points.DataBindY(endDate);
                
                Chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
               // Chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1;

                Chart1.DataBind();
        }
       
    }
}