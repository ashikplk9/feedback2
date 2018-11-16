<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Remove_course.aspx.cs" Inherits="admin_Remove_course" %>

<%@ Register src="Remove_course.ascx" tagname="Remove_course" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:Remove_course ID="Remove_course1" runat="server" />
</asp:Content>

