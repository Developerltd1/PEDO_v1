<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmRevisedHydroWorkPlan.aspx.cs" Inherits="PedoPM01.DefineTaskForms.frmRevisedHydroWorkPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <%--<div style="margin-top:-40px">--%>    
             <!-- Breadline -->
             <div class="breadLine">
                     <ul class="breadcrumb">                <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>                
                        <li class="active">Revised Hydro Project Work Plan</li>
                    </ul>
            </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                    <div class="head clearfix">
                        <div class="isw-documents"></div>
                        <h1>Revised Hydro Project Work Plan</h1>
                    </div>
              <div class="block-fluid">
                          
                 <div class="row-form clearfix">

                                             
                            <div class="span4">Project:<asp:DropDownList ID="ddlProject" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlProject_SelectedIndexChanged">
                                               </asp:DropDownList></div>
                            <div class="span4">Project Start Date:<asp:TextBox ID="tbProjectStartDate" runat="server" ReadOnly="true" ForeColor="Red"  AutoCompleteType="Disabled"></asp:TextBox>(dd/MM/yy)</div>
                            <div class="span4">Project End Date:<asp:TextBox ID="tbProjectEndDate" runat="server" ReadOnly="true" ForeColor="Red"  AutoCompleteType="Disabled"></asp:TextBox>(dd/MM/yy) </div>                            
                       
                </div>
                
                 <div class="row-form clearfix">

                         <div class="row-form clearfix">
                            <div class="span3">Hydro Work Plan:</div>
                            <div class="span3"><asp:DropDownList ID="ddlHydro" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlHydro_SelectedIndexChanged">
                                               </asp:DropDownList></div>
                        </div>

                         <div class="row-form clearfix" id="divStartDate" runat="server">
                             <div class="span3">Start Date:</div>
                             <div class="span3">
                                 <asp:TextBox ID="tbStartDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_StartDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbStartDate" />
                             </div>
                         </div>

                         <div class="row-form clearfix" id="divFinishDate" runat="server">
                             <div class="span3">Finish Date:</div>
                             <div class="span3">
                                 <asp:TextBox ID="tbDeadline" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="CalendarExtender_DeadlineDate" runat="server"  Format="dd/MM/yyyy" TargetControlID="tbDeadline" />
                             </div></div>
                         <div class="row-form clearfix" id="divDesignDate" runat="server">
                             <div class="span3">Design Date:</div>
                             <div class="span3">
                                <asp:TextBox ID="tbDesignDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_DesignDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbDesignDate" />
                             </div></div>
            <div class="row-form clearfix" id="divDesignFinishDate" runat="server">
                             <div class="span3">Design Finish Date:</div>
                             <div class="span3">
                                 <asp:TextBox ID="tbDesignFinishDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_DesignFinishDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbDesignFinishDate" />
                                 </div></div>
      
                         <div class="row-form clearfix" id="divConstructDate" runat="server">
                             <div class="span3">Construct Date:</div>
                             <div class="span3">
                                  <asp:TextBox ID="tbConstructDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_ContructDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbConstructDate" />
                                 </div></div>
       
                         <div class="row-form clearfix" id="divConstructFinsihDate" runat="server">
                             <div class="span3">Construct Finish Date:</div>
                             <div class="span3">
                                  <asp:TextBox ID="tbConstructFinsihDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_ContructFinsihDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbConstructFinsihDate" />
                                 </div></div>

                         
                         
                         <div class="row-form clearfix" id="divOrderDate" runat="server">
                             <div class="span3">Ordering Date:</div>
                             <div class="span3">
                                 <asp:TextBox ID="tbOrderDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" TargetControlID="tbOrderDate" />
                                 </div></div>

                         <div class="row-form clearfix" id="divOrderFinishDate" runat="server">
                             <div class="span3">Ordering Finish Date:</div>
                             <div class="span3">
                                 <asp:TextBox ID="tbOrderFinishDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender1Finsih" runat="server" Format="dd/MM/yyyy" TargetControlID="tbOrderFinishDate" />
                                 </div></div>
       
                         <div class="row-form clearfix" id="divShipmentDate" runat="server">
                             <div class="span3">Shipment Date:</div>
                             <div class="span3">
                                 <asp:TextBox ID="tbShipmentDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd/MM/yyyy" TargetControlID="tbShipmentDate" />
                                 </div></div>
       
                          <div class="row-form clearfix" id="divShipmentFinishDate" runat="server">
                             <div class="span3">Shipment Finish Date:</div>
                             <div class="span3">
                                 <asp:TextBox ID="tbShipmentFinishDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender2Finish" runat="server" Format="dd/MM/yyyy" TargetControlID="tbShipmentFinishDate" />
                                 </div></div>
       <div class="row-form clearfix" id="divInstallationDate" runat="server">
                             <div class="span3">Installation Date:</div>
                             <div class="span3">
                                 <asp:TextBox ID="tbInstallationDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender3" runat="server" Format="dd/MM/yyyy" TargetControlID="tbInstallationDate" />
       </div></div>
        
                          <div class="row-form clearfix" id="divInstallationFinishDate" runat="server">
                             <div class="span3">Installation Finish Date:</div>
                             <div class="span3">
                                 <asp:TextBox ID="tbInstallationFinishDate" runat="server"  AutoCompleteType="Disabled"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender3Finsih" runat="server" Format="dd/MM/yyyy" TargetControlID="tbInstallationFinishDate" />
                                 </div></div>

                         <div class="row-form clearfix" id="divRemarks" runat="server">
                             <div class="span3">Remarks:</div>
                             <div class="span3">
       <asp:TextBox ID="tbRemarks" runat="server" TextMode="MultiLine"></asp:TextBox>
                                 </div></div>

       
                                     
                        <div class="row-form clearfix">
                            <div class="span3"></div>
                            <div class="span3">
                            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn" /></div>
                        </div>


                                 
                                         </div>  
             </div>           <!-- block fluid -->
                </div>      <!-- span -->
        </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>

    </div>              <!-- Workplace -->

    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                <div class="head clearfix">
                    <div class="isw-grid"></div>
                    <h1>Hydro Table</h1>
                </div>
                <div class="block-fluid">
                    <div style="/*max-height:400px;*/ overflow:scroll">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>

                    <asp:GridView ID="GridView2" runat="server" CellPadding="0" DataKeyNames="ID" CellSpacing="0" Width="100%" class="table" AutoGenerateColumns="false"
                         OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing"
                        OnRowUpdating="GridView1_RowUpdating" EmptyDataText="No records has been added." AutoGenerateEditButton="true" >
                        <Columns>
                           
                            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="true" />
                            <asp:TemplateField HeaderText="Task">
                                <ItemTemplate>
                                    <%# Eval("TaskName")%>
                                </ItemTemplate>
                                <%--<EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbTaskName" Text='<%# Eval("TaskName")%>' />
                                </EditItemTemplate>--%>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Start Date">
                                <ItemTemplate>
                                    <%# Eval("StartDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="StartDate"   Text='<%# Eval("StartDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_StartDate" runat="server" Format="dd/MM/yyyy" TargetControlID="StartDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Deadline Date">
                                <ItemTemplate>
                                    <%# Eval("DeadlineDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbDeadline" Text='<%# Eval("DeadlineDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_DeadlineDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbDeadline" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Design Date">
                                <ItemTemplate>
                                    <%# Eval("DesignDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbDesignDate" Text='<%# Eval("DesignDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_DesignDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbDesignDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="DesignFinish Date">
                                <ItemTemplate>
                                    <%# Eval("DesignFinishDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbDesignFinishDate" Text='<%# Eval("DesignFinishDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_DesignFinishDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbDesignFinishDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Construct Date">
                                <ItemTemplate>
                                    <%# Eval("ConstructDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbConstructDate" Text='<%# Eval("ConstructDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_ConstructDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbConstructDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="ConstructFinish Date">
                                <ItemTemplate>
                                    <%# Eval("ConstructFinishDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbConstructFinishDate" Text='<%# Eval("ConstructFinishDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_ConstructFinishDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbConstructFinishDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Ordering Date">
                                <ItemTemplate>
                                    <%# Eval("OrderingDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbOrderingDate" Text='<%# Eval("OrderingDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_OrderingDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbOrderingDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="OrderingFinish Date">
                                <ItemTemplate>
                                    <%# Eval("OrderingFinishDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbOrderingFinishDate" Text='<%# Eval("OrderingFinishDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_OrderingFinishDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbOrderingFinishDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Shipment Date">
                                <ItemTemplate>
                                    <%# Eval("ShipmentDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbShipmentDate" Text='<%# Eval("ShipmentDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_ShipmentDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbShipmentDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="ShipmentFinish Date">
                                <ItemTemplate>
                                    <%# Eval("ShipmentFinishDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbShipmentFinishDate" Text='<%# Eval("ShipmentFinishDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_ShipmentFinishDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbShipmentFinishDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField HeaderText="Installation Date">
                                <ItemTemplate>
                                    <%# Eval("InstallationDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbInstallationDate" Text='<%# Eval("InstallationDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_InstallationDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbInstallationDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField HeaderText="InstallationFinish Date">
                                <ItemTemplate>
                                    <%# Eval("InstallationFinishDate")%>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="tbInstallationFinishDate" Text='<%# Eval("InstallationFinishDate")%>' />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender_InstallationFinishDate" runat="server" Format="dd/MM/yyyy" TargetControlID="tbInstallationFinishDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                            </ContentTemplate></asp:UpdatePanel>
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
