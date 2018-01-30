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
            else
                username.Text = Session["user_name"].ToString();
        }

        protected void searchButton1_Click(object sender, EventArgs e)
        {
            msg.Text = " ";
            list.DataSource = null;
          list.DataBind();
            String search;

            //if (clas.SelectedIndex != 0 && shift.SelectedIndex != 0 && title.SelectedIndex != 0 && mobile.Text != "")
            //{
            //    search = String.Format("select * from Information where Class='{0}' and Shift='{1}' and Title='{2}' and Mobile_Number='{3}'", clas.SelectedItem.Text, shift.SelectedItem.Text, title.SelectedItem.Text, mobile.Text);

            //}

            //else if (clas.SelectedIndex != 0 && shift.SelectedIndex != 0 && title.SelectedIndex != 0)
            //{
            //    search = String.Format("select * from Information where Class='{0}' and Shift='{1}' and Title='{2}'", clas.SelectedItem.Text, shift.SelectedItem.Text, title.SelectedItem.Text);

            //}
            //else if (clas.SelectedIndex != 0 && shift.SelectedIndex != 0)
            //{
            //    search = String.Format("select * from Information where Class='{0}' and Shift='{1}'", clas.SelectedItem.Text, shift.SelectedItem.Text);

            //}
            //else if (clas.SelectedIndex != 0 && title.SelectedIndex != 0)
            //{
            //    search = String.Format("select * from Information where Class='{0}' and Title='{1}'", clas.SelectedItem.Text, title.SelectedItem.Text);

            //}
            //else if (clas.SelectedIndex != 0 && mobile.Text != "")
            //{
            //    search = String.Format("select * from Information where Class='{0}' and Mobile_Number='{1}'", clas.SelectedItem.Text, mobile.Text);

            //}
            //else if (shift.SelectedIndex != 0 && title.SelectedIndex != 0 && mobile.Text != "")
            //{
            //    search = String.Format("select * from Information where Shift='{0}' and Title='{1}' and Mobile_Number='{2}'", shift.SelectedItem.Text, title.SelectedItem.Text, mobile.Text);

            //}

            //else if (shift.SelectedIndex != 0 && title.SelectedIndex != 0)
            //{
            //    search = String.Format("select * from Information where Shift='{0}' and Title='{1}'", shift.SelectedItem.Text, title.SelectedItem.Text);

            //}
            //else if (shift.SelectedIndex != 0 && mobile.Text != "")
            //{
            //    search = String.Format("select * from Information where Shift='{0}'  and Mobile_Number='{1}'", shift.SelectedItem.Text, mobile.Text);

            //}
            //else if (clas.SelectedIndex != 0 && title.SelectedIndex != 0 && mobile.Text != "")
            //{
            //    search = String.Format("select * from Information where Class='{0}' and Title='{1}' and Mobile_Number='{2}'", clas.SelectedItem.Text, title.SelectedItem.Text, mobile.Text);


            //}
            //else if ( title.SelectedIndex != 0 && mobile.Text != "")
            //{
            //    search = String.Format("select * from Information where Title='{0}' and Mobile_Number='{1}'", title.SelectedItem.Text, mobile.Text);

            //}
            //else if (clas.SelectedIndex != 0)
            //{
            //    search = String.Format("select * from Information where Class='{0}'", clas.SelectedItem.Text);

            //}

            //else if (shift.SelectedIndex != 0)
            //{
            //    search = String.Format("select * from Information where Shift='{0}'", shift.SelectedItem.Text);

            //}

            //else if (title.SelectedIndex != 0)
            //{
            //    search = String.Format("select * from Information where Title='{0}'", title.SelectedItem.Text);

            //}
            //else if (mobile.Text != "")
            //{
            //    search = String.Format("select * from Information where Mobile_Number='{0}'", mobile.Text);

            //}
            //else
            //{
            //    search = "select * from Information ";

            //}

            if (clas.SelectedIndex == 0 && shift.SelectedIndex == 0 && title.SelectedIndex == 0 && mobile.Text == "")
            {
                search = String.Format("select * from Information");

            }

            string selectedClass = clas.SelectedIndex == 0 ? "" : " and class="+clas.SelectedItem.Text;//class 9
          
            string selectedShift = shift.SelectedIndex == 0 ? "" : " and shift="+shift.SelectedItem.Text;
            string selectedTitle = title.SelectedIndex == 0 ? "" : " and title=" + title.SelectedItem.Text;
            string selectedMobile = mobile.Text == "" ? "" : " and mobile="+mobile.Text;

            if (clas.SelectedIndex == 0 && shift.SelectedIndex == 0 && title.SelectedIndex == 0 && mobile.Text == "")
            {
                search = "select * from Infomation where 1 = 1 " + selectedClass + selectedShift + selectedTitle + selectedMobile;

            }
            search = "select * from Infomation where " + selectedClass + selectedShift + selectedTitle + selectedMobile;
            //search = "select * from Infomation where " + ((clas.SelectedItem.Value ="0"? "": "class = " + clas.SelectedItem.Text ) +" and shift = " + shift.SelectedItem.Text;
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
            
           
            clas.SelectedIndex = 0;
           
            shift.SelectedIndex = 0;
           
            title.SelectedIndex = 0;
           
            mobile.Text = "";
            
        
    }
    }
}