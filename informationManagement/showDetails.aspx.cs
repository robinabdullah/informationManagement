using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class showDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["id"] != null)//edit link
            {
                Image1.ImageUrl = "http://salahuddinahmedhighschool.com/student_images/" + Request.QueryString["id"] + ".jpg";

                String select = "select Name,Class, Section, Department, Gender, Roll, Shift,Office_Phone, Nationality,DateOfBirth,DateOfEmployment,Mobile_Number,Blood_Group from Information where Is_Deleted = 0 and Id=" + Request.QueryString["id"];
                SqlConnection conn = new SqlConnection(Information.connectionstring);
                SqlCommand cmd = new SqlCommand(select, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name.Text = reader["Name"].ToString();
                    clas.Text = reader["Class"].ToString();
                    if (clas.Text == "Class 9" || clas.Text == "Class 10")
                    {
                        department.Visible = true;
                        department.Visible = true;
                        department.Text = reader["Department"].ToString();
                    }
                    else
                    {
                        department.Visible = false;
                        department.Visible = false;
                    }
                    section.Text = reader["Section"].ToString();
                    // department.SelectedItem.Text = reader[3].ToString();
                    gender.Text = reader["Gender"].ToString();
                    roll.Text = reader["Roll"].ToString();
                    shift.Text = reader["Shift"].ToString();
                    officephone.Text = reader["Office_Phone"].ToString();
                    national.Text = reader["Nationality"].ToString();
                    dob.Text = reader["DateOFBirth"].ToString();
                    doe.Text = reader["DateOfEmployment"].ToString();
                    mobile.Text = reader["Mobile_Number"].ToString();
                    bloodGroup.Text = reader["Blood_Group"].ToString();


                }
                reader.Close();
                conn.Close();
                conn.Dispose();
               
                SqlConnection.ClearPool(conn);

            }
        }

      

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
         
            
        }
    }
}