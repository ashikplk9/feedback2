<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="add_course.aspx.cs" Inherits="admin_add_course" %>

<%@ Register src="add_course.ascx" tagname="add_course" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:add_course ID="add_course1" runat="server" />
</asp:Content>

