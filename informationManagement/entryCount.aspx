<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="entryCount.aspx.cs" Inherits="informationManagement.entryCount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-right: 1023px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <a href="informationPage.aspx" style="display:block">Back To Infomation Page</a>
        <h2>Entry Count</h2>
    <div style="display:inline-table;margin-right:30px">
        <h2>Per User</h2>
        <asp:GridView ID="count" runat="server"></asp:GridView>
    </div>
    <div style="display:inline-table;margin-right:30px">
         <h2>Per Title</h2>
        <asp:GridView ID="titleWiseCount" runat="server"></asp:GridView>
    </div>
    <div style="display:inline-table;margin-right:30px">
        <h2>Per Shift</h2>
        <asp:GridView ID="shiftWiseCount" runat="server"></asp:GridView>
    </div>
    <div style="display:inline-table;margin-right:30px">
        <h2>Per Class</h2>
        <asp:GridView ID="classWiseCount" runat="server"></asp:GridView>
    </div>
    <div style="display:inline-table;margin-right:30px">
        <h2>Per Blood Group</h2>
        <asp:GridView ID="bloodGroupCount" runat="server"></asp:GridView>
    </div>
    <div style="display:inline-table;margin-right:30px">
        <h2>Blood Report Summary</h2>
        <asp:GridView ID="bloodGroupSummary" runat="server"></asp:GridView>
    </div>
         <div style="display:inline-table;margin-right:30px">
        <h2>Present_Status</h2>
        <asp:GridView ID="presentstatus" runat="server"></asp:GridView>
    </div>
         <div style="display:inline-table;margin-right:30px">
        <h2>Is_Verified</h2>
        <asp:GridView ID="varified" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
