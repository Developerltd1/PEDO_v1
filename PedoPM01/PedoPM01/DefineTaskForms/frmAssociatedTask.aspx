<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAssociatedTask.aspx.cs" Inherits="PedoPM01.DefineTaskForms.frmAssociatedTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">Associated Task</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span15">
                <div class="head clearfix">
                    <div class="isw-documents"></div>
                    <h1>Associated Task</h1>
                </div>
                <div class="block-fluid">

                    <%--<asp:UpdatePanel ID="update1" runat="server"><ContentTemplate>--%>
                    <div class="row-form clearfix">
                        <div>Project :</div>
                        <div class="span3">
                            <asp:DropDownList ID="ddlProject" runat="server" AppendDataBoundItems="true" AutoPostBack="true">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row-form clearfix">

                    <asp:GridView ID="GridViewAssociatedTask" runat="server" CellPadding="0" CellSpacing="0" Width="100%" class="table"></asp:GridView>
                        </div>
                </div>
                <!-- block fluid -->
            </div>
            <!-- span -->
        </div>
        <!-- row fluid -->

        <div class="dr"><span></span></div>



    </div>                  <!-- Workplace -->          
</asp:Content>
