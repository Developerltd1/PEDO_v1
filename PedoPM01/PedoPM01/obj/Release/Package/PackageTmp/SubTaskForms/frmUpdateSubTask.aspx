<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmUpdateSubTask.aspx.cs" Inherits="PedoPM01.SubTaskForms.frmEditSubTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">Edit Task Progress</li>
                    </ul>
            </div>
 
     <div class="workplace">
        <div class="row-fluid">
            <div class="span4">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>Edit Task Progress</h1>
                    </div>
                    <div class="block-fluid">                        
                        
                          
                         <div class="row-form clearfix">
                            <div>Project :</div>
                            <div class="span10">
                                <asp:DropDownList ID="ddlProject" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlProject_SelectedIndexChanged1" AutoPostBack="true">
                                </asp:DropDownList></div>
                        </div>
                    
                      
                         <div class="row-form clearfix">
                            <div>Hydro Main Task:</div>
                            <div class="span10">
                                <asp:DropDownList ID="ddlDefineTask" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlDefineTask_SelectedIndexChanged1"></asp:DropDownList>
                        </div> </div>
                 
                        
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->


            <div class="span8">
                    <div class="head clearfix">
                        <div class="isw-grid"></div>
                        <h1>Task Progress Table</h1>
                    </div>
                    <div class="block-fluid">                        
                        <div style="/*max-height: 400px; */ overflow: scroll">
                             <asp:UpdatePanel ID="update1" runat="server"><ContentTemplate>
                        <asp:GridView ID="GridViewSubTask" runat="server" CellPadding="0" CellSpacing="0" Width="100%" class="table"
                            DataKeyNames="SubTaskID"  AutoGenerateColumns="false" OnRowCancelingEdit="GridViewSubTask_RowCancelingEdit" 
                            OnRowEditing="GridViewSubTask_RowEditing" OnRowUpdating="GridViewSubTask_RowUpdating" 
                            EmptyDataText="No records has been added." AutoGenerateEditButton="true">
                            <Columns>

                                        <asp:TemplateField HeaderText="TaskProgress">
                                            <ItemTemplate>
                                                <%# Eval("TaskProgress")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="tbTaskProgress" Text='<%# Eval("TaskProgress")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Percentage">
                                            <ItemTemplate>
                                                <%# Eval("Percentage")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="tbPercentage" Text='<%# Eval("Percentage")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Remarks">
                                            <ItemTemplate>
                                                <%# Eval("Remarks")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="tbRemarks" Text='<%# Eval("Remarks")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                      
                                        <asp:BoundField DataField="SubTaskID" HeaderText="ID" ReadOnly="true" />

                                    </Columns>
                        </asp:GridView>
                                                           </ContentTemplate></asp:UpdatePanel>

                            </div>
                        
                    </div>  <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>



    </div>                  <!-- Workplace -->  

</asp:Content>
