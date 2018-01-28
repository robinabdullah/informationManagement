<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="entryCount.aspx.cs" Inherits="informationManagement.entryCount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Entry Count Per User</h2>
        <asp:GridView ID="count" runat="server"></asp:GridView>
        <h2>Entry Count Per Class</h2>
        <asp:GridView ID="classWiseCount" runat="server"></asp:GridView>
         <h2>Entry Count Per Title</h2>
        <asp:GridView ID="titleWiseCount" runat="server"></asp:GridView>
        <br>
        <a href="informationPage.aspx">Back To Infomation Page</a>
    </div>
    </form>
</body>
</html>
