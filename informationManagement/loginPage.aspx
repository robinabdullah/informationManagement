<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="informationManagement.loginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr> <h2>Login</h2></tr>
       
        <tr>
            <td>User Name</td>
             
           <td> <asp:TextBox ID="name" runat="server"></asp:TextBox></td>

        </tr>
         <tr>
            <td>Password</td>
             
           <td> <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></td>

        </tr>
         <tr>
            <td></td>
             
           <td> <asp:Button ID="Button1" runat="server" Text="Login" OnClick="LoginButton1_Click" /></td>

        </tr>
        <tr><td>
            <asp:Label ID="msg" runat="server" Text=""></asp:Label></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
