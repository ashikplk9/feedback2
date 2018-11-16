<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/MasterPage.master" AutoEventWireup="true" CodeFile="Mapping.aspx.cs" Inherits="HOD_Mapping" %>

<%@ Register src="mapping.ascx" tagname="mapping" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:mapping ID="mapping1" runat="server" />
</asp:Content>

