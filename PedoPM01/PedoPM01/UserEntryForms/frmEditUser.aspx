<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmEditUser.aspx.cs" Inherits="PedoPM01.UserEntryForms.frmEditUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">User Registration</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>Edit Users</h1>
                    </div>
                    <div class="block-fluid">                        
                        
                            
                      <asp:GridView ID="GridViewUser" runat="server" CellPadding="0"  CellSpacing="0" Width="100%" class="table"></asp:GridView>  
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>
          </div>      <!-- Workplace -->
</asp:Content>
