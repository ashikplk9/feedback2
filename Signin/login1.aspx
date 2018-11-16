<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login1.aspx.cs" Inherits="login1" %>

<%@ Register src="WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 148px">
    
        <uc1:WebUserControl ID="WebUserControl1" runat="server" />
    
    </div>
    </form>
     <script src='https://cdnjs.cloudflare.com/ajax/libs/animejs/2.2.0/anime.min.js'></script>

    <script  src="js/index.js"></script>
</body>
</html>
