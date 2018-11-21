<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="view_department.aspx.cs" Inherits="Admin_view_department" %>

<%@ Register src="view_department.ascx" tagname="view_department" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:view_department ID="view_department1" runat="server" />
</asp:Content>

