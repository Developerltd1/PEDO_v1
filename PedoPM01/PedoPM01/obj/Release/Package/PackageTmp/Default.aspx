<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PedoPM01._Default" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">

    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
   
     <!-- Breadline -->
     <div class="breadLine">
             <ul class="breadcrumb">                
                 <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                <li class="active">HomePage</li>
            </ul>
    </div>
       <!-- workplace -->
  

    <div class="workplace">
      

        <!--*** Hydro Projects Total Progress ***-->
        <div class="row-fluid">
            <div class="span12">
                <div class="head clearfix">
                    <div class="isw-right_circle"></div>
                    <h1>Hydro Projects Total Progress</h1>
                </div>

                <div class="block" >
                    
                    <asp:UpdatePanel ID="UpdatePanel0" runat="server"><ContentTemplate>
                        
                    <asp:Chart ID="CHARTHydroProj" runat="server" Width="1000px" 
                        BackImageTransparentColor="Transparent" BorderlineColor="Transparent" BorderlineWidth="0"
                         EnableTheming="False"  ViewStateContent="All" BackImageAlignment="Center" BackImageWrapMode="TileFlipXY" Height="500px">
                        <Titles>
                            <asp:Title ShadowOffset="3" Name="Items" />
                        </Titles>
                        <Legends>
                            <asp:Legend Name="Legend2" />
                        </Legends>
                        <Series>
                            <asp:Series Name="Series 0"  IsValueShownAsLabel="True" 
                                YValuesPerPoint="4" BackImageAlignment="Center" BorderWidth="0" Color="Highlight" 
                                IsVisibleInLegend="False" Label="#VAL" Legend="Legend2" Font="Microsoft Sans Serif, 9.75pt, style=Bold" ChartType="Bar" />
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1" BorderWidth="0" BorderColor="LightGray" AlignmentOrientation="All" BackColor="Transparent" BackImageTransparentColor="Transparent" IsSameFontSizeForAllAxes="True" ShadowColor="192, 0, 0" >
                                <AxisY IsLabelAutoFit="False">
                                    <MajorGrid Interval="Auto" IntervalType="Auto" LineColor="Gainsboro" />
                                    <MajorTickMark Enabled="False" />
                                    <LabelStyle Font="Microsoft Sans Serif, 9.75pt, style=Bold" />
                                    <ScaleView Size="100" />
                                </AxisY>
                                <AxisX ArrowStyle="Lines" InterlacedColor="Yellow" LineWidth="0" TitleFont="Microsoft Sans Serif, 12pt, style=Bold, Italic">
                                    <MajorGrid Enabled="False" />
                                    <MajorTickMark Enabled="False" />
                                    <LabelStyle Angle="1" Font="Microsoft Sans Serif, 9.75pt, style=Bold" />
                                    <ScaleBreakStyle Enabled="True" />
                                </AxisX>
                            </asp:ChartArea>
                        </ChartAreas>
                        <BorderSkin BackColor="Transparent" BackImageTransparentColor="White" BackSecondaryColor="White" BorderDashStyle="DashDot" />
                    </asp:Chart>
                   </ContentTemplate></asp:UpdatePanel>
                 </div>
            </div>

        </div>

        <!--*** Hydro Work Plan Progress ***-->
         <div class="row-fluid">
            <div class="span12">
                <div class="head clearfix">
                    <div class="isw-right_circle"></div>
                    <h1>Hydro Work Plan Progress</h1>
                </div>
                <div class="block" >
                  
                     <!--CHART AREA end--> 
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                   <asp:DropDownList ID="ddlHydroProject" runat="server" 
                       OnSelectedIndexChanged="ddlHydroProject_SelectedIndexChanged"
                         AutoPostBack="true"
                       ></asp:DropDownList>
                           
                             <!--GRIDVIEW-->
                            <asp:Chart ID="CHARTbar_Project" runat="server" Width="1000px"
                                BackImageTransparentColor="White" BorderlineColor="Transparent" BorderlineWidth="0"
                                ViewStateContent="All" SuppressExceptions="True" EnableViewState="True" Height="800px" RightToLeft="Yes">
                                <Titles>
                                    <asp:Title ShadowOffset="3" Name="Items" BackImageAlignment="Center" Docking="Bottom" ShadowColor="0, 0, 0, 0" Text="Percantage" Font="Segoe UI Black, 14.25pt, style=Bold" ForeColor="DimGray" />
                                    <asp:Title Docking="Left" Name="Title1" Text="Main Task" Font="Segoe UI, 14.25pt, style=Bold" ForeColor="DimGray">
                                    </asp:Title>
                                </Titles>
                                <Legends>
                                    <asp:Legend Name="Legend2" Enabled="True" />
                                </Legends>
                                <Series>
                                    <asp:Series Name="Series 0" IsValueShownAsLabel="True" YValuesPerPoint="19"
                                        BackImageAlignment="Center" BorderWidth="0"
                                        Color="Highlight"
                                        IsVisibleInLegend="True" Legend="Legend2"
                                        Font="Microsoft Sans Serif, 9.75pt, style=Bold" ChartType="Bar">
                                        <EmptyPointStyle BackImageTransparentColor="White" CustomProperties="DrawingStyle=Wedge" IsValueShownAsLabel="True" />
                                    </asp:Series>
                                </Series>
                                <ChartAreas>
                                    <asp:ChartArea Name="ChartArea1" BorderWidth="0" BorderColor="Transparent"
                                        AlignmentOrientation="All" BackImageAlignment="Center"
                                        IsSameFontSizeForAllAxes="True">
                                        <AxisY IsLabelAutoFit="False" TextOrientation="Rotated90" TitleFont="Verdana, 7pt">
                                            <MajorGrid LineColor="Gainsboro" />
                                            <LabelStyle Angle="1" Font="MS Reference Sans Serif, 9.75pt" />
                                            <ScaleView Size="100" />
                                        </AxisY>
                                        <AxisX TextOrientation="Rotated90" IsLabelAutoFit="true">
                                            <MajorGrid Enabled="False" LineColor="Gainsboro" />
                                            <LabelStyle Font="Minion Pro, 9.749999pt, style=Bold" Interval="Auto" ForeColor="DimGray" />
                                        </AxisX>
                                    </asp:ChartArea>
                                </ChartAreas>
                            </asp:Chart>
                   </ContentTemplate>
                    </asp:UpdatePanel>
                   </div>
              </div>
          </div>

         <!--*** Hydro Work Plan Progress By Dates ***-->
         <div class="row-fluid">
            <div class="span12">
                <div class="head clearfix">
                    <div class="isw-right_circle"></div>
                    <h1>Hydro Work Plan Progress By Dates</h1>
                </div>
                <div class="block" >
                     <!--CHART AREA end-->
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                   <asp:DropDownList ID="ddlHydroProject1" runat="server"  AutoPostBack="true" 
                       OnSelectedIndexChanged="ddlHydroProject1_SelectedIndexChanged"></asp:DropDownList>
                         
                            <span>
                            <asp:Chart ID="CHART3" runat="server" BorderlineWidth="0" Height="768px" SuppressExceptions="True" ViewStateContent="All" Width="1000px">
                                <Series>
                                    <asp:Series ChartArea="ChartArea1" ChartType="Line" IsValueShownAsLabel="True" IsXValueIndexed="True" Name="Series1" YAxisType="Secondary" YValuesPerPoint="6">
                                    </asp:Series>
                                    <asp:Series ChartArea="ChartArea1" ChartType="Line" Name="Series2" YValuesPerPoint="6">
                                    </asp:Series>
                                </Series>
                                <ChartAreas>
                                    <asp:ChartArea AlignmentOrientation="All" Name="ChartArea1">
                                        <AxisX IntervalAutoMode="VariableCount" LogarithmBase="2">
                                            <MajorGrid LineColor="DarkGray" />
                                            <ScaleBreakStyle Enabled="True" />
                                        </AxisX>
                                        <AxisY>
                                            <MajorGrid LineColor="DarkGray" />
                                            <ScaleBreakStyle Enabled="True" />
                                        </AxisY>
                                        <AxisX2>
                                            <MajorGrid LineWidth="0" />
                                        </AxisX2>
                                    </asp:ChartArea>
                                </ChartAreas>
                                <Legends>
                                    <asp:Legend DockedToChartArea="ChartArea1" IsDockedInsideChartArea="True" Name="Legend1">
                                        <CellColumns>
                                            <asp:LegendCellColumn BackColor="FloralWhite" ColumnType="SeriesSymbol" ForeColor="128, 255, 128" Name="Column1">
                                                <Margins Left="15" Right="15" />
                                            </asp:LegendCellColumn>
                                        </CellColumns>
                                    </asp:Legend>
                                </Legends>
                                <Titles>
                                    <asp:Title Docking="Bottom" Font="Segoe UI, 14.25pt, style=Bold" Name="Title0" Text="Project Start to  End Date">
                                    </asp:Title>
                                    <asp:Title Docking="Left" Font="Segoe UI, 14.25pt, style=Bold" Name="Title1" Text="Main Task Start to End Date">
                                    </asp:Title>
                                </Titles>
                                <Annotations>
                                    <asp:LineAnnotation Name="LineAnnotation1" YAxisName="ChartArea1\rY">
                                    </asp:LineAnnotation>
                                </Annotations>
                            </asp:Chart>
                            </span>
                   </ContentTemplate>
                    </asp:UpdatePanel>
                   </div>
            </div>

        </div>
          <div class="dr"></div>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
        <!--Second Row 2 Col-->
        

       

                <div class="row-fluid">
              </div>
            </ContentTemplate></asp:UpdatePanel>
            </div>

    
        
</asp:Content>
