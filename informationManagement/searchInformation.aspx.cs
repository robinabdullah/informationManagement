using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class searchInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_name"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else if(Session["role"].ToString() == "guest")
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
            string commonQuery = "select Information.id, Information.Name, Class, Section, Department, Gender, Roll, Shift, Title,Office_Phone as Personal_Number, DateofBirth, Mobile_Number as Guardian_Number,Home_Address, newLogin.name as Created_By,Created_Date, Updated_By,Updated_Date, Deleted_By, Deleted_Date, Image_Provided, Form_Filled from Information, newLogin where created_by=newLogin.ID ";

            if (id.Text.Trim() !="")
            {
                search = String.Format(commonQuery + " and Information.id={0}", id.Text.Trim());
            }
            else if (clas.SelectedIndex != 0 && shift.SelectedIndex != 0 && title.SelectedIndex != 0 && officeNumber.Text != "")
            {
                search = String.Format(commonQuery + " and Class='{0}' and Shift='{1}' and Title='{2}' and Office_Phone='{3}'", clas.SelectedItem.Text, shift.SelectedItem.Text, title.SelectedItem.Text, officeNumber.Text);

            }
            else if (clas.SelectedIndex != 0 && shift.SelectedIndex != 0 && title.SelectedIndex != 0)
            {
                search = String.Format(commonQuery + " and Class='{0}' and Shift='{1}' and Title='{2}'", clas.SelectedItem.Text, shift.SelectedItem.Text, title.SelectedItem.Text);

            }
            else if (clas.SelectedIndex != 0 && shift.SelectedIndex != 0)
            {
                search = String.Format(commonQuery + " and Class='{0}' and Shift='{1}'", clas.SelectedItem.Text, shift.SelectedItem.Text);

            }
            else if (clas.SelectedIndex != 0 && title.SelectedIndex != 0)
            {
                search = String.Format(commonQuery + " and Class='{0}' and Title='{1}'", clas.SelectedItem.Text, title.SelectedItem.Text);

            }
            else if (clas.SelectedIndex != 0 && officeNumber.Text != "")
            {
                search = String.Format(commonQuery + " and Class='{0}' and Office_Phone='{1}'", clas.SelectedItem.Text, officeNumber.Text);

            }
            else if (shift.SelectedIndex != 0 && title.SelectedIndex != 0 && officeNumber.Text != "")
            {
                search = String.Format(commonQuery + " and Shift='{0}' and Title='{1}' and Office_Phone='{2}'", shift.SelectedItem.Text, title.SelectedItem.Text, officeNumber.Text);

            }

            else if (shift.SelectedIndex != 0 && title.SelectedIndex != 0)
            {
                search = String.Format(commonQuery + " and Shift='{0}' and Title='{1}'", shift.SelectedItem.Text, title.SelectedItem.Text);

            }
            else if (shift.SelectedIndex != 0 && officeNumber.Text != "")
            {
                search = String.Format(commonQuery + " and Shift='{0}'  and Office_Phone='{1}'", shift.SelectedItem.Text, officeNumber.Text);

            }
            else if (clas.SelectedIndex != 0 && title.SelectedIndex != 0 && officeNumber.Text != "")
            {
                search = String.Format(commonQuery + " and Class='{0}' and Title='{1}' and Office_Phone='{2}'", clas.SelectedItem.Text, title.SelectedItem.Text, officeNumber.Text);


            }
            else if (title.SelectedIndex != 0 && officeNumber.Text != "")
            {
                search = String.Format(commonQuery + " and Title='{0}' and Office_Phone='{1}'", title.SelectedItem.Text, officeNumber.Text);

            }
            else if (clas.SelectedIndex != 0)
            {
                search = String.Format(commonQuery + " and Class='{0}'", clas.SelectedItem.Text);

            }

            else if (shift.SelectedIndex != 0)
            {
                search = String.Format(commonQuery + " and Shift='{0}'", shift.SelectedItem.Text);

            }

            else if (title.SelectedIndex != 0)
            {
                search = String.Format(commonQuery + " and Title='{0}'", title.SelectedItem.Text);

            }
            else if (officeNumber.Text != "")
            {
                search = String.Format(commonQuery + " and Office_Phone='{0}'", officeNumber.Text);

            }
            else
            {
                search = commonQuery;

            }

            SqlConnection conn = new SqlConnection(Information.connectionstring);
            SqlCommand cmd = new SqlCommand(search, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == false)
            {
                msg.Text = "Not found";
            }
            else
            {
                list.DataSource = reader;
                list.DataBind();
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            //Session["user_name"] = null;
            Session.Clear();
            Response.Redirect("LoginPage.aspx");
        }

        protected void reset_Click(object sender, EventArgs e)
        {

            id.Text = "";
            clas.SelectedIndex = 0;

            shift.SelectedIndex = 0;

            title.SelectedIndex = 0;

            officeNumber.Text = "";

            list.DataSource = null;
            list.DataBind();
        }


    }
}