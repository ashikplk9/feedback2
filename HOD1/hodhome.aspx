<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/MasterPage.master" AutoEventWireup="true" CodeFile="hodhome.aspx.cs" Inherits="HOD_hodhome" %>

<%@ Register src="hodhome.ascx" tagname="hodhome" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:hodhome ID="hodhome1" runat="server" />
</asp:Content>

