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
<div class="page">
  <div class="container">
    <div class="left">
      <div class="login">Login</div>
      <div class="eula">By logging in you agree to the ridiculously long terms that you didn't bother to read</div>
    </div>
    <div class="right">
      <svg viewBox="0 0 320 300">
        <defs>
          <linearGradient
                          inkscape:collect="always"
                          id="linearGradient"
                          x1="13"
                          y1="193.49992"
                          x2="307"
                          y2="193.49992"
                          gradientUnits="userSpaceOnUse">
            <stop
                  style="stop-color:#ff00ff;"
                  offset="0"
                  id="stop876" />
            <stop
                  style="stop-color:#ff0000;"
                  offset="1"
                  id="stop878" />
          </linearGradient>
        </defs>
        <path d="m 40,120.00016 239.99984,-3.2e-4 c 0,0 24.99263,0.79932 25.00016,35.00016 0.008,34.20084 -25.00016,35 -25.00016,35 h -239.99984 c 0,-0.0205 -25,4.01348 -25,38.5 0,34.48652 25,38.5 25,38.5 h 215 c 0,0 20,-0.99604 20,-25 0,-24.00396 -20,-25 -20,-25 h -190 c 0,0 -20,1.71033 -20,25 0,24.00396 20,25 20,25 h 168.57143" />
      </svg>
      <div class="form">
<table  border="0" cellpadding="2" class="style1" align="center">
    <tr>
        <td>
            &nbsp;<asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        </td>
        <td class="style2">
            
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        </td>
        <td class="style2">
            <asp:TextBox ID="textpass" type="password" runat="server" Width="165px" TextMode="Password" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Reset" 
                Height="27px" />
        </td>
        <td class="style2">
            <asp:Button ID="Button2" runat="server" type="submit" onclick="Button2_Click" Text="Login" 
                style="height: 26px" />
        </td>
    </tr>
</table>


  <div class="page">
  <div class="container">
    <div class="left">
      <div class="login">Login</div>
      <div class="eula">By logging in you agree to the ridiculously long terms that you didn't bother to read</div>
    </div>
    <div class="right">
      <svg viewBox="0 0 320 300">
        <defs>
          <linearGradient
                          inkscape:collect="always"
                          id="linearGradient"
                          x1="13"
                          y1="193.49992"
                          x2="307"
                          y2="193.49992"
                          gradientUnits="userSpaceOnUse">
            <stop
                  style="stop-color:#ff00ff;"
                  offset="0"
                  id="stop876" />
            <stop
                  style="stop-color:#ff0000;"
                  offset="1"
                  id="stop878" />
          </linearGradient>
        </defs>
        <path d="m 40,120.00016 239.99984,-3.2e-4 c 0,0 24.99263,0.79932 25.00016,35.00016 0.008,34.20084 -25.00016,35 -25.00016,35 h -239.99984 c 0,-0.0205 -25,4.01348 -25,38.5 0,34.48652 25,38.5 25,38.5 h 215 c 0,0 20,-0.99604 20,-25 0,-24.00396 -20,-25 -20,-25 h -190 c 0,0 -20,1.71033 -20,25 0,24.00396 20,25 20,25 h 168.57143" />
      </svg>
      <div class="form">
        <label for="email">Email</label>
        <asp:TextBox ID="email"  type="email" 
              runat="server" Width="167px"></asp:TextBox>
        <label for="password">Password</label>
        <input type="password" id="password">
        <input type="submit" id="submit" value="Submit">
      </div>
    </div>
  </div>
</div>


<asp:Label ID="Label3" runat="server" Text="error" Visible="False"></asp:Label>
<asp:Label ID="Label4" runat="server" Text="Admin worked!" Visible="False"></asp:Label>
<asp:Label ID="Label5" runat="server" Text="HOD Worked" Visible="False"></asp:Label>


