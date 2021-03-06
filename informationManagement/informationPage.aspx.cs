﻿using System;
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
            if (Session["user_name"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                username.Text = Session["user_name"].ToString();
            }

            if(IsPostBack == false)
                editDelete();

          

            
        }
        private void editDelete()
        {
            //edit
            if (Request.QueryString["id"] != null && Session["Role"].ToString() == "admin")//edit link
            {
                save.Visible = false;
                save.Enabled = false;
                update.Enabled = true;
                update.Visible = true;
                String select = "select Name,Class, Section, Department, Gender, Roll, Shift, Nationality, Office_Phone, Title,DateOfBirth, DateOfEmployment,Mobile_Number, Home_address, Image_Provided, Form_Filled, Blood_Group,  Blood_Group_Checked, Is_Paid from Information where Is_Deleted = 0 and Id=" + Request.QueryString["id"];
                SqlConnection conn = new SqlConnection(Information.connectionstring);
                SqlCommand cmd = new SqlCommand(select, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    name.Text = reader["Name"].ToString();
                    clas.SelectedValue = clas.Items.FindByText(reader["Class"].ToString()).Value;
                    if (clas.SelectedItem.Text == "Class 9" || clas.SelectedItem.Text == "Class 10")
                    {
                        departmentLabel.Visible = true;
                        department.Visible = true;
                        department.SelectedValue = department.Items.FindByText(reader["Department"].ToString()).Value;
                    }
                    else
                    {
                        department.Visible = false;
                        departmentLabel.Visible = false;
                    }
                    // section.SelectedItem.Text = reader["Section"].ToString();
                    section.SelectedValue = section.Items.FindByText(reader["Section"].ToString()).Value;
                    // department.SelectedItem.Text = reader[3].ToString();
                    gender.SelectedValue = gender.Items.FindByText(reader["Gender"].ToString()).Value;
                    roll.Text = reader["Roll"].ToString();
                    shift.SelectedValue = shift.Items.FindByText(reader["Shift"].ToString()).Value;
                    national.Text = reader["Nationality"].ToString();
                    officephone.Text = reader["Office_Phone"].ToString();
                    title.SelectedValue = title.Items.FindByText(reader["Title"].ToString()).Value;
                    dob.Text = reader["DateOfBirth"].ToString();
                    doe.Text = reader["DateOfEmployment"].ToString();
                    mobile.Text = reader["Mobile_Number"].ToString();
                    homeaddress.Text = reader["Home_address"].ToString();
                    imageGiven.Checked = bool.Parse(reader["Image_Provided"].ToString());
                    formFill.Checked = bool.Parse(reader["Form_Filled"].ToString());
                    bloodGroup.SelectedValue = bloodGroup.Items.FindByText(reader["Blood_Group"].ToString()).Value;
                    bloodGroupChecked.Checked = bool.Parse(reader["Blood_Group_Checked"].ToString());
                    if (bloodGroupChecked.Checked == true)
                        isPaid.Enabled = true;
                    isPaid.Checked = bool.Parse(reader["Is_Paid"].ToString());

                }
                reader.Close();
                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);

            }
            else if(Request.QueryString["deleteID"] != null && Session["Role"].ToString() == "admin") //delete
            {
                save.Visible = false;
                save.Enabled = false;
                delete.Enabled = true;
                delete.Visible = true;
                String select = "select Name,Class, Section, Department, Gender, Roll, Shift, Nationality, Office_Phone, Title,DateOfBirth, DateOfEmployment,Mobile_Number, Home_address, Image_Provided, Form_Filled, Blood_Group,  Blood_Group_Checked, Is_Paid from Information where Is_Deleted = 0 and Id=" + Request.QueryString["deleteID"];
                SqlConnection conn = new SqlConnection(Information.connectionstring);
                SqlCommand cmd = new SqlCommand(select, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    name.Text = reader["Name"].ToString();
                    clas.SelectedValue = clas.Items.FindByText(reader["Class"].ToString()).Value;
                    if (clas.SelectedItem.Text == "Class 9" || clas.SelectedItem.Text == "Class 10")
                    {
                        departmentLabel.Visible = true;
                        department.Visible = true;
                        department.SelectedValue = department.Items.FindByText(reader["Department"].ToString()).Value;
                    }
                    else
                    {
                        department.Visible = false;
                        departmentLabel.Visible = false;
                    }
                    // section.SelectedItem.Text = reader["Section"].ToString();
                    section.SelectedValue = section.Items.FindByText(reader["Section"].ToString()).Value;
                    // department.SelectedItem.Text = reader[3].ToString();
                    gender.SelectedValue = gender.Items.FindByText(reader["Gender"].ToString()).Value;
                    roll.Text = reader["Roll"].ToString();
                    shift.SelectedValue = shift.Items.FindByText(reader["Shift"].ToString()).Value;
                    national.Text = reader["Nationality"].ToString();
                    officephone.Text = reader["Office_Phone"].ToString();
                    title.SelectedValue = title.Items.FindByText(reader["Title"].ToString()).Value;
                    dob.Text = reader["DateOfBirth"].ToString();
                    doe.Text = reader["DateOfEmployment"].ToString();
                    mobile.Text = reader["Mobile_Number"].ToString();
                    homeaddress.Text = reader["Home_address"].ToString();
                    imageGiven.Checked = bool.Parse(reader["Image_Provided"].ToString());
                    formFill.Checked = bool.Parse(reader["Form_Filled"].ToString());
                    bloodGroup.SelectedValue = bloodGroup.Items.FindByText(reader["Blood_Group"].ToString()).Value;
                    bloodGroupChecked.Checked = bool.Parse(reader["Blood_Group_Checked"].ToString());
                    if (bloodGroupChecked.Checked == true)
                        isPaid.Enabled = true;
                    isPaid.Checked = bool.Parse(reader["Is_Paid"].ToString());

                }
                reader.Close();
                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);
            }
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
            else if (department.Visible == true && department.SelectedIndex == 0)
            {
                msg.Text = "please enter valid department";
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
            else if (officephone.Text == "" || officephone.Text.Trim().Length != 11)
            {
                msg.Text = "please enter valid personal phone";
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
            else if (mobile.Text == "") // || mobile.Text.Trim().Length != 11
            {
                msg.Text = "please enter valid guardian number";
            }
            else if (homeaddress.Text == "")
            {
                msg.Text = "please enter valid homeaddress";
            }
            else if (bloodGroup.SelectedIndex == 0)
            {
                msg.Text = "please enter valid blood group";
            }
            else
            {

                string dept = (department.Visible == false) ? "" : department.SelectedItem.Text;
                String insert = String.Format("insert into Information(Name,Class,Section,Department,Gender,Roll,Shift,Nationality,Office_Phone,Title,DateOfBirth,DateOfEmployment,Mobile_Number,Home_address,Created_By,Image_Provided,Form_Filled, Blood_Group, Blood_Group_Checked, Is_Paid) OUTPUT INSERTED.ID values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}',{14},'{15}','{16}', '{17}','{18}', '{19}')", name.Text, clas.SelectedItem.Text, section.SelectedItem.Text, dept, gender.SelectedItem.Text, roll.Text, shift.SelectedItem.Text, national.Text, officephone.Text, title.SelectedItem.Text, dob.Text, doe.Text, mobile.Text, homeaddress.Text, Session["user_id"].ToString(), imageGiven.Checked, formFill.Checked, bloodGroup.SelectedItem.Text, bloodGroupChecked.Checked, isPaid.Checked);

                SqlConnection conn = new SqlConnection(Information.connectionstring);
                SqlCommand cmd = new SqlCommand(insert, conn);
                conn.Open();

                int a = (int)cmd.ExecuteScalar();
                if (a > 0)
                {
                    msg.Text = "successfully inserted. ID: " + a;
                    Clearall();
                }
                else
                    msg.Text = "save failed ";

                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = !Calendar1.Visible;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            dob.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = !Calendar2.Visible;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            doe.Text = Calendar2.SelectedDate.ToShortDateString();
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
            national.Text = "Bangladeshi";
            officephone.Text = "";
            title.SelectedIndex = 0;
            dob.Text = "";
            doe.Text = "";
            mobile.Text = "";
            homeaddress.Text = "";
            imageGiven.Checked = false;
            formFill.Checked = false;
            bloodGroup.SelectedIndex = 0;
            bloodGroupChecked.Checked = false;
            isPaid.Checked = false;
            save.Visible = true;
            save.Enabled = true;
            update.Visible = false;
            update.Enabled = false;
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

        protected void update_Click(object sender, EventArgs e)
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
            else if (department.Visible==true &&  department.SelectedIndex == 0 )
            {
                msg.Text = "please enter valid department";
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
            else if (officephone.Text == "" || officephone.Text.Trim().Length != 11)
            {
                msg.Text = "please enter valid personal number";
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
            else if (mobile.Text == "") // || mobile.Text.Trim().Length != 11
            {
                msg.Text = "please enter valid  guardian number";
            }
            else if (homeaddress.Text == "")
            {
                msg.Text = "please enter valid homeaddress";
            }
            else if (bloodGroup.SelectedIndex == 0)
            {
                msg.Text = "please enter valid blood group";
            }
            else
            {
                string dept = (department.Visible == false) ? "" : department.SelectedItem.Text;
                string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
                String update = String.Format("update Information set Name='{0}',Class='{1}',Section='{2}',Department='{3}',Gender='{4}',Roll='{5}',Shift='{6}',Nationality='{7}',Office_Phone='{8}',Title='{9}',DateOfBirth='{10}',DateOfEmployment='{11}',Mobile_Number='{12}',Home_address='{13}',Updated_By='{14}' ,Updated_Date='{15}',Image_Provided='{16}',Form_Filled='{17}', Blood_group='{18}',  Blood_Group_Checked='{19}', Is_Paid='{20}' where Is_Deleted = 0 and Id={21}", name.Text, clas.SelectedItem.Text, section.SelectedItem.Text, dept, gender.SelectedItem.Text, roll.Text, shift.SelectedItem.Text, national.Text, officephone.Text, title.SelectedItem.Text, dob.Text, doe.Text, mobile.Text, homeaddress.Text, Session["user_id"].ToString(), date, imageGiven.Checked, formFill.Checked, bloodGroup.SelectedItem.Text, bloodGroupChecked.Checked, isPaid.Checked, Request.QueryString["id"]);

                SqlConnection conn = new SqlConnection(Information.connectionstring);
                SqlCommand cmd = new SqlCommand(update, conn);
                conn.Open();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    msg.Text = "successfully updated";
                    Clearall();
                    this.update.Enabled = false;
                    this.update.Visible = false;
                    this.save.Enabled = true;
                    this.save.Visible = true;

                }
                else
                {
                    msg.Text = "updated failed";
                }
                
                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);
            }

        }
        protected void delete_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
            String update = String.Format("update Information set is_deleted = 1, deleted_by={0}, deleted_date='{1}' where Id={2}", Session["user_id"].ToString(), date, Request.QueryString["deleteID"]);

            SqlConnection conn = new SqlConnection(Information.connectionstring);
            SqlCommand cmd = new SqlCommand(update, conn);
            conn.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                msg.Text = "successfully deleted";
                Clearall();
                this.delete.Enabled = false;
                this.delete.Visible = false;
                this.save.Enabled = true;
                this.save.Visible = true;

            }
            else
            {
                msg.Text = "delete failed";
            }

            conn.Close();
            conn.Dispose();
            SqlConnection.ClearPool(conn);
        }
        protected void bloodGroupChecked_CheckedChanged(object sender, EventArgs e)
        {
            if(bloodGroupChecked.Checked == true)
            {
                isPaid.Enabled = true;
            }
            else
            {
                isPaid.Enabled = false;
                isPaid.Checked = false;

            }
        }

       
    }
}