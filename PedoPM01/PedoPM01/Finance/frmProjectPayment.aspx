<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmProjectPayment.aspx.cs" Inherits="PedoPM01.Finance.frmProjectPayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
       <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">Project Payment</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>Project Payment</h1>
                    </div>
                    <div class="block-fluid">                        
                        
                            
                       
                       
                        <div class="row-form clearfix">
                            <div class="span3">Project:</div>
                            <div class="span3">
                            <asp:DropDownList ID="ddlProject" runat="server" OnSelectedIndexChanged="ddlProject_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></div>
                        </div>

                       <div class="row-form clearfix">
                            <div class="span3">Finance Type:</div>
                            <div class="span3">
                            <asp:DropDownList ID="ddlFinType" runat="server" OnSelectedIndexChanged="ddlFinType_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></div>
                        </div>
                       
                        <div class="row-form clearfix">
                            <div class="span3">Project Cost:</div> 
                            <div class="span3"><asp:TextBox ID="tbProjectCost" runat="server" ReadOnly="true"></asp:TextBox>
                                <asp:TextBox ID="tbProjectFinID" runat="server" Visible="false"></asp:TextBox>
                               </div>
                         </div>

                        <div class="row-form clearfix">
                            <div class="span3">Paid Amount:</div> 
                            <div class="span3"><asp:TextBox ID="tbPaidAmount" runat="server"></asp:TextBox>
                                
                            </div>
                         </div>

                        <div class="row-form clearfix">
                            <div class="span3">Payment Date:</div>
                            <div class="row span3"><asp:TextBox ID="tbPaymentDate" runat="server" placeholder="Select Date" AutoCompleteType="Disabled"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="tbPaymentDate" Format="dd/MM/yyyy" />
                                
                            </div>
                        </div>

                        <div class="row-form clearfix">
                            <div class="span3">Payment Method:</div> 
                            <div class="span3"><asp:TextBox ID="tbPaymentMode" runat="server"></asp:TextBox>
                             
                            </div>
                         </div>

                         <div class="row-form clearfix">
                            <div class="span3">Particulars:</div> 
                            <div class="span3"><asp:TextBox ID="tbParticulars" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                         </div>

                         <div class="row-form clearfix">
                            <div class="span3"></div>
                                <div class="span3">
                            <asp:Button ID="btnSave" runat="server" Text="Save"  CssClass="btn" OnClick="btnSave_Click" /></div>
                       </div> 


                        
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>
          </div>      <!-- Workplace -->
</asp:Content>
