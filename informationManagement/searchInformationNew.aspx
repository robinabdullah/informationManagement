﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchInformationNew.aspx.cs" Inherits="informationManagement.searchInformationNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="username" runat="server" Font-Bold="True" Font-Size="Larger"></asp:Label>
            <asp:Button ID="logout" runat="server" Text="Log Out" OnClick="logout_Click" />
            <table>
                <tr>
                    <td>
                        <h2>Search Infomation</h2>
                    </td>
                </tr>
                <tr>
                    <td>ID</td>
                    <td>
                        <asp:TextBox ID="id" runat="server" TextMode="Number"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Personal Number</td>
                    <td>
                        <asp:TextBox ID="officeNumber" runat="server" TextMode="Number"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Guardian Number</td>
                    <td>
                        <asp:TextBox ID="mobile" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Class</td>

                    <td>
                        <asp:DropDownList ID="clas" runat="server">
                            <asp:ListItem Value="0">Select Class</asp:ListItem>
                            <asp:ListItem Value="1">KG</asp:ListItem>
                            <asp:ListItem Value="2">Class 10</asp:ListItem>
                            <asp:ListItem Value="3">Class 9</asp:ListItem>
                            <asp:ListItem Value="4">Class 8</asp:ListItem>
                            <asp:ListItem Value="5">Class 7</asp:ListItem>
                            <asp:ListItem Value="6">Class 6</asp:ListItem>
                            <asp:ListItem Value="7">Class 5</asp:ListItem>
                            <asp:ListItem Value="8">Class 4</asp:ListItem>
                            <asp:ListItem Value="9">Class 3</asp:ListItem>
                            <asp:ListItem Value="10">Class 2</asp:ListItem>
                            <asp:ListItem Value="11">Class 1</asp:ListItem>
                        </asp:DropDownList>

                    </td>

                </tr>
                <tr>
                    <td>Shift</td>

                    <td>
                        <asp:DropDownList ID="shift" runat="server">
                            <asp:ListItem Value="0">Select Shift</asp:ListItem>
                            <asp:ListItem Value="1">Morning</asp:ListItem>
                            <asp:ListItem Value="2">Day</asp:ListItem>
                        </asp:DropDownList>

                    </td>

                </tr>
                <tr>
                    <td>Title</td>
                    <td>

                        <asp:DropDownList ID="title" runat="server">
                            <asp:ListItem Value="0">Select Title</asp:ListItem>
                            <asp:ListItem Value="1">Teacher</asp:ListItem>
                            <asp:ListItem Value="2">Student</asp:ListItem>
                            <asp:ListItem Value="3">Committee</asp:ListItem>
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td>Blood Group</td>
                    <td>

                        <asp:DropDownList ID="bloodGroup" runat="server">
                    <asp:ListItem>Select Blood Group</asp:ListItem>
                    <asp:ListItem>N/A</asp:ListItem>
                    <asp:ListItem>AB+</asp:ListItem>
                    <asp:ListItem>AB-</asp:ListItem>
                    <asp:ListItem>A+</asp:ListItem>
                    <asp:ListItem>A-</asp:ListItem>
                    <asp:ListItem>B+</asp:ListItem>
                    <asp:ListItem>B-</asp:ListItem>
                    <asp:ListItem>O+</asp:ListItem>
                    <asp:ListItem>O-</asp:ListItem>
                </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td>Blood Group Tested</td>
                    <td>
                        
                        <asp:CheckBox ID="bloodGroupChecked" runat="server" Text="Tested" />

                    </td>
                </tr>
                <tr>
                    <td>Image Provided</td>
                    <td>
                        <asp:CheckBox ID="imageProvided" runat="server" Text="Image" />
                    </td>
                </tr>
                <tr>
                    <td>Form Filled</td>
                    <td>
                        <asp:CheckBox ID="formFilled" runat="server" Text="Form"  />
                    </td>
                </tr>
                <tr>
                    <td>Show Data</td>
                    <td>
                        <asp:CheckBox ID="withTableData" runat="server" Text="Show With Data" Font-Bold="true" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>

                        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="searchButton1_Click" />
                        <asp:Button ID="reset" runat="server" Text="Reset" OnClick="reset_Click" />
                        <a href="informationPage.aspx">Back</a> | <a href="searchInformation.aspx">Old Search Panel</a>
                    </td>

                </tr>

                <tr>
                    <td>
                        <asp:Label ID="msg" runat="server" Font-Bold="True"></asp:Label>

                    </td>

                </tr>

            </table>
            <asp:GridView ID="list" runat="server">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/informationPage.aspx?id={0}" DataTextField="ID" DataTextFormatString="{0}" HeaderText="Edit" />
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
