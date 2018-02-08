<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deletedData.aspx.cs" Inherits="informationManagement.deletedData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      
        <asp:Label ID="username" runat="server" Font-Bold="True" Font-Size="Larger"></asp:Label>
            <asp:Button ID="logout" runat="server" Text="Log Out" OnClick="logout_Click" UseSubmitBehavior="False" />
                <h2> Show Delete Data</h2>
            
            <asp:GridView ID="delet" runat="server">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/deletedData.aspx?undodelete={0}" DataTextFormatString="{0}" HeaderText="Undo Delete" Text="Undo Delete" />
                </Columns>
                </asp:GridView>
        <asp:Label ID="msg" runat="server" Text=""></asp:Label>
          

      
    </div>
    </form>
</body>
</html>
