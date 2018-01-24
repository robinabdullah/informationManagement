using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class informationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user_name"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
                username.Text = Session["user_name"].ToString();
        }

        protected void SaveButton1_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                msg.Text = "please enter valid name";
            }
            else if (clas.SelectedItem.Text == "Select Class")
            {
                msg.Text = "please enter valid class";
            }
            else if (section.SelectedItem.Text == "Select Section")
            {
                msg.Text = "please enter valid section";
            }

            else if (gender.SelectedItem.Text == "Select Gender")
            {
                msg.Text = "please enter valid gender";
            }
            else if (roll.Text == "")
            {
                msg.Text = "please enter valid roll";
            }
            else if (shift.SelectedItem.Text == "Select Shift")
            {
                msg.Text = "please enter valid shift";
            }
            else if (national.Text == "")
            {
                msg.Text = "please enter valid nationality";
            }
            else if (officephone.Text == "")
            {
                msg.Text = "please enter valid officephone";
            }
            else if (title.SelectedItem.Text == "Select Title")
            {
                msg.Text = "please enter valid title";
            }
            else if (dob.Text == "")
            {
                msg.Text = "please enter valid DateOfBirth";
            }
            else if (doe.Text == "")
            {
                msg.Text = "please enter valid DateOfEmployeement";
            }
            else if (mobile.Text == " ")
            {
                msg.Text = "please enter valid mobile";
            }
            else if (homeaddress.Text == "")
            {
                msg.Text = "please enter valid homeaddress";
            }
            else
            {

                string dept = department.SelectedIndex == 0 ? "" : department.SelectedItem.Text;
                String insert = String.Format("insert into Information(Name,Class,Section,Department,Gender,Roll,Shift,Nationality,Office_Phone,Title,DateOfBirth,DateOfEmployment,Mobile_Number,Home_address,Created_By) OUTPUT INSERTED.ID values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}',{14})", name.Text, clas.SelectedItem.Text, section.SelectedItem.Text, dept, gender.SelectedItem.Text, roll.Text, shift.SelectedItem.Text, national.Text, officephone.Text, title.SelectedItem.Text, dob.Text, doe.Text, mobile.Text, homeaddress.Text, Session["user_id"].ToString());

                SqlConnection conn = new SqlConnection(Information.connectionstring);
                SqlCommand cmd = new SqlCommand(insert, conn);
                conn.Open();

                int a = (int)cmd.ExecuteScalar();
                if (a > 0)
                {
                    msg.Text = "successfully inserted. ID: " + a;
                }
                Clearall();


            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            dob.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = true;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            doe.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;


        }

        protected void searchButton4_Click(object sender, EventArgs e)
        {
            String add = "searchInformation.aspx";
            Response.Redirect(add);
        }
        private void Clearall()
        {
            name.Text = "";
            clas.SelectedIndex = 0;
            section.SelectedIndex = 0;
            department.SelectedIndex = 0;
            gender.SelectedIndex = 0;
            roll.Text = "";
            shift.SelectedIndex = 0;
            national.Text = "";
            officephone.Text = "";
            title.SelectedIndex = 0;
            dob.Text = "";
            doe.Text = "";
            mobile.Text = "";
            homeaddress.Text = "";
        }

        protected void resetButton3_Click(object sender, EventArgs e)
        {
            Clearall();
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("LoginPage.aspx");
        }

        protected void clas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clas.SelectedIndex == 2 || clas.SelectedIndex == 3)
            {
                department.Visible = true;
                departmentLabel.Visible = true;
            }
            else
            {
                
                department.Visible = false;
                departmentLabel.Visible = false;
            }
        }
    }
}