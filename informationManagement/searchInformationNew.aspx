<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchInformationNew.aspx.cs" Inherits="informationManagement.searchInformationNew" %>

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
                    <td>Gender</td>
                    <td>

                        <asp:DropDownList ID="gender" runat="server">
                            <asp:ListItem Value="0">Select Gender</asp:ListItem>
                            <asp:ListItem Value="1">Male</asp:ListItem>
                            <asp:ListItem Value="2">Female</asp:ListItem>
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td>Department</td>
                    <td>

                        <asp:DropDownList ID="department" runat="server">
                            <asp:ListItem Value="0">Select Department</asp:ListItem>
                            <asp:ListItem Value="1">Science</asp:ListItem>
                            <asp:ListItem Value="2">Commerce</asp:ListItem>
                            <asp:ListItem Value="3">Arts</asp:ListItem>
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
                        <asp:DropDownList ID="bloodGroupChecked" AutoPostBack="true" runat="server" OnSelectedIndexChanged="bloodGroupChecked_CheckedChanged" >
                            <asp:ListItem Value="Select">Select Tested</asp:ListItem>
                            <asp:ListItem Value="1">Yes</asp:ListItem>
                            <asp:ListItem Value="0">No</asp:ListItem>
                        </asp:DropDownList> &nbsp;|
                        <%--<asp:CheckBox ID="bloodGroupChecked" runat="server" Text="Tested" AutoPostBack="true" OnCheckedChanged="bloodGroupChecked_CheckedChanged"/>--%>
                        <asp:DropDownList ID="paymentType" runat="server" Enabled="false">
                            <asp:ListItem Value="Select">Select Payment</asp:ListItem>
                            <asp:ListItem Value="0">Due</asp:ListItem>
                            <asp:ListItem Value="1">Paid</asp:ListItem>
                        </asp:DropDownList>
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
                    <td>Verified</td>
                    <td>
                        <asp:DropDownList ID="verified" runat="server">
                            <asp:ListItem Value="Select">Select</asp:ListItem>
                            <asp:ListItem Value="0">Not Verified</asp:ListItem>
                            <asp:ListItem Value="1">Verified </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Present Status
                    </td>
                    <td>
                        <asp:DropDownList ID="presentstatus" runat="server">
                            <asp:ListItem Value="0">Select Present Status</asp:ListItem>
                            <asp:ListItem Value="Unknown">Unknown</asp:ListItem>
                            <asp:ListItem Value="1">Printing</asp:ListItem>
                            <asp:ListItem Value="2">Printed</asp:ListItem>
                            <asp:ListItem Value="3">Handed Over</asp:ListItem>
                            <asp:ListItem Value="4">Re-Print Needed</asp:ListItem>
                            <asp:ListItem Value="6">Lost</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                
                </tr>
                <tr>
                    <td>Order By</td>
                    <td>
                        <asp:DropDownList ID="orderBy" runat="server">
                            <asp:ListItem Value="Select">Select Order By</asp:ListItem>
                            <asp:ListItem Value="Id">Id</asp:ListItem>
                            <asp:ListItem Value="Name">Name</asp:ListItem>
                            <asp:ListItem Value="Roll">Roll</asp:ListItem>
                            <asp:ListItem Value="Class">Class</asp:ListItem>
                            <asp:ListItem Value="Roll, Name">Roll, Name</asp:ListItem>
                            <asp:ListItem Value="Class, Roll">Class, Roll</asp:ListItem>
                            <asp:ListItem Value="Shift, Class, Roll">Shift, Class, Roll</asp:ListItem>
                            <asp:ListItem Value="Department">Department</asp:ListItem>
                            <asp:ListItem Value="Gender">Gender</asp:ListItem>
                            <asp:ListItem Value="Created_By">Created By</asp:ListItem>
                            <asp:ListItem Value="Updated_By">Updated By</asp:ListItem>
                            <asp:ListItem Value="Created_Date">Created Date</asp:ListItem>
                            <asp:ListItem Value="Updated_Date">Updated Date</asp:ListItem>
                        </asp:DropDownList>	
                    </td>
                </tr>
                <tr>
                    <td>Show Data</td>
                    <td>
                        <asp:CheckBox ID="withTableData" AutoPostBack="true" OnCheckedChanged="withTableData_CheckedChanged" runat="server" Text="Show With Data" Font-Bold="true" ForeColor="Red" />
                        <asp:CheckBox ID="withTableDataNImage" AutoPostBack="true" OnCheckedChanged="withTableDataNImage_CheckedChanged" runat="server" Text="Show With Data & Image" Font-Bold="true" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>

                        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="searchButton1_Click" />
                        <asp:Button ID="download" runat="server" Text="Download" OnClick="download_Click" Enabled="false"/>
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
                      <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/showDetails.aspx?id={0}" DataTextFormatString="{0}" HeaderText="View" Text="View" />
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/informationPage.aspx?id={0}" DataTextField="" DataTextFormatString="{0}" HeaderText="Edit" Text="Edit"/>
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/informationPage.aspx?deleteID={0}" DataTextField="" DataTextFormatString="{0}" HeaderText="Delete" Text="Delete"/>
                    
                    <asp:ImageField DataImageUrlField="ID" DataImageUrlFormatString="http://salahuddinahmedhighschool.com/student_images/{0}.jpg" HeaderText="Image" DataAlternateTextField="ID" DataAlternateTextFormatString="N/A">
                          <ControlStyle Height="70px" />
                      </asp:ImageField>
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
