<%@ Control Language="C#" AutoEventWireup="true" CodeFile="feedback.ascx.cs" Inherits="Tutor_feedback" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
    }
    .style3
    {
        width: 241px;
        height: 26px;
    }
    .style4
    {
        height: 26px;
    }
    .style5
    {
        width: 241px;
        height: 23px;
    }
    .style6
    {
        height: 23px;
    }
    .style7
    {
        width: 236px;
    }
    .style8
    {
        width: 236px;
        height: 26px;
    }
    .style9
    {
        width: 236px;
        height: 34px;
    }
    .style10
    {
        height: 34px;
    }
</style>

<table class="style1">
    <tr>
        <td class="style2">
            Department ID</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>--select--</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Course</td>
        <td class="style4">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Branch</td>
        <td class="style4">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Semester</td>
        <td class="style6">
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" >
                <asp:ListItem>--select--</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Month&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp;</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Year</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp;<asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="OK" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2" colspan="2">
            <asp:Panel ID="Panel1" runat="server" Height="169px" Visible="False">
                <table class="style1">
                    <tr>
                        <td class="style7">
                            Subject</td>
                        <td>
                            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                                <asp:ListItem>--select--</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                            Subject code</td>
                        <td class="style4">
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                            Teacher</td>
                        <td class="style4">
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style9">
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Done" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                                style="height: 26px" Text="Delete" />
                        </td>
                        <td class="style10">
                            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                                Text="Student" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        <td class="style6">
            &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

