<%@ Page Title="" Language="C#" MasterPageFile="~/tutor/MasterPage.master" AutoEventWireup="true" CodeFile="tutorhome.aspx.cs" Inherits="tutor_tutorhome" %>

<%@ Register src="tutorhomel.ascx" tagname="tutorhomel" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:tutorhomel ID="tutorhomel1" runat="server" />
</asp:Content>

