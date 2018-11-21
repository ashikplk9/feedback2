<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="view_account.aspx.cs" Inherits="Admin_view_account" %>

<%@ Register src="view_account.ascx" tagname="view_account" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:view_account ID="view_account1" runat="server" />
</asp:Content>

