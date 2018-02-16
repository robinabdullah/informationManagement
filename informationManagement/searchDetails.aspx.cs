using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class searchDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if(Session["user_name"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else if (Session["role"].ToString() == "guest")
                Response.Redirect("informationPage.aspx");
          
        }

        protected void search_Click(object sender, EventArgs e)
        {
            string search = "Select * from Information where Information.Id=" + id.Text;
            SqlConnection conn = new SqlConnection(Information.connectionstring);
            SqlCommand cmd = new SqlCommand(search, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Image1.ImageUrl = "http://salahuddinahmedhighschool.com/student_images/" + id.Text + ".jpg";
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

            if (reader.HasRows == false)
            {
                msg.Text = "Not Found";
            }
            reader.Close();
            conn.Close();
            conn.Dispose();

            SqlConnection.ClearPool(conn);
        }
    }
}