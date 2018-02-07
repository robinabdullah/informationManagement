<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showDetails.aspx.cs" Inherits="informationManagement.showDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
    </div>
        <table>
           
               <tr><td> <h2>Show Details</h2></td></tr>
              <tr>
            <td>Name<span style="color:red">*</span></td>
             
           <td>           
               

               <asp:Label ID="name" runat="server" Text=""></asp:Label>

           </td>

        </tr>
          <tr>
            <td>Class<span style="color:red">*</span> </td>
           <td>
                           
              
              <asp:Label ID="clas" runat="server" Text=""></asp:Label>

           </td>

        </tr>
         <tr>
            <td>Section<span style="color:red">*</span></td>
             
           <td>
           <asp:Label ID="section" runat="server" Text=""></asp:Label>
           </td>

        </tr>
          <tr>
            <td> <asp:Label Text="Department" ID="departmentLabel" runat="server" />  </td>
             
           <td>

              <asp:Label ID="department" runat="server" Text=""></asp:Label>

           </td>

        </tr>
       
         <tr>
            <td>Gender   <span style="color:red">*</span></td>
             
           <td>
                         
                 <asp:Label ID="gender" runat="server" Text=""></asp:Label>
             
           </td>

        </tr>
         <tr>
            <td>Roll  <span style="color:red">*</span></td>
             
           <td>
                          

              <asp:Label ID="roll" runat="server" Text=""></asp:Label>

           </td>

        </tr>
         <tr>
            <td>Shift   <span style="color:red">*</span></td>
             
           <td>
                       
                 <asp:Label ID="shift" runat="server" Text=""></asp:Label>
           </td>

        </tr>
         <tr>
            <td>Nationality   <span style="color:red">*</span></td>
             
           <td>
                
               <asp:Label ID="national" runat="server" Text="Bangladeshi"></asp:Label>
           </td>

        </tr>
          <tr>
            <td>Father Number    <span style="color:red">*</span></td>
             
           <td>         
               <asp:Label ID="number" runat="server" Text=""></asp:Label>
           </td>

        </tr>
         
             <tr>
            <td>Date Of Birth    <span style="color:red">*</span></td>
             
              <td>          

                <asp:Label ID="dob" runat="server" Text=""></asp:Label>

               </td>
              </tr>
              <tr>
            <td>Blood Group</td>
                <td>
                 <asp:Label ID="bloodGroup" runat="server" Text=""></asp:Label>
                </td>
            </tr>
             <tr>
            <td>Date Of Enrollment</td>
                <td>
                 <asp:Label ID="enrollment" runat="server" Text=""></asp:Label>
                </td>
            </tr>
             <tr>
            <td>Academic Year</td>
                <td>
                 <asp:Label ID="academic" runat="server" Text=""></asp:Label>
                </td>
            </tr>
             <tr>
            <td>Active/Inactive</td>
                <td>
                 <asp:Label ID="ac" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                 <td>School</td>
                <td>
                 <asp:Label ID="school" runat="server" Text=""></asp:Label>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
