<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMainTaskReport.aspx.cs" Inherits="PedoPM01.Reports.frmMainTaskReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="font-family:Garamond; font-weight:600;color:black; text-align:center; margin-top:-30px">Hydro Work Plan Report</h2>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" style="margin-left: 17px" Width="1261px" Height="590px">
        <LocalReport ReportEmbeddedResource="PedoPM01.RDLCs.RepMainTask.rdlc">
          
        </LocalReport>
       
    </rsweb:ReportViewer>
   
  
    </asp:Content>
