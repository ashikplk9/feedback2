<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_sem.ascx.cs" Inherits="Tutor_add_sem" %>
<style type="text/css">
    .style1
    {
        width: 83%;
    }
    .style2
    {
        width: 311px;
    }
    .style3
    {
        width: 311px;
        height: 23px;
    }
    .style4
    {
        height: 23px;
    }
    .style5
    {
        width: 100%;
    }
    .style7
    {
        width: 308px;
    }
    .style8
    {
        width: 311px;
        height: 26px;
    }
    .style9
    {
        height: 26px;
    }
</style>

<p>

<table class="style1">
    <tr>
        <td colspan="2" style="text-align: center">
            Add Details</td>
    </tr>
    <tr>
        <td class="style2">
            Department Id</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Branch Id</td>
        <td class="style9">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>--select--</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Course</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Sem no</td>
        <td class="style4">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
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
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Add Subjects" />
        </td>
    </tr>
</table>
    <br />
</p>

<asp:Panel ID="Panel1" runat="server" Height="106px" Visible="False" 
    Width="870px">
    <table class="style5">
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                Subject Code</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Subject</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Save" />
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Submit" />
            </td>
        </tr>
    </table>
</asp:Panel>

