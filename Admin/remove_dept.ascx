<%@ Control Language="C#" AutoEventWireup="true" CodeFile="remove_dept.ascx.cs" Inherits="admin_remove_dept" %>
<style type="text/css">
    input[type="text"],
	input[type="password"],
	input[type="email"],
	textarea {
		-moz-transition: background-color 0.2s ease-in-out, border-color 0.2s ease-in-out;
		-webkit-transition: background-color 0.2s ease-in-out, border-color 0.2s ease-in-out;
		-ms-transition: background-color 0.2s ease-in-out, border-color 0.2s ease-in-out;
		transition: background-color 0.2s ease-in-out, border-color 0.2s ease-in-out;
		-moz-appearance: none;
		-webkit-appearance: none;
		-ms-appearance: none;
		appearance: none;
		background: none;
		border-radius: 0;
		color: inherit;
		display: block;
		padding: 0.75em;
		text-decoration: none;
		outline: 0;
	}ul.buttons {
		cursor: default;
		list-style: none;
		padding-left: 0;
	}

		ul.buttons:last-child {
			margin-bottom: 0;
		}

		ul.buttons li {
			display: inline-block;
			padding: 0 0 0 1.5em;
		}

			ul.buttons li:first-child {
				padding: 0;
			}

		ul.buttons.stacked li {
			display: block;
			padding: 1.5em 0 0 0;
		}

			ul.buttons.stacked li:first-child {
				padding: 0;
			}
    
    select {
		background-image: url('data:image/svg+xml;charset=utf8,%3Csvg xmlns=\'http://www.w3.org/2000/svg\' width=\'40\' height=\'40\' preserveAspectRatio=\'none\' viewBox=\'0 0 40 40\'%3E%3Cpath d=\'M9.4,12.3l10.4,10.4l10.4-10.4c0.2-0.2,0.5-0.4,0.9-0.4c0.3,0,0.6,0.1,0.9,0.4l3.3,3.3c0.2,0.2,0.4,0.5,0.4,0.9 c0,0.4-0.1,0.6-0.4,0.9L20.7,31.9c-0.2,0.2-0.5,0.4-0.9,0.4c-0.3,0-0.6-0.1-0.9-0.4L4.3,17.3c-0.2-0.2-0.4-0.5-0.4-0.9 c0-0.4,0.1-0.6,0.4-0.9l3.3-3.3c0.2-0.2,0.5-0.4,0.9-0.4S9.1,12.1,9.4,12.3z\' fill=\'%23ffffff\' /%3E%3C/svg%3E');
		background-size: 1.01rem;
		background-repeat: no-repeat;
		height: 1.75rem;
		
		padding-right: 2.75rem;
		text-overflow: ellipsis;
        margin-left: 0px;
    }

		select option {
			
		}

		select:focus::-ms-value {
			background-color: transparent;
		}

		select::-ms-expand {
			display: none;
    .style1
    {
        width: 100%;
    }
    .style2
    {
    }
    .style3
    {
        width: 129px;
    }
    .style5
    {
        height: 26px;
    }
    .style6
    {
        width: 222px;
        height: 26px;
    }
</style>


<center>
<div ng-controller="DemoCtrl" ng-cloak="" class="md-inline-form" ng-app="MyApp" layout="column" layout-sm="row" layout-align="center center" layout-align-sm="start start" layout-fill>
<md-content id="SignupContent" class="md-whiteframe-10dp" flex-sm>
<md-toolbar flex id="materialToolbar">
<div class="md-toolbar-tools"> <span flex=""></span> <span class="md-headline" align="center">Application Form </span> <span flex=""></span> </div>
</md-toolbar>
<div layout-padding="">
						<div></div>




<table class="style1">
    <tr>
        <td class="style3">
            <asp:Label ID="Label2" runat="server" ForeColor="#FF99CC" 
                Text="Remove Department"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            <asp:Label ID="Label1" runat="server" Text="Department ID"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>--select--</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Remove" />
        </td>
    </tr>
    <tr>
        <td class="style2" colspan="2">
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <table class="style1">
                    <tr>
                        <td class="style6">
                            <asp:Label ID="Label3" runat="server" Text="Course"></asp:Label>
                        </td>
                        <td class="style5"><md-input-container flex-gt-sm="">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></md-input-container>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style5">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style5">
                            &nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

<p>
    &nbsp;</p>


