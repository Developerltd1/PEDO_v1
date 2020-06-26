<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmEditProject.aspx.cs" Inherits="PedoPM01.ProjectForms.frmEditProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">Edit Project</li>
                    </ul>
            </div>
    <%--</div>--%>
  
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                <div class="head clearfix">
                    <div class="isw-grid"></div>
                    <h1>Edit Project</h1>
                </div>
                <div class="block-fluid">
                    <div style="/*max-height: 400px; */ overflow: scroll">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>

                                <asp:GridView ID="GridView1" runat="server" CellPadding="0" DataKeyNames="ID" CellSpacing="0" Width="100%" class="table" AutoGenerateColumns="false"
                                    OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing"
                                    OnRowUpdating="GridView1_RowUpdating" EmptyDataText="No records has been added." AutoGenerateEditButton="true" OnRowDataBound="GridView1_RowDataBound" >
                                    <Columns>

                                        <asp:TemplateField HeaderText="Project">
                                            <ItemTemplate>
                                                <%# Eval("Title")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="tbTitle" Text='<%# Eval("Title")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Consultant">
                                            <ItemTemplate>
                                                <%# Eval("Consultant")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="tbConsultant" Text='<%# Eval("Consultant")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Contractor">
                                            <ItemTemplate>
                                                <%# Eval("Contractor")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="tbContractor" Text='<%# Eval("Contractor")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Capicity">
                                            <ItemTemplate>
                                                <%# Eval("Capicity")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="tbCapicity" Text='<%# Eval("Capicity")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>


                                        <asp:TemplateField HeaderText="Start Date">
                                            <ItemTemplate>
                                                <%# Eval("StartDate")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="tbStartDate" Text='<%# Eval("StartDate")%>' />
                                                <ajaxToolkit:CalendarExtender ID="CalendarExtender_StartDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbStartDate" />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Finish Date">
                                            <ItemTemplate>
                                                <%# Eval("FinishDate")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="tbFinishDate" Text='<%# Eval("FinishDate")%>' />
                                                <ajaxToolkit:CalendarExtender ID="CalendarExtender_FinishDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbFinishDate" />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="District">
                                            <ItemTemplate>
                                                <%# Eval("District")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="cbDistrict"  runat="server" AppendDataBoundItems="true" AutoPostBack="true" ></asp:DropDownList>
                                                 </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="true" />

                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
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
