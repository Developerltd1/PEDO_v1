<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frm_GetProjectFinTransByPaymentDate.aspx.cs" Inherits="PedoPM01.Reports.frm_GetProjectFinTransByPaymentDate" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

   <h2 style="font-family:Garamond; font-weight:600;color:black; text-align:center; margin-top:-30px">Finance Details</h2>
    <rsweb:ReportViewer ID="ReportViewer2" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="980px" style="margin-left: 59px">
        <LocalReport ReportEmbeddedResource="PedoPM01.RDLCs.Repo_GetProjectFinTransBy_PaymentDate.rdlc">
          
        </LocalReport>
    
        
    </rsweb:ReportViewer>
    
    
</asp:Content>
