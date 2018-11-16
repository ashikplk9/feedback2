<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="adminhome.aspx.cs" Inherits="admin_adminhome" %>

<%@ Register src="adminhome.ascx" tagname="adminhome" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:adminhome ID="adminhome1" runat="server" />
</asp:Content>

