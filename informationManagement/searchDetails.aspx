﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchDetails.aspx.cs" Inherits="informationManagement.searchDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link rel="stylesheet" href="Contents/bootstrap.min.css" />

<!-- Optional theme -->
<link rel="stylesheet" href="Contents/bootstrap-theme.min.css" />

<!-- Latest compiled and minified JavaScript -->
    <script src="Scripts/jquery-1.12.4.js"></script>

<script src="Scripts/bootstrap.min.js" ></script>
    <%--<script src="http://www.bootply.com/bootply.js" type="text/javascript"></script>--%>
    <style>
        table {border-spacing: 8px 2px;}
        td {padding: 6px;}
        body{
            margin:10px;
            padding:20px;  
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>

       <tr>
           <td> ID </td>
            <td>
                <asp:TextBox ID="id" runat="server" TextMode ="Number"></asp:TextBox>

            </td>
          <td>
              <asp:Button ID="search" runat="server" Text="Search" OnClick="search_Click" />

                <a href="informationPage.aspx">Back</a>

          </td>
       </tr> 

        <tr> 
            <td> </td>
            <td>
               <asp:Label ID="msg" runat="server" Text=""></asp:Label>

           </td>

        </tr>


    </table>
          <% if(msg.Text != "Not Found" && id.Text  != ""){%>
         <div>
       <div class="row panel panel-success" style="margin-top: 2%;">
                <div class="panel-heading lead">
                    <div class="row">
                        <div class="col-lg-8 col-md-8"><i class="fa fa-users"></i>View Student Details</div>
                        <%--edit link--%>
                        <%--<div class="col-lg-4 col-md-4 text-right">
                            <div class="btn-group text-center">
                                <a href="student-view.php?sid=1&amp;id=68" class="btn btn-success btn-sm btn-default"><i class="fa fa-eye fa-1x"></i></a>
                                <a href="student-modify.php?sid=1&amp;id=68" class="btn btn-success btn-sm btn-default"><i class="fa fa-edit fa-1x"></i></a>
                                <a href="student-print.php?sid=1&amp;id=68" class="btn btn-success btn-sm btn-default"><i class="fa fa-print fa-1x"></i></a>
                                <a href="student-delete.php?sid=1&amp;id=68" class="btn btn-success btn-sm btn-default"><i class="fa fa-trash-o fa-1x"></i></a>
                            </div>
                        </div>--%>
                    </div>
                </div>
                <div class="panel-body">

                    <div class="row">
                        <div class="col-lg-12 col-md-12">

                            <div class="row">
                                <div class="col-lg-3 col-md-3">
                                    <center>
                                        <span class="text-left">
                                         <asp:Image ID="Image1" runat="server" AlternateText="Image"  Height="150px"/>


                                            <!-- Modal -->
                                            <div class="modal fade" id="PhotoOption" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" style="display: none;">
                                                <div class="modal-dialog" style="width:30%;height:30%;">
                                                    <div class="modal-content">
                                                        <div class="modal-header">
                                                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                                            <h4 class="modal-title text-success" id="myModalLabel"><i class="fa fa-gear"></i> <span class="text-right">Viddhyut Mall</span></h4>
                                                        </div>
                                                        <div class="modal-body">
    <center><img src="upload/profile_pic/701b4263f7d38604699b7c1f89a3e6a6.jpg" class="img-responsive img-thumbnail"></center>
                                                        </div>
                                                        <div class="modal-footer">
                                                            <a href="upload/upload-view.php?id=68" class="btn btn-success"><i class="fa fa-photo"></i> Upload</a>
                                                            <a href="upload/upload-view.php?id=68&amp;name=Viddhyut Mall&amp;src=view" class="btn btn-danger"><i class="fa fa-trash"></i> Delete</a>
                                                        </div>
                                                    </div>
                                                    <!-- /.modal-content -->
                                                </div>
                                                <!-- /.modal-dialog -->
                                            </div>
                                            <!-- /.modal -->                    
                                    </span></center>

                                </div>
                                <div class="col-lg-9 col-md-9">
                                    <ul class="nav nav-tabs">
                                        <li class="active"><a data-toggle="tab" href="#Summery" class="text-success"><i class="fa fa-indent"></i>Summery</a></li>
                                        <li><a data-toggle="tab" href="#Contact" class="text-success"><i class="fa fa-bookmark-o"></i>Contact Info</a></li>
                                      <%--  <li><a data-toggle="tab" href="#Address" class="text-success"><i class="fa fa-home"></i>Address</a></li>--%>
                                        <li><a data-toggle="tab" href="#General" class="text-success"><i class="fa fa-info"></i>General Info</a></li>
                                    </ul>

                                    <div class="tab-content">
                                        <div id="Summery" class="tab-pane fade in active">

                                            <div class="table-responsive panel">
                                                <table class="table">
                                                    <tbody>

                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-user"></i>Full Name</td>
                                                            <td>
                                                                <asp:Label ID="name" runat="server" Text=""></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-list-ol"></i>Scholar Number</td>
                                                              <td>      
                                                                <asp:Label ID="roll" runat="server" Text=""></asp:Label>
                                                              </td>
                                                        </tr>
                                                         <tr>
                                                            <td class="text-success"><i class="fa fa-book"></i>Shift</td>
                                                            <td>
                                                                <asp:Label ID="shift" runat="server" Text=""></asp:Label>
                                                           </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-book"></i>Class</td>
                                                            <td>   
                                                                 <asp:Label ID="clas" runat="server" Text=""></asp:Label>

                                                            </td>
                                                        </tr>
                                                          <tr>
                                                            <td class="text-success"><i class="fa fa-book"></i>Gender</td>
                                                             <td> 
                                                                 <asp:Label ID="gender" runat="server" Text=""></asp:Label>
                                                             </td>
                                                        </tr>
                                                        <% if(department.Text != ""){%>
                                                         <tr>
                                                            <td class="text-success"><i class="fa fa-book"></i>Department</td>
                                                            <td>
                                                                 <asp:Label ID="department" runat="server" Text=""></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <%}%>
                                                         <tr>
                                                            <td class="text-success"><i class="fa fa-book"></i>Section</td>
                                                            <td>   
                                                                <asp:Label ID="section" runat="server" Text=""></asp:Label>

                                                            </td>
                                                        </tr>
                                                        
                                                       
                                                      
                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-calendar"></i>Birthday</td>
                                                            <td>  
                                                               <asp:Label ID="dob" runat="server" Text=""></asp:Label>
                                                             </td>
                                                        </tr>

                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-university"></i>School</td>
                                                            <td>
                                                                <b>Salahuddin Ahmed High School </b>                                                             </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>

                                    <%--    <div id="Address" class="tab-pane fade">
                                            <div class="table-responsive panel">
                                                <table class="table">
                                                    <tbody>

                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-home"></i>Address</td>
                                                            <td>
                                                                <address>
                                                                    <strong>C-***, Amahiya </strong>
                                                                    <br>
                                                                    Kharobar, ******
                                                                    <br>
                                                                    Gorakhpur, Utter Pradesh, India<br>
                                                                </address>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>--%>
                                        <div id="Contact" class="tab-pane fade">
                                            <div class="table-responsive panel">
                                                <table class="table">
                                                    <tbody>

                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-envelope-o"></i>Email ID</td>
                                                            <td></td>
                                                        </tr>
                                                        <tr>
                                                          <td class="text-success"><i class="glyphicon glyphicon-phone"></i>Mobile                                Number</td>
                                                            <td> <asp:Label ID="officephone" runat="server" Text=""></asp:Label></td>
                                                        </tr>
                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-flag"></i>Nationality</td>
                                                             <td>
                                                            <asp:Label ID="national" runat="server" Text="Bangladeshi"></asp:Label>                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-user"></i>Father's Name</td>
                                                             <td></td>
                                                        </tr>
                                                        <tr>
                                                         <td class="text-success"><i class="glyphicon glyphicon-phone"></i>Father's                         Mobile</td>
                                                         <td>         
                                                             <asp:Label ID="mobile" runat="server" Text=""></asp:Label>
                                                         </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-user"></i>Mother's Name</td>
                                                             <td></td>
                                                        </tr>
                                                        <tr>
                                                         <td class="text-success"><i class="glyphicon glyphicon-phone"></i>Mother's Mobile</td>
                                                           <td></td> 
                                                        </tr>
                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-user"></i>Emergency Contact Person</td>
                                                           <td></td>
                                                        </tr>
                                                        <tr>
                                                            <td class="text-success"><i class="glyphicon glyphicon-phone"></                                   i>Emergency Contact Person's Mobile</td>
                                                         <td></td>
                                                        </tr>

                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                        <div id="General" class="tab-pane fade">
                                            <div class="table-responsive panel">
                                                <table class="table">
                                                    <tbody>
                                                      
                                                     <%--   <tr>
                                                            <td class="text-success"><i class="fa fa-university"></i>Last School</td>
                                                            <td>Pawan Mall's School</td>
                                                        </tr>--%>
                                                        
                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-calendar"></i>Date of Admission</td>
                                                            <td> <asp:Label ID="doe" runat="server" Text="Label"></asp:Label></td>
                                                        </tr>
                                                          <tr>
                                                            <td class="text-success"><i class="fa fa-calendar"></i>Academic Year</td>
                                                            <td>2018-2019</td>
                                                        </tr>
                                                          <tr>
                                                            <td class="text-success"><i class="fa fa-calendar"></i>Blood Group</td>
                                                             <td>
                                                                <asp:Label ID="bloodGroup" runat="server" Text=""></asp:Label>
                                                             </td>
                                                             </tr>
                                                         <tr>
                                                            <td class="text-success"><i class="fa fa-thumbs-up"></i>Active/Inactive</td>
                                                            <td>Student is Active</td>
                                                        </tr>
                                                       
          
                                                      <%--  <tr>
                                                            <td class="text-success"><i class="fa fa-home"></i>Birth Place</td>
                                                            <td>Delhi</td>
                                                        </tr>
                                                      
                                                        <tr>
                                                            <td class="text-success"><i class="fa fa-medkit"></i>Medical Condition</td>
                                                            <td>Normal</td>
                                                        </tr>
                                                       
                                                        <tr>
                                                            <td class="text-success"><i class="glyphicon glyphicon-time"></i>Last Editing</td>
                                                            <td>2015-08-20 09:41:56</td>
                                                        </tr>--%>

                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>

                                    </div>

                                </div>

                            </div>
                        </div>
                    </div>
                    <!-- /.table-responsive -->

                </div>
            </div>
    </div>
      <%}%>
    </div>

    </form>
</body>
</html>
