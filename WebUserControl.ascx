<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>
<style type="text/css">
    .style1
    {
        width: 68%;
    }
    .style2
    {
        width: 342px;
    }
</style>

<table  border="0" cellpadding="2" class="style1" align="center">
    <tr>
        <td>
            &nbsp;<asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        </td>
        <td class="style2">
        <div class="wrap-input100 validate-input" data-validate = "Valid email is required: ex@abc.xyz">
            <asp:TextBox ID="textuser" runat="server" Width="200px" class="input100" placeholder="Email"></asp:TextBox>
            <span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-envelope" aria-hidden="true"></i>
						</span>
                        </div>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        </td>
        <td class="style2">
        <div class="wrap-input100 validate-input" data-validate = "Password is required">
            <asp:TextBox ID="textpass" runat="server" Width="200px" TextMode="Password" class="input100" placeholder="Password"></asp:TextBox>
            <span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-lock" aria-hidden="true"></i>
						</span>
					</div>
        </td>
    </tr>
    <tr>
        <td>
        <div class="container-login100-form-btn">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Reset" class="login100-form-btn"
                Height="40px" />
                </div>
        </td>
        <td class="style2">
        <div class="container-login100-form-btn">
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" class="login100-form-btn" Text="Login" 
                style="height: 40px" /></div>
        </td>
    </tr>
</table>

<asp:Label ID="Label3" runat="server" Text="error" Visible="False"></asp:Label>
<asp:Label ID="Label4" runat="server" Text="Admin worked!" Visible="False"></asp:Label>
<asp:Label ID="Label5" runat="server" Text="HOD Worked" Visible="False"></asp:Label>


