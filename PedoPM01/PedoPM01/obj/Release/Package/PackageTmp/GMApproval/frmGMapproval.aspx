<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmGMapproval.aspx.cs" Inherits="PedoPM01.DefineTaskForms.frmGMapprovement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

     <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">Approve Hydro Workplan</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>Approve Hydro Workplan</h1>
                    </div>
                 <div class="block-fluid">
                          
                 <div class="row-form clearfix">
                            <div class="span1">Project:</div>
                            <div class="span3"><asp:DropDownList ID="ddlProject" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlProject_SelectedIndexChanged">
                                <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                                               </asp:DropDownList></div>
                        </div>
              </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>



    </div>                  <!-- Workplace -->


    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                <div class="head clearfix">
                    <div class="isw-grid"></div>
                    <h1>Hydro Table</h1>
                </div>
                <div class="block-fluid">
                    <div style="/*max-height:400px;*/ overflow:scroll">
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="0" DataKeyNames="ID"
          CellSpacing="0" Width="100%" class="table" HeaderStyle-BackColor="white" ShowFooter="false">
        <Columns>
            <asp:TemplateField HeaderText="Approved">
            <ItemTemplate>
                <asp:CheckBox ID="cbApproved" runat="server" Checked='<%# Eval("Approved") %>' />
            </ItemTemplate>
           
        </asp:TemplateField>
            <asp:BoundField DataField="Approved" HeaderText="Approved" ReadOnly="true" />
       <asp:BoundField DataField="TaskName" HeaderText="TaskName" ReadOnly="true" />
            <asp:BoundField DataField="StartDate" HeaderText="StartDate" ReadOnly="true" />
            <asp:BoundField DataField="DeadlineDate" HeaderText="DeadlineDate" ReadOnly="true" />
            <asp:BoundField DataField="DesignDate" HeaderText="DesignDate" ReadOnly="true" />
            <asp:BoundField DataField="DesignFinishDate" HeaderText="DesignFinishDate" ReadOnly="true" />
            <asp:BoundField DataField="ConstructDate" HeaderText="ConstructDate" ReadOnly="true" />
            <asp:BoundField DataField="ConstructFinishDate" HeaderText="ConstructFinishDate" ReadOnly="true" />
<%--            <asp:BoundField DataField="OrderingDate" HeaderText="OrderingDate" ReadOnly="true" />
            <asp:BoundField DataField="OrderingFinishDate" HeaderText="OrderingFinishDate" ReadOnly="true" />
            <asp:BoundField DataField="ShipmentDate" HeaderText="ShipmentDate" ReadOnly="true" />
            <asp:BoundField DataField="ShipmentFinishDate" HeaderText="ShipmentFinishDate" ReadOnly="true" />--%>
            <asp:BoundField DataField="InstallationDate" HeaderText="InstallationDate" ReadOnly="true" />
            <asp:BoundField DataField="InstallationFinishDate" HeaderText="InstallationFinishDate" ReadOnly="true" />
            <asp:BoundField DataField="Remarks" HeaderText="Remarks" ReadOnly="true" />

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Label ID="lbTaskID" runat="server" Text='<%# Eval("ID")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

    </Columns>
 
</asp:GridView>
                     <div class="row-form clearfix">
                            <div class="span3"></div>
                            <div class="span1">
                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></div>
                        </div>
               
                                                </div>
                    
                </div>
                <!-- block fluid -->
            </div>
            <!-- span -->
        </div>
        <!-- row fluid -->

        <div class="dr"><span></span></div>

    </div>              <!-- Workplace -->


</asp:Content>
