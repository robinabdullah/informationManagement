using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class searchInformationNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_name"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else if (Session["role"].ToString() == "guest")
                Response.Redirect("informationPage.aspx");
            else
                username.Text = Session["user_name"].ToString();
    }

        protected void searchButton1_Click(object sender, EventArgs e)
        {
            msg.Text = " ";
            list.DataSource = null;
            list.DataBind();
            String search;
            string commonQuery = "select Information.id, Information.Name, Class, Section, Department, Gender, Roll, Shift, Title,Office_Phone as Personal_Number, DateofBirth, Mobile_Number as Guardian_Number,Home_Address, newLogin.name as Created_By,Created_Date, Updated_By,Updated_Date, Image_Provided, Form_Filled, Blood_Group, Blood_Group_Checked, Is_Paid as Paid, Deleted_By, Deleted_Date from Information, newLogin where created_by=newLogin.ID ";

            string countQuery = "select count(id) as count from information where 1 = 1 ";

            if (id.Text.Trim() != "")
            {
                search = String.Format(commonQuery + " and Information.id={0}", id.Text.Trim());
            }
            else
            {
                string selectedOfficeMobile = officeNumber.Text == "" ? "" : " and office_Phone='" + officeNumber.Text + "'";
                string selectedMobileNo = mobile.Text == "" ? "" : " and Mobile_Number='" + mobile.Text + "'";
                string selectedClass = clas.SelectedIndex == 0 ? "" : " and class='" + clas.SelectedItem.Text + "'";//class 9
                string selectedShift = shift.SelectedIndex == 0 ? "" : " and shift='" + shift.SelectedItem.Text + "'";
                string selectedTitle = title.SelectedIndex == 0 ? "" : " and title='" + title.SelectedItem.Text + "'";
                string selectedBloodGroup = bloodGroup.SelectedIndex == 0 ? "" : " and Blood_Group='" + bloodGroup.SelectedItem.Text + "'";
                string selectedBloodGroupChecked = bloodGroupChecked.SelectedIndex == 0 ? "" : " and Blood_Group != 'N/A' and Blood_Group_Checked=" + bloodGroupChecked.SelectedValue;
                string selectedImageProvided = imageProvided.Checked == false ? "" : " and Image_Provided=1" ;
                string selectedFormFilled = formFilled.Checked == false ? "" : " and Form_Filled=1" ;
                string selectedPaymentType = paymentType.SelectedIndex == 0 ? "" : " and Is_paid=" + paymentType.SelectedValue;
                if (withTableData.Checked == true)
                    search = commonQuery + selectedOfficeMobile + selectedMobileNo + selectedClass + selectedShift + selectedTitle + selectedBloodGroup + selectedBloodGroupChecked + selectedPaymentType + selectedImageProvided + selectedFormFilled;
                else
                    search = countQuery + selectedOfficeMobile + selectedMobileNo + selectedClass + selectedShift + selectedTitle + selectedBloodGroup + selectedBloodGroupChecked + selectedPaymentType + selectedImageProvided + selectedFormFilled;

            }
            
            SqlConnection conn = new SqlConnection(Information.connectionstring);
            SqlCommand cmd = new SqlCommand(search, conn);
            conn.Open();
            SqlDataReader reader = null;
            if (withTableData.Checked == true || id.Text.Trim() != "")
            {
                reader = cmd.ExecuteReader();
                list.DataSource = reader;
                list.DataBind();
                msg.Text = list.Rows.Count + " records found";
                reader.Close();
            }
            else
            {
                int rows = (int)cmd.ExecuteScalar();
                msg.Text = rows + " records found";
            }

            withTableData.Checked = false;
            conn.Close();
            conn.Dispose();
            SqlConnection.ClearPool(conn);
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            //Session["user_name"] = null;
            Session.Clear();
            Response.Redirect("LoginPage.aspx");
        }
        protected void bloodGroupChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (bloodGroupChecked.SelectedIndex == 0 || bloodGroupChecked.SelectedValue == "0")
            {
                paymentType.SelectedIndex = 0;
                paymentType.Enabled = false;
            }
            else
            {
                paymentType.Enabled = true;
            }
        }
        protected void reset_Click(object sender, EventArgs e)
        {

            id.Text = "";
            clas.SelectedIndex = 0;

            shift.SelectedIndex = 0;

            title.SelectedIndex = 0;

            officeNumber.Text = "";

            mobile.Text = "";

            bloodGroup.SelectedIndex = 0;
            bloodGroupChecked.SelectedIndex = 0;
            paymentType.SelectedIndex = 0;
            paymentType.Enabled = false;
            imageProvided.Checked = false;
            formFilled.Checked = false;
            withTableData.Checked = false;
            list.DataSource = null;
            list.DataBind();

            msg.Text = "";
        }

    }
}