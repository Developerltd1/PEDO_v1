<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmSubTaskReport.aspx.cs" Inherits="PedoPM01.Reports.frmSubTaskReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="font-family:Garamond; font-weight:600;color:black; text-align:center; margin-top:-30px">Task Progress Report</h2>
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana"  Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="953px" Height="612px" style="margin-left: 75px; margin-right: 0px;">
        <LocalReport ReportEmbeddedResource="PedoPM01.RDLCs.RepSubTask.rdlc">
          
        </LocalReport>
        
    </rsweb:ReportViewer>
  
</asp:Content>
