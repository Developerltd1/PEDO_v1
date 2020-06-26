<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PedoPM01._Default" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

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
     
                  
                     <!--CHART AREA end--> 
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server" Visible="False">
                        <ContentTemplate>
                   <asp:DropDownList ID="ddlHydroProject" runat="server" 
                       OnSelectedIndexChanged="ddlHydroProject_SelectedIndexChanged"
                         AutoPostBack="true"
                       ></asp:DropDownList>
                           
                             <asp:Chart ID="Chart1" runat="server" Height="605px" Width="1039px">
                                 <Series>
                                     <asp:Series ChartArea="ChartArea1" IsValueShownAsLabel="True" Legend="Legend1" Name="Percentage">
                                     </asp:Series>
                                     <asp:Series ChartArea="ChartArea1" ChartType="Line" IsValueShownAsLabel="True" Legend="Legend2" Name="Project End Date">
                                     </asp:Series>
                                 </Series>
                                 <ChartAreas>
                                     <asp:ChartArea Name="ChartArea1">
                                         <AxisY>
                                             <MajorGrid LineColor="Gainsboro" />
                                         </AxisY>
                                         <AxisX>
                                             <MajorGrid LineColor="Gainsboro" />
                                         </AxisX>
                                     </asp:ChartArea>
                                 </ChartAreas>
                                 <Legends>
                                     <asp:Legend Name="Legend1">
                                     </asp:Legend>
                                     <asp:Legend Name="Legend2">
                                     </asp:Legend>
                                 </Legends>
                            </asp:Chart>
                           
                             <!--GRIDVIEW-->
                   </ContentTemplate>
                    </asp:UpdatePanel>
                   </div>
             
</asp:Content>
