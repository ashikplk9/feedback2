<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="update_account.aspx.cs" Inherits="admin_update_account" %>

<%@ Register src="update_account.ascx" tagname="update_account" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:update_account ID="update_account1" runat="server" />
</asp:Content>

