<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmNewProject.aspx.cs" Inherits="PedoPM01.ProjectForms.frmNewProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">  
    <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">New Project</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>New Project</h1>
                    </div>
                    <div class="block-fluid">     
                         <div class="row-form clearfix">
                        <%--    <div class="span3">Users:</div>
                            <div class="span3">
                <asp:DropDownList ID="ddlUsers" runat="server"></asp:DropDownList></div>
                        </div>                   
                        <div class="row-form clearfix">
                            <div class="span3">Field Worker:</div>
                        <div class="span3"><asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Title"
                             DataValueField="Title" SelectionMode="Multiple"></asp:ListBox></div></div>
                        --%>    
                            <div class="row-form clearfix">
                            <div class="span3">Category:</div>
                            <div class="span3">
                <asp:DropDownList ID="cbCategory" runat="server"></asp:DropDownList></div>
                        </div>
                        <div class="row-form clearfix">
                            <div class="span3">Title:</div> 
                            <div class="span3"><asp:TextBox ID="tbTitle" runat="server"></asp:TextBox>
                                <%--<asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="tbTitle" errormessage="Please enter title*" ForeColor="Red" />--%>
                            </div>
                            
                        </div>
                         
                       

                               <div class="row-form clearfix">
                            <div class="span3">Consultant:</div> 
                            <div class="span3"><asp:TextBox ID="tbConsultant" runat="server"></asp:TextBox>
                                <%--<asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="tbTitle" errormessage="Please enter title*" ForeColor="Red" />--%>
                            </div>
                            
                        </div>

                               <div class="row-form clearfix">
                            <div class="span3">Contractor:</div> 
                            <div class="span3"><asp:TextBox ID="tbContractor" runat="server"></asp:TextBox>
                                <%--<asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="tbTitle" errormessage="Please enter title*" ForeColor="Red" />--%>
                            </div>
                            
                        </div>

                              <div class="row-form clearfix">
                            <div class="span3">Capicity:</div> 
                            <div class="span3"><asp:TextBox ID="tbCapicity" runat="server"></asp:TextBox>
                                <%--<asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="tbTitle" errormessage="Please enter title*" ForeColor="Red" />--%>
                            </div>
                            
                        </div>

                         <div class="row-form clearfix">
                            <div class="span3">Start Date:</div>
                            <div class="row span3"><asp:TextBox ID="tb_CommencementDate" runat="server" placeholder="Select Date" AutoCompleteType="Disabled"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="tb_CommencementDate" Format="dd/MM/yyyy" />
<%--                                 <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" controltovalidate="tb_CommencementDate" errormessage="Please enter commencement date*" ForeColor="Red" />--%>
                               
                            </div>
                        </div>

                        <div class="row-form clearfix">
                            <div class="span3">Completion Date:</div>
                            <div class="row span3">
                                <asp:TextBox ID="tb_ProposalDeadline" runat="server" placeholder="Select Date" AutoCompleteType="Disabled"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender_Proposal" runat="server" PopupPosition="BottomLeft" Format="dd/MM/yyyy" PopupButtonID="tb_ProposalDeadline" TargetControlID="tb_ProposalDeadline" />
<%--                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="tb_ProposalDeadline" ErrorMessage="Please enter proposal deadline*" ForeColor="Red" />--%>
                            </div>
                        </div>
                                                 
                       <%-- This Code is For District popup --%>
                           <div class="row-form clearfix">
                          <div class="span3">District:</div>
                            
                           <div class="span3">
                            <asp:DropDownList ID="cbDistrict" runat="server"></asp:DropDownList>
                                <asp:Button ID="BtnAddNewDistrict" runat="server" 
                                    Text="Add New District" 
                                    OnClick="btnSavenewDistrtct_Click" CssClass="btn-info"  />
                           </div>
                            
                            <asp:Panel ID="Panel1" runat="server"  CssClass="modalPopup" >
                                <asp:Label ID="Label1" runat="server" Text="Add New District"></asp:Label>
                                <asp:TextBox ID="tbNewDistrict" runat="server"></asp:TextBox>
                                <asp:Button ID="btnSavenewDistrtct" runat="server" 
                                    Text="Submit" 
                                    OnClick="btnSavenewDistrtct_Click" />
                                <asp:Button ID="btnCancelDistrict" runat="server" Text="Cancel" />
                            </asp:Panel>
                            
                            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" 
                                CancelControlID="btnCancelDistrict" 
                                PopupControlID="Panel1" 
                                TargetControlID="BtnAddNewDistrict"
                                DropShadow="true" 
                                BackgroundCssClass="modalBackground"
                                >
                            </ajaxToolkit:ModalPopupExtender>
                        </div>


                     
                       <%-- <div class="row-form clearfix">
                            <div class="span3">Latitude:</div>
                            <div class="span3">
                                <asp:TextBox ID="tbLatitute" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator4" ControlToValidate="tbLatitute" ErrorMessage="Please enter latitude*" ForeColor="Red" />
                            </div>
                        </div>

                        <div class="row-form clearfix">
                            <div class="span3">Longitude:</div>
                            <div class="span3">
                                <asp:TextBox ID="tbLongitude" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator5" ControlToValidate="tbLongitude" ErrorMessage="Please enter longitude*" ForeColor="Red" />
                            </div>
                        </div>--%>

                         <div class="row-form clearfix">
                            <div class="span3"></div>
                                <div class="span3">
                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn" /></div>
                       </div> 


                        
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>
          </div>      <!-- Workplace -->

</asp:Content>
