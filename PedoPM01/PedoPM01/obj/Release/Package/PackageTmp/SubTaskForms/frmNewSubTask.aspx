<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmNewSubTask.aspx.cs" Inherits="PedoPM01.SubTaskForms.frmNewSubTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">New Sub Task / Task Progress</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span4">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>Sub Task / Task Progress</h1>
                    </div>
                    <div class="block-fluid">                        
                        
                           <%--<asp:UpdatePanel ID="update1" runat="server"><ContentTemplate>--%>
                         <div class="row-form clearfix">
                            <div>Project :</div>
                            <div class="span10">
                                <asp:DropDownList ID="ddlProject" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlProject_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList></div>
                        </div>
                    
                      
                         <div class="row-form clearfix">
                            <div>Hydro Main Task:</div>
                            <div class="span10">
                                <asp:DropDownList ID="ddlDefineTask" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlDefineTask_SelectedIndexChanged"></asp:DropDownList>
                               <%--<div>Start Date:</div> <asp:TextBox ID="tbMainTaskStartDate" runat="server" ForeColor="Red" ReadOnly="true"></asp:TextBox>(dd/mm/yy)
                                <div>Finish Date:</div><asp:TextBox ID="tbMainTaskFinishDate" runat="server" ForeColor="Red" ReadOnly="true"></asp:TextBox>(dd/mm/yy)--%>
                        </div> </div>


                              <%-- </ContentTemplate></asp:UpdatePanel>--%>
                        <div class="row-form clearfix">
                            <div>Task Progress:</div>
                            <div class="span10">
                <asp:TextBox ID="tbSubTaskName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="tbSubTaskName" errormessage="Please enter sub task*" ForeColor="Red" />

                            </div>
                        </div> 

                       
                      <div class="row-form clearfix">
                            <div>Remarks:</div>
                            <div class="span10">
                <asp:TextBox ID="tbRemarks" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator3" controltovalidate="tbRemarks" errormessage="Please enter remarks*" ForeColor="Red" />
                            </div>
                        </div>
                         
                        
                         <div class="row-form clearfix">
                            <div>Percentage:</div>
                            <div class="span10">
                <asp:TextBox ID="tbPercantage" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" controltovalidate="tbPercantage" errormessage="Please enter percantage*" ForeColor="Red" />
                            </div>
                        </div> 
                    <%--    <div class="row-form clearfix">
                            <div class="span3">Start Date:</div>
                            <div class="row span3"><asp:TextBox ID="tbStartDate" runat="server" placeholder="Select Date" AutoCompleteType="Disabled"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="tbStartDate" Format="dd/MM/yyyy" />
                                 <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" controltovalidate="tbStartDate" errormessage="Please enter commencement date*" ForeColor="Red" />
                               
                            </div>
                        </div>

                         <div class="row-form clearfix">
                            <div class="span3">Finish Date:</div>
                            <div class="row span3"><asp:TextBox ID="tbDeadline" runat="server" placeholder="Select Date" AutoCompleteType="Disabled"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="tbDeadline" Format="dd/MM/yyyy" />
                                 <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator4" controltovalidate="tbDeadline" errormessage="Please enter commencement date*" ForeColor="Red" />
                               
                            </div>
                        </div>--%>
                                       

                         <div class="row-form clearfix">
                             <div></div>
                            <div class="span3">
                             <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"  /></div>
                            </div>
                        
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->


            <div class="span8">
                    <div class="head clearfix">
                        <div class="isw-grid"></div>
                        <h1>Task Progress Table</h1>
                    </div>
                    <div class="block-fluid">                        
                        <div style="/*max-height:400px;*/ overflow:scroll">
                        <asp:GridView ID="GridViewSubTask" runat="server" CellPadding="0"  CellSpacing="0" Width="100%" class="table"></asp:GridView>
                        </div>
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>



    </div>                  <!-- Workplace -->                   
                  

</asp:Content>
