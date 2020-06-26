<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SolarSubTask.aspx.cs" Inherits="PedoPM01.SubTaskForms.SolarSubTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">New Solar Sub Task / Task Progress</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>Solar Sub Task / Task Progress</h1>
                    </div>
                    <div class="block-fluid">                        
                        
                           <asp:UpdatePanel ID="update1" runat="server"><ContentTemplate>
                         <div class="row-form clearfix">
                            <div class="span3">Project:</div>
                            <div class="span3">
                                <asp:DropDownList ID="ddlProject" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlProject_SelectedIndexChanged" AutoPostBack="true">
                                
                                </asp:DropDownList></div>
                        </div>
                    
                      
                         <div class="row-form clearfix">
                            <div class="span3">Solar Main Task:</div>
                            <div class="span3">
                                <asp:DropDownList ID="ddlDefineTask" runat="server" AppendDataBoundItems="true" AutoPostBack="true"></asp:DropDownList>
                        </div> </div>
                               </ContentTemplate></asp:UpdatePanel>
                        <div class="row-form clearfix">
                            <div class="span3">Sub Task:</div>
                            <div class="span3">
                <asp:TextBox ID="tbSubTaskName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="tbSubTaskName" errormessage="Please enter sub task*" ForeColor="Red" />

                            </div>
                        </div> 

                       
                      <div class="row-form clearfix">
                            <div class="span3">Remarks:</div>
                            <div class="span3">
                <asp:TextBox ID="tbRemarks" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator3" controltovalidate="tbRemarks" errormessage="Please enter remarks*" ForeColor="Red" />
                            </div>
                        </div>
                         
                        
                         <div class="row-form clearfix">
                            <div class="span3">Percentage:</div>
                            <div class="span3">
                <asp:TextBox ID="tbPercantage" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" controltovalidate="tbPercantage" errormessage="Please enter percantage*" ForeColor="Red" />
                            </div>
                        </div> 

                         <div class="row-form clearfix">
                             <div class="span3"></div>
                            <div class="span1">
                             <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"  /></div>
                            </div>
                        
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>



    </div>                  <!-- Workplace -->
</asp:Content>
