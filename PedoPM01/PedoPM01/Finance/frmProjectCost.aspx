<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmProjectCost.aspx.cs" Inherits="PedoPM01.Finance.frmProjectCost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">Project Cost</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>Project Cost</h1>
                    </div>
                    <div class="block-fluid">                        
                        
                            
                       
                       
                        <div class="row-form clearfix">
                            <div class="span3">Project:</div>
                            <div class="span3">
                            <asp:DropDownList ID="ddlProject" runat="server"></asp:DropDownList></div>
                        </div>

                       <div class="row-form clearfix">
                            <div class="span3">Finance Type:</div>
                            <div class="span3">
                            <asp:DropDownList ID="ddlFinType" runat="server"></asp:DropDownList></div>
                        </div>
                       
                        <div class="row-form clearfix">
                            <div class="span3">Cost:</div> 
                            <div class="span3"><asp:TextBox ID="tbCost" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" controltovalidate="tbCost" errormessage="Please enter title*" ForeColor="Red" />
                            </div>
                         </div>
                         <div class="row-form clearfix">
                            <div class="span3">Remarks:</div> 
                            <div class="span3"><asp:TextBox ID="tbRemarks" runat="server" TextMode="MultiLine"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" controltovalidate="tbCost" errormessage="Please enter title*" ForeColor="Red" />
                            </div>
                         </div>

                         <div class="row-form clearfix">
                            <div class="span3"></div>
                                <div class="span3">
                            <asp:Button ID="btnSave" runat="server" Text="Save"  CssClass="btn" OnClick="btnSave_Click"/></div>
                       </div> 


                        
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>
          </div>      <!-- Workplace -->
</asp:Content>
