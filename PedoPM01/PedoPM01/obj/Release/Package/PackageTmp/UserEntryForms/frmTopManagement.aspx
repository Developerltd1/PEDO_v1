<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmTopManagement.aspx.cs" Inherits="PedoPM01.UserEntryForms.frmTopManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">Top Management's Registration</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span4">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>Top Management's Registration</h1>
                    </div>
                    <div class="block-fluid">                        
                        
                       
                        <div class="row-form clearfix">
                            <div>User Role:</div> 
                            <div class="span10">
                                 <asp:DropDownList ID="cbRoles" runat="server"></asp:DropDownList></div>
                             
                         </div>
                         <div class="row-form clearfix">
                            <div>User Name:</div> 
                            <div class="span10"><asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" controltovalidate="tbUserName" errormessage="Please enter title*" ForeColor="Red" />
                            </div>
                         </div>
                        <div class="row-form clearfix">
                            <div>Password:</div> 
                            <div class="span10"><asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" controltovalidate="tbPassword" errormessage="Please enter title*" ForeColor="Red" />
                            </div>
                         </div>
                
                      
                         <div class="row-form clearfix">
                            <div></div>
                                <div class="span10">
                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn"/></div>
                       </div> 


                    </div>  <!-- block fluid -->
                </div>      <!-- span -->


            <div class="span8">
                    <div class="head clearfix">
                        <div class="isw-grid"></div>
                        <h1>Top Management's Table</h1>
                    </div>
                    <div class="block-fluid">                        
                        
                        <asp:GridView ID="GridView1" runat="server" CellPadding="0"  CellSpacing="0" Width="100%" class="table"></asp:GridView>
                        
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>



    </div>                  <!-- Workplace -->   
</asp:Content>
