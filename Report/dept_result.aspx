<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dept_result.aspx.cs" Inherits="Report_dept_result" %>

<%@ Register src="dep_result.ascx" tagname="dep_result" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:dep_result ID="dep_result1" runat="server" />
    
    </div>
    </form>
</body>
</html>
