<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmNewSolarMainTask.aspx.cs" Inherits="PedoPM01.DefineTaskForms.frmNewSolarMainTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">New Solar Main Task</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>New Solar Main Task</h1>
                    </div>
                    <div class="block-fluid">    
                     
                        <div class="row-form clearfix">
                            <div class="span3">Project:</div>
                            <div class="span3"><asp:DropDownList ID="ddlProject" runat="server"></asp:DropDownList></div>
                        </div>
                    
                        
                        <div class="row-form clearfix">
                            <div class="span3">Task Name:</div>                            
                        <div class="span3">
                            <asp:TextBox ID="tbTaskName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="tbTaskName" errormessage="Please enter task*" ForeColor="Red" />

                        </div>
                        </div> 

                        <div class="row-form clearfix">
                            <div class="span3">Task Type:</div>
                            <div class="span3"><asp:DropDownList ID="ddlType" runat="server"></asp:DropDownList></div>
                           
                        </div>

                        
                        <div class="row-form clearfix">
                            <div class="span3">Start Date:</div>
                            <div class="row span3"><asp:TextBox ID="tbStartDate" runat="server" placeholder="Select Date" AutoCompleteType="Disabled"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender_StartDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbStartDate" />
                            <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" controltovalidate="tbStartDate" errormessage="Please enter start date*" ForeColor="Red" />
                            </div>
                        </div>
                        <div class="row-form clearfix">
                            <div class="span3">Deadline Date:</div>
                           <div class="row span3"> <asp:TextBox ID="tbDeadlineDate" runat="server" placeholder="Select Date" AutoCompleteType="Disabled"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender_DeadlineDate" runat="server"  Format="dd/MM/yyyy" TargetControlID="tbDeadlineDate" />
                            <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" controltovalidate="tbDeadlineDate" errormessage="Please enter deadline date*" ForeColor="Red" />
                         </div>
                            </div>
                        <div class="row-form clearfix">
                            <div class="span3">Remarks:</div>
                            <div class="span3"><asp:TextBox id="tbRemarks" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator3" controltovalidate="tbRemarks" errormessage="Please enter remarks*" ForeColor="Red" />
                            </div>
                            </div>

                        <div class="row-form clearfix">
                            <div class="span3"></div>
                            <div class="span3">
                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"  /></div>
                        </div>

                                            
                        
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>



    </div>                  <!-- Workplace -->
</asp:Content>
