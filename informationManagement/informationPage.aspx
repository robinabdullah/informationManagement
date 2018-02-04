<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="informationPage.aspx.cs" Inherits="informationManagement.informationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 51px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField ID="id" runat="server" />
    <table>
        <tr> <td>  <asp:Label ID="username" runat="server" Font-Bold="True" Font-Size="Larger" ></asp:Label>  </td>
            <td>
                <asp:Button ID="logout" runat="server" Text="Log Out" OnClick="logout_Click" />

            </td>
        </tr>

        <tr><td> <h2>Information Page</h2></td></tr>
          <tr>
            <td>Name<span style="color:red">*</span></td>
             
           <td>           
               

               <asp:TextBox ID="name" runat="server"></asp:TextBox>

           </td>

        </tr>
          <tr>
            <td>Class<span style="color:red">*</span> </td>
           <td>
                           
              
               <asp:DropDownList ID="clas" runat="server" AutoPostBack="True" OnSelectedIndexChanged="clas_SelectedIndexChanged">
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
            <td>Section<span style="color:red">*</span></td>
             
           <td>

               <asp:DropDownList ID="section" runat="server">
                   <asp:ListItem Value="0">Select Section</asp:ListItem>
                   <asp:ListItem Value="1">A</asp:ListItem>
                   <asp:ListItem Value="2">B</asp:ListItem>
                   <asp:ListItem Value="3">C</asp:ListItem>
                   <asp:ListItem Value="4">D</asp:ListItem>
               </asp:DropDownList>
             

           </td>

        </tr>
          <tr>
            <td> <asp:Label Text="Department" ID="departmentLabel" runat="server" />  </td>
             
           <td>

               <asp:DropDownList ID="department" runat="server">
                   <asp:ListItem Value="0">Select Department</asp:ListItem>
                   <asp:ListItem Value="1">Science</asp:ListItem>
                   <asp:ListItem Value="2">Arts</asp:ListItem>
                   <asp:ListItem Value="3">Commerce</asp:ListItem>
               
               </asp:DropDownList>
             

           </td>

        </tr>
       
         <tr>
            <td>Gender   <span style="color:red">*</span></td>
             
           <td>
                         

               <asp:DropDownList ID="gender" runat="server">
                   <asp:ListItem Value="0">Select Gender</asp:ListItem>
                   <asp:ListItem Value="1">Male</asp:ListItem>
                   <asp:ListItem Value="2">Female</asp:ListItem>
               </asp:DropDownList>
           </td>

        </tr>
         <tr>
            <td>Roll  <span style="color:red">*</span></td>
             
           <td>
                          

               <asp:TextBox ID="roll" runat="server" TextMode="Number"></asp:TextBox>

           </td>

        </tr>
         <tr>
            <td>Shift   <span style="color:red">*</span></td>
             
           <td>
                         

               <asp:DropDownList ID="shift" runat="server">
                   <asp:ListItem Value="0">Select Shift</asp:ListItem>
                   <asp:ListItem Value="1">Morning</asp:ListItem>
                   <asp:ListItem Value="2">Day</asp:ListItem>
               </asp:DropDownList>

           </td>

        </tr>
         <tr>
            <td>Nationality   <span style="color:red">*</span></td>
             
           <td>
                        
               <asp:TextBox ID="national" runat="server" Text="Bangladeshi"></asp:TextBox>
           </td>

        </tr>
          <tr>
            <td>Personal Number    <span style="color:red">*</span></td>
             
           <td>         

               <asp:TextBox ID="officephone" runat="server" TextMode="Number"></asp:TextBox>

           </td>

        </tr>
          <tr>
            <td>Title    <span style="color:red">*</span></td>
             
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
            <td>Date Of Birth    <span style="color:red">*</span></td>
             
           <td>          

               <asp:TextBox ID="dob" runat="server"></asp:TextBox>

          
              
                  <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" ImageUrl="~/Calendar.png" Width="30px" OnClick="ImageButton1_Click" />

               </td>
              </tr>
        <tr>
              <td></td>
              <td>
                  <asp:Calendar ID="Calendar1" runat="server" Visible ="false" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
              </td>

        </tr>
          <tr>
            <td>Date Of Employment  <span style="color:red">*</span></td>
             <td>           

                 <asp:TextBox ID="doe" runat="server"></asp:TextBox>
           
               <asp:ImageButton ID="ImageButton2" runat="server" Height="30px" ImageUrl="~/Calendar.png" Width="29px" OnClick="ImageButton2_Click" />

           </td>
               </tr>
             <tr>
                 <td></td>
                 <td>
                     <asp:Calendar ID="Calendar2" runat="server" Visible ="false" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
                 </td>
             </tr>
        <tr>
            <td>Guardian Number</td>
            <td>
                <asp:TextBox ID="mobile" runat="server"></asp:TextBox>

            </td>
        </tr>
         <tr>
            <td class="auto-style1">Home address<span style="color:red">*</span></td>
            <td class="auto-style1">

                <asp:TextBox ID="homeaddress" runat="server" Rows="0" TextMode="MultiLine" Height="84px" Width="163px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td >Image Provided</td>
            <td>
                <asp:CheckBox ID="imageGiven" runat="server" Text="Image" />
            </td>
        </tr>
        <tr>
            <td >Form Filled</td>
            <td>
                <asp:CheckBox ID="formFill" runat="server" Text="Form"/>
            </td>
        </tr>
        <tr>
            <td >Blood Group</td>
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
                &nbsp;
                <asp:CheckBox ID="bloodGroupChecked" runat="server" Text="Tested" AutoPostBack="true" OnCheckedChanged="bloodGroupChecked_CheckedChanged"/>
                &nbsp;<asp:CheckBox ID="isPaid" runat="server" Text="Paid" ForeColor="green" Enabled="false"/>
            </td>
        </tr>
          <tr>
             <td></td>
             <td>
                 <asp:Button ID="save" runat="server" Text="Save" OnClick="SaveButton1_Click" />
                 <asp:Button ID="update" runat="server" Text="Update" Visible="false" OnClick="update_Click"/>
                 <asp:Button ID="reset" runat="server" Text="Reset" OnClick="resetButton3_Click" />
                 <a href="searchInformation.aspx">Old Search</a> | <a href="searchInformationNew.aspx">New Search </a>
                 <%--<asp:Button ID="Button4" runat="server" Text="Search" OnClick="searchButton4_Click" />--%>

            </td>
        </tr>
        <tr>
            <td>

            </td>
        </tr>

       
        
    </table>
                <asp:Label ForeColor="red" ID="msg" runat="server" Text=""></asp:Label><br>
                 

    </div>
    </form>
</body>
</html>
