<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAddDefinedTaks.aspx.cs" Inherits="PedoPM01.DefineTaskForms.frmAddDefinedTaks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
                        
    <div class="breadLine">
        <ul class="breadcrumb">
            <%--<li><a href="#">Project Director</a> <span class="divider">></span></li>--%>
            <li class="active">Add Hydropower Defined Tasks</li>
        </ul>
    </div>
    <%--</div>--%>
    <!-- workplace -->
    <div class="workplace">
        <div class="row-fluid">
            <div class="span12">
                <div class="head clearfix">
                    <div class="isw-documents"></div>
                    <h1>Add Hydropower Defined Tasks</h1>
                </div>
                <div class="block-fluid">

                    <div class="row-form clearfix">
                        <div class="span3">Define Task:</div>
                        <div class="span3">
                            <asp:TextBox ID="tbTaskName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator3" controltovalidate="tbTaskName" errormessage="Please enter task*" ForeColor="Red" />

                        </div>

                    </div>


                    <div class="row-form clearfix">
                        <div class="span3">
                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        </div>
                    </div>

                </div>


            </div>
            <!-- block fluid -->
        </div>
        <!-- span -->
    </div>              <!-- row fluid -->

        <div class="dr"><span></span></div>

</asp:Content>
