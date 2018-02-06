<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deletedData.aspx.cs" Inherits="informationManagement.deletedData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="deletedList" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:POSNew12ConnectionString %>" SelectCommand="SELECT [Id], [Class], [Name], [Section], [Department], [Gender], [Roll], [Shift], [DateOfBirth], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Deleted_By], [Deleted_Date], [Image_Provided], [Form_Filled], [Blood_Group], [Blood_Group_Checked], [Is_Paid], [Is_Deleted] FROM [Information] WHERE ([Is_Deleted] &lt;&gt; @Is_Deleted)">
            <SelectParameters>
                <asp:Parameter DefaultValue="false" Name="Is_Deleted" Type="boolean" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
