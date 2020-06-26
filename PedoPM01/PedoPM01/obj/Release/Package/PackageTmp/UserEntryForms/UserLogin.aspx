<%@ Page Title="" Language="C#" MasterPageFile="~/UserEntryForms/UserEntryMaster.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="PedoPM01.UserEntryForms.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentUser_MainBody" runat="server">



   
    <!--New Login-->
    <div class="limiter">
        
		<div class="container-login100" style="background-image: url('../ContentUserEntry2/images/img-01OK.jpg');">
			<div class="wrap-login100 p-t-80 p-b-30">
				<form class="login100-form validate-form" runat="server"> 
					<div class="login100-form-avatar">
						<img src="../ContentUserEntry2/images/avatar-01 copy.jpg" alt="AVATAR" />
					</div>

					<div class="wrap-input100 validate-input m-b-10" data-validate = "Username is required">
                         <asp:TextBox ID="tbUserName" runat="server" class="input100" placeholder="User Name"/>
						
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-user"></i>
						</span>
					</div>

					<div class="wrap-input100 validate-input m-b-10" data-validate = "Password is required">
                        <asp:TextBox ID="tbPassword" type="password" runat="server" class="input100" placeholder="Password"/>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-lock"></i>
						</span>
					</div>

					<div class="container-login100-form-btn p-t-10">
			                 <asp:Button ID="btnsubmit" runat="server" class="login100-form-btn" Text="Login" OnClick="btnsubmit_Click" />                                                         
            		</div>
                    <div style="color:white; margin-top:100px; margin-left:100px">Powered by <img src="../img/cfp_logo.png" /></div>
                    
				</form>   
			</div>
		</div>
	</div>
      <!--	</form>   -->
	


    <!--Old Login-->
      


</asp:Content>
