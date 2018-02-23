using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
            //string commonQuery = "select Information.id, Information.Name, Class, Section, Department, Gender, Roll, Shift, Title,Office_Phone as Personal_Number, DateofBirth, Mobile_Number as Guardian_Number,Home_Address, newLogin.name as Created_By,Created_Date, Updated_By,Updated_Date, Image_Provided, Form_Filled, Blood_Group, Blood_Group_Checked, Is_Paid as Paid, Deleted_By, Deleted_Date from Information, newLogin where created_by=newLogin.ID ";
            string commonQuery = "select Information.id, Information.Name, Class, Section, Department, Gender, Cast(Roll as int) as Roll, Shift, Title,Office_Phone as Personal_No, DateofBirth as DOB, Mobile_Number as Guardian_No,Home_Address, newLogin.name as 'Created_By',Created_Date, Updated_By,Updated_Date, (Case When Image_Provided = 1 then 'Yes' Else '' End) As 'Image', (Case When Form_Filled = 1 then 'Yes' Else '' End) As 'Form' , Blood_Group, (Case When Blood_Group_Checked = 1 then 'Yes' Else '' End) As 'Blood Tested' , (Case When Is_Paid = 1 then 'Yes' Else '' End) As 'Paid', (Case When Is_Verified = 1 then 'Yes' Else '' End) As 'Verified', Present_Status, Remarks  from Information, newLogin where created_by = newLogin.ID and Is_Deleted = 0";//, Deleted_By, Deleted_Date

            string countQuery = "select count(id) as count from information where 1 = 1 and Is_Deleted = 0 ";

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
                string selectedGender = gender.SelectedIndex == 0 ? "" : " and gender='" + gender.SelectedItem.Text + "'";
                string selectedDepartment = department.SelectedIndex == 0 ? "" : " and department='" + department.SelectedItem.Text + "'";
                string selectedTitle = title.SelectedIndex == 0 ? "" : " and title='" + title.SelectedItem.Text + "'";
                string selectedBloodGroup = bloodGroup.SelectedIndex == 0 ? "" : " and Blood_Group='" + bloodGroup.SelectedItem.Text + "'";
                string selectedBloodGroupChecked = bloodGroupChecked.SelectedIndex == 0 ? "" : " and Blood_Group_Checked=" + bloodGroupChecked.SelectedValue;
                string selectedImageProvided = imageProvided.Checked == false ? "" : " and Image_Provided=1" ;
                string selectedFormFilled = formFilled.Checked == false ? "" : " and Form_Filled=1" ;
                string selectedPaymentType = paymentType.SelectedIndex == 0 ? "" : " and Is_paid=" + paymentType.SelectedValue;
                string selectedVerified = verified.SelectedIndex == 0 ? "" : " and Is_verified=" + verified.SelectedValue;
                string selectedPresentStatus = presentstatus.SelectedIndex == 0 ? "" : " and Present_Status='" + presentstatus.SelectedItem.Text + "'";

                string orderByColumns = orderBy.SelectedIndex == 0 ? "" : " order by " + orderBy.SelectedValue;
                if (withTableData.Checked == true || withTableDataNImage.Checked == true || orderByColumns != "")
                    search = commonQuery + selectedOfficeMobile + selectedMobileNo + selectedClass + selectedShift + selectedTitle+ selectedGender +selectedDepartment + selectedBloodGroup + selectedBloodGroupChecked + selectedPaymentType + selectedImageProvided + selectedFormFilled + selectedVerified + selectedPresentStatus + orderByColumns;
                else
                    search = countQuery + selectedOfficeMobile + selectedMobileNo + selectedClass + selectedShift + selectedTitle + selectedGender + selectedDepartment + selectedBloodGroup + selectedBloodGroupChecked + selectedPaymentType + selectedImageProvided + selectedFormFilled + selectedVerified + selectedPresentStatus + orderByColumns;

            }
            
            SqlConnection conn = new SqlConnection(Information.connectionstring);
            SqlCommand cmd = new SqlCommand(search, conn);
            conn.Open();
            SqlDataReader reader = null;
            if (withTableData.Checked == true || withTableDataNImage.Checked == true || id.Text.Trim() != "" || orderBy.SelectedIndex != 0)
            {
                if (withTableDataNImage.Checked == false)
                    list.Columns[3].Visible = false;
                else
                    list.Columns[3].Visible = true;

                reader = cmd.ExecuteReader();
                list.DataSource = reader;
                list.DataBind();
                
                msg.Text = list.Rows.Count + " records found";
                reader.Close();
                download.Enabled = true;
            }
            else
            {
                int rows = (int)cmd.ExecuteScalar();
                msg.Text = rows + " records found";
                download.Enabled = true;
            }

            withTableData.Checked = false;
            withTableDataNImage.Checked = false;
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
            department.SelectedIndex = 0;
            gender.SelectedIndex = 0;

            title.SelectedIndex = 0;

            officeNumber.Text = "";

            mobile.Text = "";

            bloodGroup.SelectedIndex = 0;
            bloodGroupChecked.SelectedIndex = 0;
            paymentType.SelectedIndex = 0;
            verified.SelectedIndex = 0;
            presentstatus.SelectedIndex = 0;
            paymentType.Enabled = false;
            imageProvided.Checked = false;
            formFilled.Checked = false;
            withTableData.Checked = false;
            withTableDataNImage.Checked = false;
            list.DataSource = null;
            list.DataBind();
            list.Columns[3].Visible = true;
            download.Enabled = false;
            orderBy.SelectedIndex = 0;
            msg.Text = "";
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
           server control at run time. */
            //EnableEventValidation = false;
        }
        protected void download_Click(object sender, EventArgs e)
        {
            list.Columns[3].Visible = false;//for download disabling the image column
            if (list.Rows.Count > 0)
            {
                Response.Clear();
                Response.Buffer = true;
                Response.ClearContent();
                Response.ClearHeaders();
                Response.Charset = "";
                string FileName = clas.SelectedItem.Text + " " + shift.SelectedItem.Text + " " + DateTime.Now + ".xls";
                StringWriter strwritter = new StringWriter();
                HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.ContentType = "application/vnd.ms-excel";
                Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
                list.GridLines = GridLines.Both;
                list.HeaderStyle.Font.Bold = true;
                list.RenderControl(htmltextwrtter);
                Response.Write(strwritter.ToString());
                Response.End();
            }
        }

        protected void withTableData_CheckedChanged(object sender, EventArgs e)
        {
            if (withTableData.Checked == true)
                withTableDataNImage.Checked = false;

        }

        protected void withTableDataNImage_CheckedChanged(object sender, EventArgs e)
        {
            if (withTableDataNImage.Checked == true)
                withTableData.Checked = false;
        }
    }
}