<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmNewUmbrellaProject.aspx.cs" Inherits="PedoPM01.ProjectForms.frmNewUmbrellaProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">New Umbrella Project</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>New Umbrella Project</h1>
                    </div>
                    <div class="block-fluid">                        
                     
                   <%--<div class="row-form clearfix">
                            <div class="span3">Parent Project:</div>
                            <div class="span9">
                   <asp:DropDownList ID="cbParentProject" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                  </asp:DropDownList></div>
                        </div>                    
                            
                            --%>

                       <div class="row-form clearfix">
                            <div class="span3">Category:</div>
                            <div class="span9">
                <asp:DropDownList ID="cbCategory" runat="server"></asp:DropDownList></div>
                        </div>
                        <div class="row-form clearfix">
                            <div class="span3">Title:</div>
                            <div class="span9">
                                <asp:TextBox ID="tbTitle" runat="server"></asp:TextBox>
                                <asp:TextBox ID="tbName" runat="server" Text="3" Visible="false"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="reqName" ControlToValidate="tbTitle" ErrorMessage="Please enter title*" ForeColor="Red" />

                            </div>

                        </div>
                         
                        

                         <div class="row-form clearfix">
                            <div class="span3">Commencement Date:</div>
                            <div class="row span3"><asp:TextBox ID="tb_CommencementDate" runat="server" placeholder="Select Date" AutoCompleteType="Disabled"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="tb_CommencementDate" Format="dd/MMM/yyyy" />
                                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" controltovalidate="tb_CommencementDate" errormessage="Please enter commencement date*" ForeColor="Red" />
                            </div>
                        </div>

                        <div class="row-form clearfix">
                            <div class="span3">Proposal Deadline:</div>
                            <div class="row span3">
                                <asp:TextBox ID="tb_ProposalDeadline" runat="server" placeholder="Select Date" AutoCompleteType="Disabled"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender_Proposal" runat="server" PopupPosition="BottomLeft" Format="dd/MMM/yyyy" PopupButtonID="tb_ProposalDeadline" TargetControlID="tb_ProposalDeadline" />
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="tb_ProposalDeadline" ErrorMessage="Please enter proposal deadline*" ForeColor="Red" />

                            </div>
                        </div>
                                                 
                        
                                <asp:TextBox ID="tb_Entry_Date" runat="server" placeholder="Select Date" AutoCompleteType="Disabled" Visible="false"></asp:TextBox>
                                <%--<ajaxToolkit:CalendarExtender ID="CalendarExtender_EntryDate" runat="server" PopupPosition="BottomLeft" Format="dd/MMM/yyyy" PopupButtonID="tb_Entry_Date" TargetControlID="tb_Entry_Date" />--%>

                            

                        <div class="row-form clearfix">
                            <div class="span3">District:</div>
                            <div class="span9">
                                <asp:DropDownList ID="cbDistrict" runat="server"></asp:DropDownList>
                            </div>
                            <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="cbDistrict" ErrorMessage="Please enter district*" ForeColor="Red" />
                        </div>

                        <div class="row-form clearfix">
                            <div class="span3">Latitude:</div>
                            <div class="span9">
                                <asp:TextBox ID="tbLatitute" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator4" ControlToValidate="tbLatitute" ErrorMessage="Please enter latitude*" ForeColor="Red" />
                            </div>
                        </div>

                        <div class="row-form clearfix">
                            <div class="span3">Longitude:</div>
                            <div class="span9">
                                <asp:TextBox ID="tbLongitude" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator5" ControlToValidate="tbLongitude" ErrorMessage="Please enter longitude*" ForeColor="Red" />
                            </div>
                        </div>


                         <div class="row-form clearfix">
                            <div class="span3"></div>
                                <div class="span1">
                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></div>
                       </div>

                        
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>





</asp:Content>
