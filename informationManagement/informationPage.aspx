<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="informationPage.aspx.cs" Inherits="informationManagement.informationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr> <td>  <asp:Label ID="username" runat="server" ></asp:Label>  </td>
            <td>
                <asp:Button ID="logout" runat="server" Text="Log Out" OnClick="logout_Click" />

            </td>
        </tr>

        <tr><td> <h2>Information Page</h2></td></tr>
         <tr>
            <td>Class </td>
           <td>
                           
                <span style="color:red">*</span>
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
            <td>Name</td>
             
           <td>           
                 <span style="color:red">*</span>

               <asp:TextBox ID="name" runat="server"></asp:TextBox>

           </td>

        </tr>
         <tr>
            <td>Gender</td>
             
           <td>
                            <span style="color:red">*</span>

               <asp:DropDownList ID="gender" runat="server">
                   <asp:ListItem Value="0">Select Gender</asp:ListItem>
                   <asp:ListItem Value="1">Male</asp:ListItem>
                   <asp:ListItem Value="2">Female</asp:ListItem>
               </asp:DropDownList>
           </td>

        </tr>
         <tr>
            <td>Roll</td>
             
           <td>
                            <span style="color:red">*</span>

               <asp:TextBox ID="roll" runat="server"></asp:TextBox>

           </td>

        </tr>
         <tr>
            <td>Shift</td>
             
           <td>
                            <span style="color:red">*</span>

               <asp:DropDownList ID="shift" runat="server">
                   <asp:ListItem Value="0">Select Shift</asp:ListItem>
                   <asp:ListItem Value="1">Morning</asp:ListItem>
                   <asp:ListItem Value="2">Day</asp:ListItem>
               </asp:DropDownList>

           </td>

        </tr>
         <tr>
            <td>Nationality</td>
             
           <td>
                            <span style="color:red">*</span>

               <asp:TextBox ID="national" runat="server" Text="Bangladeshi"></asp:TextBox>
           </td>

        </tr>
          <tr>
            <td>Office Phone</td>
             
           <td>             <span style="color:red">*</span>

               <asp:TextBox ID="officephone" runat="server"></asp:TextBox>

           </td>

        </tr>
          <tr>
            <td>Title</td>
             
           <td>             <span style="color:red">*</span>

               <asp:DropDownList ID="title" runat="server">
                   <asp:ListItem Value="0">Select Title</asp:ListItem>
                   <asp:ListItem Value="1">Teacher</asp:ListItem>
                   <asp:ListItem Value="2">Student</asp:ListItem>
               </asp:DropDownList>

           </td>

        </tr>
          <tr>
            <td>Date Of Birth</td>
             
           <td>             <span style="color:red">*</span>

               <asp:TextBox ID="dob" runat="server"></asp:TextBox>

          
              
                  <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" ImageUrl="~/Calendar.png" Width="16px" OnClick="ImageButton1_Click" />

               </td>
              </tr>
        <tr>
              <td></td>
              <td>
                  <asp:Calendar ID="Calendar1" runat="server" Visible ="false" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
              </td>

        </tr>
          <tr>
            <td>Date Of Employment</td>
             <td>             <span style="color:red">*</span>

                 <asp:TextBox ID="doe" runat="server"></asp:TextBox>
           
               <asp:ImageButton ID="ImageButton2" runat="server" Height="30px" ImageUrl="~/Calendar.png" Width="16px" OnClick="ImageButton2_Click" />

           </td>
               </tr>
             <tr>
                 <td></td>
                 <td>
                     <asp:Calendar ID="Calendar2" runat="server" Visible ="false" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
                 </td>
             </tr>
        <tr>
            <td>Mobile Number</td>
            <td>
                <asp:TextBox ID="mobile" runat="server"></asp:TextBox>

            </td>
        </tr>
         <tr>
            <td>Home address</td>
            <td>

                <asp:TextBox ID="homeaddress" runat="server"></asp:TextBox>

            </td>
        </tr>
          <tr>
             <td></td>
             <td>
                 <asp:Button ID="Button1" runat="server" Text="Save" OnClick="SaveButton1_Click" />
                 <asp:Button ID="Button2" runat="server" Text="Update" Visible="false"/>
                 <asp:Button ID="Button3" runat="server" Text="Reset" OnClick="resetButton3_Click" />
                 <%--<asp:Button ID="Button4" runat="server" Text="Search" OnClick="searchButton4_Click" />--%>

            </td>
        </tr>
        <tr>
            <td>

            </td>
        </tr>

       
        
    </table>
                <asp:Label ID="msg" runat="server" Text=""></asp:Label><br><br>
                 <a href="searchInformation.aspx">Search Information</a>

    </div>
    </form>
</body>
</html>
