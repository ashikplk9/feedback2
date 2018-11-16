<%@ Page Language="C#" AutoEventWireup="true" CodeFile="report.aspx.cs" Inherits="Report_report" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 496px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
                Department ID</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Course</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Sem</td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Subject</td>
            <td>
                <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList4_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Teacher</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Report" onclick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Mail Report" />
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
